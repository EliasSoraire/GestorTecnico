using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class Reparaciones : Form
    {
        private string rutaImagenSeleccionada = string.Empty;

        public Reparaciones()
        {
            InitializeComponent();
            this.Load += Reparaciones_Load;

        }
        private void Reparaciones_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                CargarReparacionesEnDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al inicializar formulario:\n{ex.GetType().Name}: {ex.Message}",
                    "Error crítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnImagen_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    rutaImagenSeleccionada = ofd.FileName;
            }
        }

        private void btnGuardarReparacion_Click(object sender, EventArgs e)
        {


            if (cbDniCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccioná un DNI de cliente.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDniCliente.Focus();
                return;
            }
            if (cbTipoEquipo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccioná un tipo de equipo.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTipoEquipo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("El campo Modelo es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("El campo Descripción es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }
            if (!decimal.TryParse(txtPresupuesto.Text.Trim(), out var presupuesto) || presupuesto <= 0)
            {
                MessageBox.Show("El Presupuesto debe ser un número mayor que cero.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPresupuesto.Focus();
                return;
            }

            if (cbMedioPago.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccioná un medio de pago.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMedioPago.Focus();
                return;
            }
            // 7) Fecha de Ingreso no puede ser futura
            if (dtpFechaIngreso.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La Fecha de Ingreso no puede ser posterior a hoy.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaIngreso.Focus();
                return;
            }

            // 8) Fecha de Entrega no puede ser anterior a la Fecha de Ingreso
            if (dtpFechaEntrega.Value.Date < dtpFechaIngreso.Value.Date)
            {
                MessageBox.Show(
                  "La Fecha de Entrega no puede ser anterior a la Fecha de Ingreso.",
                  "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                dtpFechaEntrega.Focus();
                return;
            }

            // 3) OBTENER idCliente DESDE DNI
            int idCliente;
            using (var cn = new ConexionSQL().ObtenerConexion())
            using (var cmd = new SqlCommand("SELECT idCliente FROM Cliente WHERE DNI = @dni", cn))
            {
                cmd.Parameters.AddWithValue("@dni", cbDniCliente.SelectedValue);
                var result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("El DNI seleccionado no existe.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                idCliente = Convert.ToInt32(result);
            }

            // 4) GUARDAR EN BASE DE DATOS (Reparaciones, PagosReparacion, FotosReparaciones)
            int idReparacion;
            using (var cn = new ConexionSQL().ObtenerConexion())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // a) Reparaciones
                    string sqlRep = @"
                        INSERT INTO Reparaciones
                          (idCliente, idTipoEquipo, Modelo, DescripcionProblema,
                           PresupuestoEstimado, FechaIngreso, idEstado, FechaEntrega, MontoTotal)
                        VALUES
                          (@cli, @tipo, @mod, @desc, @pres, @ing, @est, @entrega, @monto);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    using (var cmd = new SqlCommand(sqlRep, cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@cli", idCliente);
                        cmd.Parameters.AddWithValue("@tipo", cbTipoEquipo.SelectedValue);
                        cmd.Parameters.AddWithValue("@mod", txtModelo.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@pres", presupuesto);
                        cmd.Parameters.AddWithValue("@ing", dtpFechaIngreso.Value.Date);
                        cmd.Parameters.AddWithValue("@est", 1);
                        cmd.Parameters.AddWithValue("@entrega", dtpFechaEntrega.Value.Date);
                        cmd.Parameters.AddWithValue("@monto", presupuesto);
                        idReparacion = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // b) PagosReparacion
                    string sqlPago = @"
                        INSERT INTO PagosReparacion
                          (idReparacion, idMedioPago, Monto, FechaPago)
                        VALUES
                          (@rep, @mp, @monto, @fpago);";
                    using (var cmd = new SqlCommand(sqlPago, cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@rep", idReparacion);
                        cmd.Parameters.AddWithValue("@mp", cbMedioPago.SelectedValue);
                        cmd.Parameters.AddWithValue("@monto", presupuesto);
                        cmd.Parameters.AddWithValue("@fpago", dtpFechaIngreso.Value.Date);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }

            // 5) INFORMAR AL USUARIO
            MessageBox.Show("Reparación registrada con éxito.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 6) LIMPIAR FORMULARIO y RECARGAR GRID
            CargarReparacionesEnDGV();
            LimpiarFormulario();
        }
        private void txtPresupuesto_Leave(object sender, EventArgs e)
        {
            var raw = txtPresupuesto.Text.Trim().Replace(',', '.');
            if (decimal.TryParse(raw, NumberStyles.AllowDecimalPoint,
                                 CultureInfo.InvariantCulture, out var val))
            {
                // Formato regional: 2 decimales, separador de miles
                txtPresupuesto.Text = val.ToString("N2", CultureInfo.CurrentCulture);
            }
        }

        private void LimpiarFormulario()
        {
            cbDniCliente.SelectedIndex = -1;
            cbTipoEquipo.SelectedIndex = -1;
            cbMedioPago.SelectedIndex = -1;
            txtModelo.Clear();
            txtDescripcion.Clear();
            txtPresupuesto.Clear();
            dtpFechaIngreso.Value = DateTime.Today;
        }

        private void CargarCombos()
        {
            // 1) Clientes (DNI)
            var dtCli = new DataTable();
            using (var cn = new ConexionSQL().ObtenerConexion())
            using (var da = new SqlDataAdapter("SELECT DNI FROM Cliente ORDER BY DNI", cn))
                da.Fill(dtCli);

            cbDniCliente.DataSource = dtCli;
            cbDniCliente.DisplayMember = "DNI";
            cbDniCliente.ValueMember = "DNI";
            cbDniCliente.SelectedIndex = -1;

            // 2) Tipos de Equipo
            var dtTipo = new DataTable();
            using (var cn = new ConexionSQL().ObtenerConexion())
            using (var da = new SqlDataAdapter("SELECT idEquipo, Descripcion FROM TipoEquipo ORDER BY Descripcion", cn))
                da.Fill(dtTipo);

            cbTipoEquipo.DataSource = dtTipo;
            cbTipoEquipo.DisplayMember = "Descripcion";
            cbTipoEquipo.ValueMember = "idEquipo";
            cbTipoEquipo.SelectedIndex = -1;

            // 3) Medios de Pago
            var dtPago = new DataTable();
            using (var cn = new ConexionSQL().ObtenerConexion())
            using (var da = new SqlDataAdapter("SELECT idMedioPago, Descripcion FROM MediosPago ORDER BY Descripcion", cn))
                da.Fill(dtPago);

            cbMedioPago.DataSource = dtPago;
            cbMedioPago.DisplayMember = "Descripcion";
            cbMedioPago.ValueMember = "idMedioPago";
            cbMedioPago.SelectedIndex = -1;

            // 4) Estados de Reparación (con “Todos” al inicio)
            var dtEst = new DataTable();
            using (var cn = new ConexionSQL().ObtenerConexion())
            using (var da = new SqlDataAdapter("SELECT idEstado, Descripcion FROM EstadosReparacion ORDER BY idEstado", cn))
                da.Fill(dtEst);

            // Insertar “Todos” en la primera fila
            var todas = dtEst.NewRow();
            todas["idEstado"] = 0;
            todas["Descripcion"] = "Todos";
            dtEst.Rows.InsertAt(todas, 0);

            cbEstado.DataSource = dtEst;
            cbEstado.DisplayMember = "Descripcion";
            cbEstado.ValueMember = "idEstado";
            cbEstado.SelectedIndex = 0;

            // ---- DEBUG: chequeo de nulls ----
            var nulos = new List<string>();
            if (cbDniCliente == null) nulos.Add("cbDniCliente");
            if (cbTipoEquipo == null) nulos.Add("cbTipoEquipo");
            if (cbMedioPago == null) nulos.Add("cbMedioPago");
            if (cbEstado == null) nulos.Add("cbEstado");
            if (txtBuscarCliente == null) nulos.Add("txtBuscarCliente");
            if (nulos.Count > 0)
            {
                MessageBox.Show(
                    "Controles NULL en CargarCombos():\n" + string.Join(", ", nulos),
                    "Error de nombres",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CargarReparacionesEnDGV()
        {
            // 1) Base del SELECT (sin la coma final en FechaEntrega)
            var sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("  c.Nombre + ' ' + c.Apellido AS Nombre,");
            sb.AppendLine("  te.Descripcion            AS Tipo,");
            sb.AppendLine("  r.Modelo,");
            sb.AppendLine("  r.DescripcionProblema     AS Descripcion,");
            sb.AppendLine("  r.PresupuestoEstimado     AS Presupuesto,");
            sb.AppendLine("  mp.Descripcion            AS MedioPago,");
            sb.AppendLine("  r.FechaIngreso            AS FechaIngreso,");
            sb.AppendLine("  r.FechaEntrega            AS FechaEntrega");
            sb.AppendLine("FROM Reparaciones r");
            sb.AppendLine("  INNER JOIN Cliente        c  ON r.idCliente    = c.idCliente");
            sb.AppendLine("  INNER JOIN TipoEquipo     te ON r.idTipoEquipo = te.idEquipo");
            sb.AppendLine("  INNER JOIN PagosReparacion pr ON pr.idReparacion = r.idReparacion");
            sb.AppendLine("  INNER JOIN MediosPago     mp ON pr.idMedioPago  = mp.idMedioPago");

            // 2) Construyo lista de condiciones
            var filtros = new List<string>();
            filtros.Add("r.idEstado = @pendiente");       // siempre filtro pendientes

            if (cbEstado.SelectedIndex > 0)
                filtros.Add("r.idEstado = @estado");     // filtro por estado distinto de “Todos”

            if (!string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
            {
                filtros.Add("("
                  + "c.DNI LIKE @busq "
                  + "OR c.Nombre LIKE @busq "
                  + "OR c.Apellido LIKE @busq "
                  + "OR (c.Nombre + ' ' + c.Apellido) LIKE @busq"
                  + ")");
            }

            // 3) Uno las condiciones con AND y agrego el ORDER
            sb.AppendLine("WHERE " + string.Join(" AND ", filtros));
            sb.AppendLine("ORDER BY r.FechaIngreso DESC;");

            // 4) Ejecuto la consulta y lleno el DataTable
            var dt = new DataTable();
            using (var cn = new ConexionSQL().ObtenerConexion())
            using (var cmd = new SqlCommand(sb.ToString(), cn))
            {
                cmd.Parameters.AddWithValue("@pendiente", 1);
                if (cbEstado.SelectedIndex > 0)
                    cmd.Parameters.AddWithValue("@estado", cbEstado.SelectedValue);
                if (!string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
                    cmd.Parameters.AddWithValue("@busq", $"%{txtBuscarCliente.Text.Trim()}%");

                using (var da = new SqlDataAdapter(cmd))
                    da.Fill(dt);
            }

            // 5) Asigno al grid
            dgvReparaciones.AutoGenerateColumns = false;
            dgvReparaciones.DataSource = dt;

            // 6) Ajusto DisplayIndex de “col…”
            dgvReparaciones.Columns["colNombre"].DisplayIndex = 0;
            dgvReparaciones.Columns["colTipo"].DisplayIndex = 1;
            dgvReparaciones.Columns["colModelo"].DisplayIndex = 2;
            dgvReparaciones.Columns["colDescripcion"].DisplayIndex = 3;
            dgvReparaciones.Columns["colPresupuesto"].DisplayIndex = 4;
            dgvReparaciones.Columns["colMedioPago"].DisplayIndex = 5;
            dgvReparaciones.Columns["colFechaIngreso"].DisplayIndex = 6;
            dgvReparaciones.Columns["colFechaEntrega"].DisplayIndex = 7;
            dgvReparaciones.Columns["colAcciones"].DisplayIndex = 8;
        }
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            CargarReparacionesEnDGV();
        }
    }
}