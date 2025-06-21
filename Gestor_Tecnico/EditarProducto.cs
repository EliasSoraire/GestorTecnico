using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class EditarProducto : Form
    {
        private int _idProducto;
        private ConexionSQL conexionSQL;
        public event EventHandler ProductoEditado;

        public EditarProducto()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();

            // Agregar validaciones de entrada
            txtEditarPrecio.KeyPress += TxtPrecio_KeyPress;
            txtEditarStock.KeyPress += TxtStock_KeyPress;
        }

        public EditarProducto(int idProducto, string nombre, string modelo, string tipo, decimal precio, int stock)
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();

            // Agregar validaciones de entrada
            txtEditarPrecio.KeyPress += TxtPrecio_KeyPress;
            txtEditarStock.KeyPress += TxtStock_KeyPress;

            _idProducto = idProducto;
            CargarTiposProducto();

            // Llenar los campos con los datos recibidos
            txtEditarNombre.Text = nombre;
            txtEditarNombre.ForeColor = System.Drawing.Color.Black;

            txtEditarModelo.Text = modelo;
            txtEditarModelo.ForeColor = System.Drawing.Color.Black;

            txtEditarPrecio.Text = precio.ToString("F2");
            txtEditarPrecio.ForeColor = System.Drawing.Color.Black;

            txtEditarStock.Text = stock.ToString();
            txtEditarStock.ForeColor = System.Drawing.Color.Black;

            int index = cmbEditarTipoProducto.FindStringExact(tipo);
            if (index != -1)
                cmbEditarTipoProducto.SelectedIndex = index;

            cmbEditarTipoProducto.DropDownStyle = ComboBoxStyle.DropDown;

            // Evento del botón
            btnGuardarProducto.Click += btnGuardarProducto_Click;

            // Activar placeholders
            AgregarPlaceholders();
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
            // Validar que no sean placeholders y que no estén vacíos
            if (txtEditarNombre.Text == "Ingrese nombre del producto" || string.IsNullOrWhiteSpace(txtEditarNombre.Text) ||
                txtEditarModelo.Text == "Modelo o referencia" || string.IsNullOrWhiteSpace(txtEditarModelo.Text) ||
                string.IsNullOrWhiteSpace(txtEditarPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtEditarStock.Text) ||
                string.IsNullOrWhiteSpace(cmbEditarTipoProducto.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtEditarPrecio.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número decimal válido y mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditarPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtEditarStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero válido y no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditarStock.Focus();
                return;
            }

            string nombre = txtEditarNombre.Text.Trim();
            string modelo = txtEditarModelo.Text.Trim();
            string tipoTexto = cmbEditarTipoProducto.Text.Trim();
            int idTipoProducto;

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
                        idTipoProducto = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Insertar nuevo tipo si no existe
                        string insertarTipo = "INSERT INTO TiposProducto (Descripcion) OUTPUT INSERTED.idTipoProducto VALUES (@Descripcion)";
                        SqlCommand insertCmd = new SqlCommand(insertarTipo, conn);
                        insertCmd.Parameters.AddWithValue("@Descripcion", tipoTexto);
                        idTipoProducto = (int)insertCmd.ExecuteScalar();
                    }

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
            // Solo agregar placeholders si los campos están vacíos (para nuevos productos)
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
        }
    }
}   