using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            this.Load += PantallaPrincipal_Load; // Asegura que el evento Load esté conectado
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        
        private void CargarProductos()
        {
            dgvStock.Rows.Clear();

            string conexion = "Server=DESKTOP-JJJUFEH\\SQLEXPRESS02;Database=Gestor_Tecnico;Integrated Security=true;";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    string query = @"
                        SELECT p.idProducto, p.Nombre, p.Modelo, t.Descripcion AS Tipo, p.Stock, p.PrecioVenta
                        FROM Producto p
                        INNER JOIN TiposProducto t ON p.idTipoProducto = t.idTipoProducto";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        int rowIndex = dgvStock.Rows.Add();
                        dgvStock.Rows[rowIndex].Cells["colNombre"].Value = row["Nombre"].ToString();
                        dgvStock.Rows[rowIndex].Cells["colModelo"].Value = row["Modelo"].ToString();
                        dgvStock.Rows[rowIndex].Cells["colTipo"].Value = row["Tipo"].ToString();
                        dgvStock.Rows[rowIndex].Cells["colStock"].Value = row["Stock"].ToString();
                        dgvStock.Rows[rowIndex].Cells["colPrecio"].Value = Convert.ToDecimal(row["PrecioVenta"]).ToString("C2");
                        dgvStock.Rows[rowIndex].Cells["colAcciones"].Value = "Editar / Eliminar";
                    }

                    MessageBox.Show("Productos cargados: " + dt.Rows.Count, "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombreColumna = dgvStock.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "colAcciones")
                {
                    MessageBox.Show("Aquí iría la lógica de editar o eliminar.");
                }
            }
        }
    }
}
