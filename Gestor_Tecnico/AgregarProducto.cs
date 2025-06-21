using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace Gestor_Tecnico
{
    public partial class AgregarProducto : Form
    {
        private ConexionSQL conexionSQL;

        public AgregarProducto()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();
            this.Load += AgregarProducto_Load;
            btnAgregarProducto.Click += BtnAgregarProducto_Click;

            // Agregar validaciones de entrada
            txtPrecio.KeyPress += TxtPrecio_KeyPress;
            txtStock.KeyPress += TxtStock_KeyPress;
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            CargarTiposProducto();
            AgregarPlaceholders();

            cmbTipoProducto.DropDownStyle = ComboBoxStyle.DropDown;
        }

        // Validación para el campo Precio - permite números y un decimal
        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permitir números, backspace, delete
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = false;
            }
            // Permitir punto decimal o coma (según configuración regional)
            else if ((e.KeyChar == '.' || e.KeyChar == ',') && !textBox.Text.Contains(".") && !textBox.Text.Contains(","))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear cualquier otro carácter
            }
        }

        // Validación para el campo Stock - solo números enteros
        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números, backspace y delete
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Bloquear cualquier carácter que no sea número
            }
        }

        private void CargarTiposProducto()
        {
            try
            {
                using (SqlConnection conn = conexionSQL.ObtenerConexion())
                {
                    if (conn == null) return;

                    string query = "SELECT idTipoProducto, Descripcion FROM TiposProducto";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbTipoProducto.DisplayMember = "Descripcion";
                    cmbTipoProducto.ValueMember = "idTipoProducto";
                    cmbTipoProducto.DataSource = dt;
                    cmbTipoProducto.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Validar que no sean placeholders
            if (txtNombre.Text == "Ingrese nombre del producto" || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                txtModelo.Text == "Modelo o referencia" || string.IsNullOrWhiteSpace(txtModelo.Text) ||
                txtStock.Text == "0" || string.IsNullOrWhiteSpace(txtStock.Text) ||
                txtPrecio.Text == "0" || string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(cmbTipoProducto.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero válido y no negativo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número decimal válido y mayor a cero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string tipoTexto = cmbTipoProducto.Text.Trim();

            int tipoProductoId;

            try
            {
                using (SqlConnection conn = conexionSQL.ObtenerConexion())
                {
                    if (conn == null) return;

                    // Buscar si ya existe ese tipo
                    string buscarTipo = "SELECT idTipoProducto FROM TiposProducto WHERE Descripcion = @Descripcion";
                    SqlCommand buscarCmd = new SqlCommand(buscarTipo, conn);
                    buscarCmd.Parameters.AddWithValue("@Descripcion", tipoTexto);

                    object result = buscarCmd.ExecuteScalar();

                    if (result != null)
                    {
                        tipoProductoId = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Insertar nuevo tipo si no existe
                        string insertarTipo = "INSERT INTO TiposProducto (Descripcion) OUTPUT INSERTED.idTipoProducto VALUES (@Descripcion)";
                        SqlCommand insertCmd = new SqlCommand(insertarTipo, conn);
                        insertCmd.Parameters.AddWithValue("@Descripcion", tipoTexto);
                        tipoProductoId = (int)insertCmd.ExecuteScalar();
                    }

                    // Insertar el producto
                    string query = @"INSERT INTO Producto (Nombre, Modelo, idTipoProducto, PrecioVenta, Stock)
                             VALUES (@Nombre, @Modelo, @Tipo, @Precio, @Stock)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@Tipo", tipoProductoId);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "Ingrese nombre del producto";
            txtNombre.ForeColor = System.Drawing.Color.Gray;
            txtModelo.Text = "Modelo o referencia";
            txtModelo.ForeColor = System.Drawing.Color.Gray;
            txtPrecio.Text = "0";
            txtPrecio.ForeColor = System.Drawing.Color.Gray;
            txtStock.Text = "0";
            txtStock.ForeColor = System.Drawing.Color.Gray;
            cmbTipoProducto.SelectedIndex = -1;
        }

        private void AgregarPlaceholders()
        {
            txtNombre.Text = "Ingrese nombre del producto";
            txtNombre.ForeColor = System.Drawing.Color.Gray;
            txtNombre.GotFocus += (s, e) => {
                if (txtNombre.Text == "Ingrese nombre del producto")
                {
                    txtNombre.Text = "";
                    txtNombre.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtNombre.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    txtNombre.Text = "Ingrese nombre del producto";
                    txtNombre.ForeColor = System.Drawing.Color.Gray;
                }
            };

            txtModelo.Text = "Modelo o referencia";
            txtModelo.ForeColor = System.Drawing.Color.Gray;
            txtModelo.GotFocus += (s, e) => {
                if (txtModelo.Text == "Modelo o referencia")
                {
                    txtModelo.Text = "";
                    txtModelo.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtModelo.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtModelo.Text))
                {
                    txtModelo.Text = "Modelo o referencia";
                    txtModelo.ForeColor = System.Drawing.Color.Gray;
                }
            };

            txtPrecio.Text = "0";
            txtPrecio.ForeColor = System.Drawing.Color.Gray;
            txtPrecio.GotFocus += (s, e) => {
                if (txtPrecio.Text == "0")
                {
                    txtPrecio.Text = "";
                    txtPrecio.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtPrecio.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    txtPrecio.Text = "0";
                    txtPrecio.ForeColor = System.Drawing.Color.Gray;
                }
            };

            txtStock.Text = "0";
            txtStock.ForeColor = System.Drawing.Color.Gray;
            txtStock.GotFocus += (s, e) => {
                if (txtStock.Text == "0")
                {
                    txtStock.Text = "";
                    txtStock.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtStock.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtStock.Text))
                {
                    txtStock.Text = "0";
                    txtStock.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }
    }
}