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
            this.Load += PantallaPrincipal_Load;
            dgvStock.CellPainting += dgvStock_CellPainting;
            dgvStock.CellClick += dgvStock_CellClick;
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

                        // Guardar el idProducto en la fila (invisible o Tag)
                        dgvStock.Rows[rowIndex].Tag = row["idProducto"];

                        dgvStock.Rows[rowIndex].Cells["colAcciones"].Value = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStock_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvStock.Columns["colAcciones"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                int anchoBoton = 60;
                int separacion = 5;

                Rectangle btnEditar = new Rectangle(e.CellBounds.Left + separacion, e.CellBounds.Top + 5, anchoBoton, e.CellBounds.Height - 10);
                Rectangle btnEliminar = new Rectangle(e.CellBounds.Left + anchoBoton + 2 * separacion, e.CellBounds.Top + 5, anchoBoton, e.CellBounds.Height - 10);

                ButtonRenderer.DrawButton(e.Graphics, btnEditar, "Editar", dgvStock.Font, false, System.Windows.Forms.VisualStyles.PushButtonState.Default);
                ButtonRenderer.DrawButton(e.Graphics, btnEliminar, "Eliminar", dgvStock.Font, false, System.Windows.Forms.VisualStyles.PushButtonState.Default);

                e.Handled = true;
            }
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvStock.Columns["colAcciones"].Index)
            {
                Rectangle celda = dgvStock.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int x = dgvStock.PointToClient(Cursor.Position).X - celda.X;
                int anchoBoton = 60;
                int separacion = 5;

                if (x >= separacion && x <= separacion + anchoBoton)
                {
                    // → Botón Editar
                    int idProducto = (int)dgvStock.Rows[e.RowIndex].Tag;
                    string nombre = dgvStock.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();
                    string modelo = dgvStock.Rows[e.RowIndex].Cells["colModelo"].Value.ToString();
                    string tipo = dgvStock.Rows[e.RowIndex].Cells["colTipo"].Value.ToString();
                    decimal precio = decimal.Parse(dgvStock.Rows[e.RowIndex].Cells["colPrecio"].Value.ToString(), System.Globalization.NumberStyles.Currency);
                    int stock = int.Parse(dgvStock.Rows[e.RowIndex].Cells["colStock"].Value.ToString());

                    EditarProducto formEditar = new EditarProducto(idProducto, nombre, modelo, tipo, precio, stock);
                    formEditar.ShowDialog();
                    CargarProductos(); // Refrescar tabla después de editar
                }
                else if (x >= anchoBoton + 2 * separacion && x <= anchoBoton * 2 + 2 * separacion)
                {
                    // → Botón Eliminar (lo dejamos para después)
                    MessageBox.Show("Eliminar producto");
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto formulario = new AgregarProducto();
            formulario.ShowDialog();
            CargarProductos(); // Refrescar la tabla al cerrar el formulario
        }
    }
}
