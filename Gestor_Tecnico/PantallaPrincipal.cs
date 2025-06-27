using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class PantallaPrincipal : Form
    {
        private ConexionSQL conexionSQL;

        public PantallaPrincipal()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();
            dgvStock.AllowUserToAddRows = false;
            this.Load += PantallaPrincipal_Load;
            dgvStock.CellPainting += dgvStock_CellPainting;
            dgvStock.CellClick += dgvStock_CellClick;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos(string filtro = "")
        {
            dgvStock.Rows.Clear();

            try
            {
                using (SqlConnection conn = conexionSQL.ObtenerConexion())
                {
                    if (conn == null) return;

                    string query = @"
                        SELECT p.idProducto, p.Nombre, p.Modelo, t.Descripcion AS Tipo, p.Stock, p.PrecioVenta
                        FROM Producto p
                        INNER JOIN TiposProducto t ON p.idTipoProducto = t.idTipoProducto";

                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        query += " WHERE p.Nombre LIKE @Filtro OR t.Descripcion LIKE @Filtro";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrWhiteSpace(filtro))
                        cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
                    int idProducto = (int)dgvStock.Rows[e.RowIndex].Tag;
                    string nombre = dgvStock.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();
                    string modelo = dgvStock.Rows[e.RowIndex].Cells["colModelo"].Value.ToString();
                    string tipo = dgvStock.Rows[e.RowIndex].Cells["colTipo"].Value.ToString();
                    decimal precio = decimal.Parse(dgvStock.Rows[e.RowIndex].Cells["colPrecio"].Value.ToString(), System.Globalization.NumberStyles.Currency);
                    int stock = int.Parse(dgvStock.Rows[e.RowIndex].Cells["colStock"].Value.ToString());

                    EditarProducto formEditar = new EditarProducto(idProducto, nombre, modelo, tipo, precio, stock);
                    formEditar.ProductoEditado += (s, args) => CargarProductos();
                    formEditar.ShowDialog();
                }
                else if (x >= anchoBoton + 2 * separacion && x <= anchoBoton * 2 + 2 * separacion)
                {
                    int idProducto = (int)dgvStock.Rows[e.RowIndex].Tag;
                    string nombre = dgvStock.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();

                    var confirm = MessageBox.Show($"¿Seguro que quieres eliminar el producto \"{nombre}\"?",
                                                  "Confirmar eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        EliminarProducto(idProducto);
                        CargarProductos();
                    }
                }
            }
        }

        private void EliminarProducto(int idProducto)
        {
            try
            {
                using (SqlConnection conn = conexionSQL.ObtenerConexion())
                {
                    if (conn == null) return;

                    string query = "DELETE FROM Producto WHERE idProducto = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idProducto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarProducto.Text.Trim();
            CargarProductos(filtro);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto formulario = new AgregarProducto();
            formulario.ShowDialog();
            CargarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reparaciones reparaciones = new Reparaciones();
            reparaciones.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestiondeVentas ventas = new GestiondeVentas();
            ventas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestiondeClientes clientes = new GestiondeClientes();
            clientes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }
    }
}