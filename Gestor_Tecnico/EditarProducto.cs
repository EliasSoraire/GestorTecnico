using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class EditarProducto : Form
    {
        private int _idProducto;
        public event EventHandler ProductoEditado;

        public EditarProducto()
        {
            InitializeComponent();
        }

        public EditarProducto(int idProducto, string nombre, string modelo, string tipo, decimal precio, int stock)
        {
            InitializeComponent();

            _idProducto = idProducto;
            CargarTiposProducto();

            // Llenar los campos con los datos recibidos
            txtEditarNombre.Text = nombre;
            txtEditarModelo.Text = modelo;
            txtEditarPrecio.Text = precio.ToString();
            txtEditarStock.Text = stock.ToString();

            int index = cmbEditarTipoProducto.FindStringExact(tipo);
            if (index != -1)
                cmbEditarTipoProducto.SelectedIndex = index;

            cmbEditarTipoProducto.DropDownStyle = ComboBoxStyle.DropDown;

            // Evento del botón
            btnGuardarProducto.Click += btnGuardarProducto_Click;

            // Activar placeholders
            AgregarPlaceholders();
        }


        private void CargarTiposProducto()
        {
            string conexion = "Server=DESKTOP-JJJUFEH\\SQLEXPRESS02;Database=Gestor_Tecnico;Integrated Security=true;";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    string query = "SELECT idTipoProducto, Descripcion FROM TiposProducto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cmbEditarTipoProducto.DisplayMember = "Descripcion";
                        cmbEditarTipoProducto.ValueMember = "idTipoProducto";
                        cmbEditarTipoProducto.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditarNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEditarModelo.Text) ||
                string.IsNullOrWhiteSpace(txtEditarPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtEditarStock.Text) ||
                cmbEditarTipoProducto.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtEditarPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número válido y no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEditarStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero y no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtEditarNombre.Text.Trim();
            string modelo = txtEditarModelo.Text.Trim();
            int idTipoProducto = Convert.ToInt32(((DataRowView)cmbEditarTipoProducto.SelectedItem)["idTipoProducto"]);

            string conexion = "Server=DESKTOP-JJJUFEH\\SQLEXPRESS02;Database=Gestor_Tecnico;Integrated Security=true;";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    string query = @"UPDATE Producto
                             SET Nombre = @Nombre,
                                 Modelo = @Modelo,
                                 idTipoProducto = @Tipo,
                                 PrecioVenta = @Precio,
                                 Stock = @Stock
                             WHERE idProducto = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Modelo", modelo);
                        cmd.Parameters.AddWithValue("@Tipo", idTipoProducto);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@Id", _idProducto);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🔽 ESTA ES LA LÍNEA QUE TIENE QUE ESTAR
                    ProductoEditado?.Invoke(this, EventArgs.Empty);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AgregarPlaceholders()
        {
            if (string.IsNullOrWhiteSpace(txtEditarNombre.Text))
            {
                txtEditarNombre.Text = "Ingrese nombre del producto";
                txtEditarNombre.ForeColor = System.Drawing.Color.Gray;
            }
            txtEditarNombre.GotFocus += (s, e) =>
            {
                if (txtEditarNombre.Text == "Ingrese nombre del producto")
                {
                    txtEditarNombre.Text = "";
                    txtEditarNombre.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtEditarNombre.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtEditarNombre.Text))
                {
                    txtEditarNombre.Text = "Ingrese nombre del producto";
                    txtEditarNombre.ForeColor = System.Drawing.Color.Gray;
                }
            };

            if (string.IsNullOrWhiteSpace(txtEditarModelo.Text))
            {
                txtEditarModelo.Text = "Modelo o referencia";
                txtEditarModelo.ForeColor = System.Drawing.Color.Gray;
            }
            txtEditarModelo.GotFocus += (s, e) =>
            {
                if (txtEditarModelo.Text == "Modelo o referencia")
                {
                    txtEditarModelo.Text = "";
                    txtEditarModelo.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtEditarModelo.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtEditarModelo.Text))
                {
                    txtEditarModelo.Text = "Modelo o referencia";
                    txtEditarModelo.ForeColor = System.Drawing.Color.Gray;
                }
            };

            if (string.IsNullOrWhiteSpace(txtEditarPrecio.Text))
            {
                txtEditarPrecio.Text = "0";
            }

            if (string.IsNullOrWhiteSpace(txtEditarStock.Text))
            {
                txtEditarStock.Text = "0";
            }
        }

    }
}
