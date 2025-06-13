using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class EditarProducto : Form
    {
        private int _idProducto;

        public EditarProducto()
        {
            InitializeComponent();
        }

        public EditarProducto(int idProducto, string nombre, string modelo, string tipo, decimal precio, int stock)
        {
            InitializeComponent();

            _idProducto = idProducto;

            // Cargar los tipos antes de seleccionar el actual
            CargarTiposProducto();

            txtEditarNombre.Text = nombre;
            txtEditarModelo.Text = modelo;
            txtEditarPrecio.Text = precio.ToString();
            txtEditarStock.Text = stock.ToString();

            // Seleccionar tipo en el ComboBox
            int index = cmbEditarTipoProducto.FindStringExact(tipo);
            if (index != -1)
                cmbEditarTipoProducto.SelectedIndex = index;
        }

        private void CargarTiposProducto()
        {
            string conexion = "Server=DESKTOP-JJJUFEH\\SQLEXPRESS02;Database=Gestor_Tecnico;Integrated Security=true;";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    string query = "SELECT Descripcion FROM TiposProducto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbEditarTipoProducto.Items.Clear();
                            while (reader.Read())
                            {
                                cmbEditarTipoProducto.Items.Add(reader["Descripcion"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
