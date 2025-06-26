using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class FormDetalleReparacion : Form
    {
        public event Action<int, string> EstadoActualizado;
        private readonly int _idRep;

        public FormDetalleReparacion(int idReparacion)
        {
            InitializeComponent();
            _idRep = idReparacion;
        }

        /* ---------- EVENTOS ---------- */

        private void FormDetalleReparacion_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = $"Detalle Reparación: {_idRep}";
            CargarEstadosEnComboBox();   // Opcional: estados fijos
            CargarDatosDetalle();        // Trae y muestra los datos
        }

        private void btnCancelarDet_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* ---------- LÓGICA ---------- */

        private void CargarEstadosEnComboBox()
        {
            try
            {
                using var cn = new ConexionSQL().ObtenerConexion();
                using var da = new SqlDataAdapter(
                    "SELECT idEstado, Descripcion FROM EstadosReparacion ORDER BY idEstado", cn);

                var dt = new DataTable();
                da.Fill(dt);

                cbNuevoEstado.DisplayMember = "Descripcion";
                cbNuevoEstado.ValueMember = "idEstado";
                cbNuevoEstado.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo conectar a la base de datos:\n{ex.Message}",
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();    // cierra el detalle porque no tiene sentido sin datos
            }
        }

        private void CargarDatosDetalle()
        {
            const string sql = @"
SELECT
    r.idEstado,                        -- id numérico
    er.Descripcion       AS EstadoActual,
    r.Modelo,
    r.DescripcionProblema AS Descripcion,
    r.PresupuestoEstimado AS Presupuesto,
    r.FechaIngreso,
    r.FechaEntrega,
    c.Nombre,
    c.Apellido,
    c.DNI,
    mp.Descripcion        AS MedioPago
FROM Reparaciones r
JOIN Cliente            c  ON c.idCliente      = r.idCliente
JOIN EstadosReparacion  er ON er.idEstado      = r.idEstado
LEFT JOIN PagosReparacion pr ON pr.idReparacion = r.idReparacion
LEFT JOIN MediosPago       mp ON mp.idMedioPago  = pr.idMedioPago
WHERE r.idReparacion = @id;";

            try
            {
                using var cn = new ConexionSQL().ObtenerConexion();
                using var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", _idRep);

                using var rd = cmd.ExecuteReader();
                if (!rd.Read())
                {
                    MessageBox.Show("No se encontraron datos para esta reparación.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }

                // ------- mapeo a controles (igual que antes) -------
                string nombre = rd["Nombre"]?.ToString() ?? "";
                string apellido = rd["Apellido"]?.ToString() ?? "";
                lblClienteValor.Text = $"{nombre} {apellido}".Trim();

                lblDniValor.Text = rd["DNI"]?.ToString() ?? "";
                lblFechaValor.Text = rd["FechaIngreso"] != DBNull.Value
                                     ? Convert.ToDateTime(rd["FechaIngreso"]).ToString("dd/MM/yyyy")
                                     : "";
                lblMedioPago.Text = rd["MedioPago"] != DBNull.Value
                                     ? rd["MedioPago"].ToString()
                                     : "Sin pago";

                txtModeloDet.Text = rd["Modelo"]?.ToString() ?? "";
                txtDescripcionDet.Text = rd["Descripcion"]?.ToString() ?? "";
                txtPresupuestoDet.Text = rd["Presupuesto"]?.ToString() ?? "";

                int idActual = (int)rd["idEstado"];
                cbNuevoEstado.SelectedValue = idActual;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sin conexión:\n{ex.Message}",
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnGuardarDet_Click(object sender, EventArgs e)
        {
            if (cbNuevoEstado.SelectedValue == null)
            {
                MessageBox.Show("Elegí un estado antes de guardar.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEstadoSeleccionado = Convert.ToInt32(cbNuevoEstado.SelectedValue);
            string descEstado = cbNuevoEstado.Text;

            string modelo = txtModeloDet.Text.Trim();
            string descripcion = txtDescripcionDet.Text.Trim();
            if (!decimal.TryParse(txtPresupuestoDet.Text.Trim(), out var presupuesto))
            {
                MessageBox.Show("Presupuesto inválido.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const int ID_ENTREGADO = 3;

            var sb = new StringBuilder();
            sb.AppendLine("UPDATE Reparaciones");
            sb.AppendLine("SET Modelo = @modelo,");
            sb.AppendLine("    DescripcionProblema = @descr,");
            sb.AppendLine("    PresupuestoEstimado = @pres,");
            sb.AppendLine("    idEstado = @est");
            if (idEstadoSeleccionado == ID_ENTREGADO)
                sb.AppendLine(",   FechaEntrega = GETDATE()");
            sb.AppendLine("WHERE idReparacion = @id;");

            try
            {
                using var cn = new ConexionSQL().ObtenerConexion();
                using var cmd = new SqlCommand(sb.ToString(), cn);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@descr", descripcion);
                cmd.Parameters.AddWithValue("@pres", presupuesto);
                cmd.Parameters.AddWithValue("@est", idEstadoSeleccionado);
                cmd.Parameters.AddWithValue("@id", _idRep);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo guardar:\n{ex.Message}",
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstadoActualizado?.Invoke(_idRep, descEstado);

            MessageBox.Show("Cambios guardados correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}