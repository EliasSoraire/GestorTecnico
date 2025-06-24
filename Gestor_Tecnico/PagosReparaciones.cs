using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class PagosReparaciones : Form
    {
        private int reparacionSeleccionadaId = -1;
        private decimal saldoRestante = 0;

        public PagosReparaciones()
        {
            InitializeComponent();
            this.Load += PagosReparaciones_Load;
            dgvReparaciones.CellContentClick += dgvReparaciones_CellContentClick;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
        }

        private void PagosReparaciones_Load(object sender, EventArgs e)
        {
            CargarReparacionesImpagas();
            CargarMediosPago();
        }

        private void CargarReparacionesImpagas()
        {
            dgvReparaciones.Rows.Clear();
            string conexion = "Server=DESKTOP-JJJUFEH\\SQLEXPRESS02;Database=Gestor_Tecnico;Integrated Security=true;";

            string query = @"
                SELECT 
                    r.idReparacion,
                    c.Nombre + ' ' + c.Apellido AS Cliente,
                    te.Descripcion AS Equipo,
                    r.MontoTotal,
                    ISNULL(SUM(pr.Monto), 0) AS TotalPagado,
                    r.MontoTotal - ISNULL(SUM(pr.Monto), 0) AS SaldoRestante
                FROM Reparaciones r
                JOIN Cliente c ON r.idCliente = c.idCliente
                JOIN TipoEquipo te ON r.idTipoEquipo = te.idEquipo
                LEFT JOIN PagosReparacion pr ON r.idReparacion = pr.idReparacion
                GROUP BY r.idReparacion, c.Nombre, c.Apellido, te.Descripcion, r.MontoTotal
                HAVING r.MontoTotal - ISNULL(SUM(pr.Monto), 0) > 0";

            using (SqlConnection conn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int rowIndex = dgvReparaciones.Rows.Add();
                    dgvReparaciones.Rows[rowIndex].Cells["colCliente"].Value = reader["Cliente"].ToString();
                    dgvReparaciones.Rows[rowIndex].Cells["colEquipo"].Value = reader["Equipo"].ToString();
                    dgvReparaciones.Rows[rowIndex].Cells["colPrecioTotal"].Value = reader["MontoTotal"].ToString();
                    dgvReparaciones.Rows[rowIndex].Cells["colTotalPagado"].Value = reader["TotalPagado"].ToString();
                    dgvReparaciones.Rows[rowIndex].Cells["colSaldoRestante"].Value = reader["SaldoRestante"].ToString();
                    dgvReparaciones.Rows[rowIndex].Tag = reader["idReparacion"];
                }
            }
        }

        private void CargarMediosPago()
        {
            string conexion = "Server=DESKTOP-JJJUFEH\\SQLEXPRESS02;Database=Gestor_Tecnico;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT idMedioPago, Descripcion FROM MediosPago";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbMedioPago.DisplayMember = "Descripcion";
                cmbMedioPago.ValueMember = "idMedioPago";
                cmbMedioPago.DataSource = dt;
            }
        }

        private void dgvReparaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvReparaciones.Columns["ColSeleccionar"].Index && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dgvReparaciones.Rows)
                {
                    DataGridViewCheckBoxCell cell = row.Cells["ColSeleccionar"] as DataGridViewCheckBoxCell;
                    if (cell != null)
                        cell.Value = false;
                }

                dgvReparaciones.Rows[e.RowIndex].Cells["ColSeleccionar"].Value = true;

                reparacionSeleccionadaId = (int)dgvReparaciones.Rows[e.RowIndex].Tag;
                lblCliente.Text = "Cliente: " + dgvReparaciones.Rows[e.RowIndex].Cells["colCliente"].Value.ToString();
                lblEquipo.Text = "Equipo: " + dgvReparaciones.Rows[e.RowIndex].Cells["colEquipo"].Value.ToString();
                lblMontoTotal.Text = "Monto Total: $" + dgvReparaciones.Rows[e.RowIndex].Cells["colPrecioTotal"].Value.ToString();
                lblTotalPagado.Text = "Total Abonado: $" + dgvReparaciones.Rows[e.RowIndex].Cells["colTotalPagado"].Value.ToString();
                lblSaldo.Text = "Saldo Restante: $" + dgvReparaciones.Rows[e.RowIndex].Cells["colSaldoRestante"].Value.ToString();

                saldoRestante = Convert.ToDecimal(dgvReparaciones.Rows[e.RowIndex].Cells["colSaldoRestante"].Value);
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (reparacionSeleccionadaId == -1)
            {
                MessageBox.Show("Por favor, seleccioná una reparación.");
                return;
            }

            if (!decimal.TryParse(txtMontoAbonar.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingresá un monto válido.");
                return;
            }

            if (monto > saldoRestante)
            {
                MessageBox.Show("El monto ingresado excede el saldo restante.");
                return;
            }

            if (cmbMedioPago.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un medio de pago.");
                return;
            }

            int medioPagoId = Convert.ToInt32(((DataRowView)cmbMedioPago.SelectedItem)["idMedioPago"]);

            string conexion = "Server=DESKTOP-JJJUFEH\\SQLEXPRESS02;Database=Gestor_Tecnico;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "INSERT INTO PagosReparacion (idReparacion, idMedioPago, Monto, FechaPago) VALUES (@idReparacion, @idMedioPago, @Monto, @FechaPago)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idReparacion", reparacionSeleccionadaId);
                    cmd.Parameters.AddWithValue("@idMedioPago", medioPagoId);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@FechaPago", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Pago registrado correctamente.");
            txtMontoAbonar.Clear();
            reparacionSeleccionadaId = -1;
            saldoRestante = 0;
            lblCliente.Text = "Cliente:";
            lblEquipo.Text = "Equipo:";
            lblMontoTotal.Text = "Monto Total:";
            lblTotalPagado.Text = "Total Abonado:";
            lblSaldo.Text = "Saldo Restante:";
            CargarReparacionesImpagas();
        }
    }
}
