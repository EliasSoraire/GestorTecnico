using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            this.Load += AgregarProducto_Load;
            btnAgregarProducto.Click += BtnAgregarProducto_Click;
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            CargarTiposProducto();
            AgregarPlaceholders();

            cmbTipoProducto.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void CargarTiposProducto()
        {
            string conexion = "Server=DESKTOP-JJJUFEH\\SQLEXPRESS02;Database=Gestor_Tecnico;Integrated Security=true;";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                cmbTipoProducto.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero y no negativo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número decimal válido y no negativo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            int tipoProductoId = Convert.ToInt32(((DataRowView)cmbTipoProducto.SelectedItem)["idTipoProducto"]);

            string conexion = "Server=DESKTOP-JJJUFEH\\SQLEXPRESS02;Database=Gestor_Tecnico;Integrated Security=true;";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    string query = @"INSERT INTO Producto (Nombre, Modelo, idTipoProducto, PrecioVenta, Stock)
                                     VALUES (@Nombre, @Modelo, @Tipo, @Precio, @Stock)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@Tipo", tipoProductoId);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);

                    conn.Open();
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
            txtModelo.Text = "Modelo o referencia";
            txtPrecio.Text = "0";
            txtStock.Text = "0";
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
            txtStock.Text = "0";
        }
    }
}
