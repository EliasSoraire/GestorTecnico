using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class GestiondeClientes : Form
    {
        private ConexionSQL conexionSQL;
        private bool modoEdicion = false;
        private string dniOriginal = "";

        public GestiondeClientes()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();

            ConfigurarDataGridView();
            ConfigurarEventos();
            ConfigurarComboBoxFiltros();
            ConfigurarMenuContextual();
            ConfigurarBotonGuardar();
            CargarClientes();
        }

        private void ConfigurarBotonGuardar()
        {
            btnGuardarCliente.BackColor = Color.FromArgb(123, 104, 144);
            btnGuardarCliente.ForeColor = Color.Black;
            btnGuardarCliente.FlatStyle = FlatStyle.Flat;
        }

        private void ConfigurarEventos()
        {
            btnGuardarCliente.Click += BtnGuardarCliente_Click;
            btnLimpiar.Click += BtnLimpiar_Click;

            txtDNI.KeyPress += TxtDNI_KeyPress;
            txtNombre.KeyPress += TxtNombre_KeyPress;
            txtApellido.KeyPress += TxtApellido_KeyPress;
            txtTelefono.KeyPress += TxtTelefono_KeyPress;

            txtDNI.Leave += TxtDNI_Leave;
            txtNombre.Leave += TxtNombre_Leave;
            txtApellido.Leave += TxtApellido_Leave;
            txtTelefono.Leave += TxtTelefono_Leave;
            txtEmail.Leave += TxtEmail_Leave;
            txtDomicilio.Leave += TxtDomicilio_Leave;

            dgvClientes.CellClick += DgvClientes_CellClick;

            txtBusqueda.TextChanged += TxtBusqueda_TextChanged;
            cmbFiltros.SelectedIndexChanged += CmbFiltros_SelectedIndexChanged;
        }

        private void ConfigurarMenuContextual()
        {
            ContextMenuStrip menuContextual = new ContextMenuStrip();

            ToolStripMenuItem editarItem = new ToolStripMenuItem("Editar Cliente");
            editarItem.Click += EditarCliente_Click;

            ToolStripMenuItem eliminarItem = new ToolStripMenuItem("Eliminar Cliente");
            eliminarItem.Click += EliminarCliente_Click;

            menuContextual.Items.Add(editarItem);
            menuContextual.Items.Add(eliminarItem);

            dgvClientes.ContextMenuStrip = menuContextual;
        }

        private void ConfigurarDataGridView()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;

            dgvClientes.DataSource = null;

            foreach (DataGridViewColumn column in dgvClientes.Columns)
            {
                switch (column.Name)
                {
                    case "DNI":
                        column.DataPropertyName = "DNI";
                        column.Visible = true;
                        break;
                    case "NOMBRE":
                        column.DataPropertyName = "Nombre";
                        column.Visible = true;
                        break;
                    case "APELLIDO":
                        column.DataPropertyName = "Apellido";
                        column.Visible = true;
                        break;
                    case "TELEFONO":
                        column.DataPropertyName = "Telefono";
                        column.Visible = true;
                        break;
                    case "HISTORIAL":
                        column.Visible = true;
                        if (column is DataGridViewButtonColumn buttonColumn)
                        {
                            buttonColumn.Text = "Ver Historial";
                            buttonColumn.UseColumnTextForButtonValue = true;
                        }
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void ConfigurarComboBoxFiltros()
        {
            cmbFiltros.Items.Clear();
            cmbFiltros.Items.Add("DNI");
            cmbFiltros.Items.Add("Nombre");
            cmbFiltros.SelectedIndex = 0;

            txtBusqueda.Clear();
        }

        #region Eventos de Menú Contextual
        private void EditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvClientes.SelectedRows[0];
                string dni = row.Cells["DNI"].Value?.ToString();

                if (!string.IsNullOrEmpty(dni))
                {
                    CargarClienteCompleto(dni);
                    ActivarModoEdicion(dni);
                }
            }
        }

        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvClientes.SelectedRows[0];
                string dni = row.Cells["DNI"].Value?.ToString();

                if (!string.IsNullOrEmpty(dni))
                {
                    MostrarConfirmacionEliminar(dni);
                }
            }
        }

        private void ActivarModoEdicion(string dni)
        {
            modoEdicion = true;
            dniOriginal = dni;
            btnGuardarCliente.Text = "Actualizar";
            btnGuardarCliente.BackColor = Color.Orange;

            txtDNI.ReadOnly = false;
            txtDNI.BackColor = SystemColors.Window;
        }

        private void DesactivarModoEdicion()
        {
            modoEdicion = false;
            dniOriginal = "";
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.BackColor = Color.FromArgb(123, 104, 144);

            txtDNI.ReadOnly = false;
            txtDNI.BackColor = SystemColors.Window;
        }

        private void CargarClienteCompleto(string dni)
        {
            try
            {
                using (SqlConnection connection = conexionSQL.ObtenerConexion())
                {
                    if (connection == null) return;

                    string query = "SELECT DNI, Nombre, Apellido, Telefono, Domicilio, Email FROM Cliente WHERE DNI = @DNI";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DNI", dni);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtDNI.Text = reader["DNI"]?.ToString() ?? "";
                                txtNombre.Text = reader["Nombre"]?.ToString() ?? "";
                                txtApellido.Text = reader["Apellido"]?.ToString() ?? "";
                                txtTelefono.Text = reader["Telefono"]?.ToString() ?? "";
                                txtDomicilio.Text = reader["Domicilio"]?.ToString() ?? "";
                                txtEmail.Text = reader["Email"]?.ToString() ?? "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarConfirmacionEliminar(string dni)
        {
            try
            {
                if (ClienteTieneReparaciones(dni))
                {
                    MessageBox.Show("No se puede eliminar este cliente porque tiene reparaciones asociadas.",
                                  "Eliminación no permitida",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = conexionSQL.ObtenerConexion())
                {
                    if (connection == null) return;

                    string query = "SELECT DNI, Nombre, Apellido, Telefono, Email FROM Cliente WHERE DNI = @DNI";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DNI", dni);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string mensaje = $"¿Está seguro que desea eliminar el siguiente cliente?\n\n" +
                                               $"DNI: {reader["DNI"]}\n" +
                                               $"Nombre: {reader["Nombre"]} {reader["Apellido"]}\n" +
                                               $"Teléfono: {reader["Telefono"]}\n" +
                                               $"Email: {reader["Email"]}\n\n" +
                                               $"Esta acción no se puede deshacer.";

                                DialogResult resultado = MessageBox.Show(mensaje,
                                                                        "Confirmar Eliminación",
                                                                        MessageBoxButtons.YesNo,
                                                                        MessageBoxIcon.Question);

                                if (resultado == DialogResult.Yes)
                                {
                                    reader.Close();
                                    EliminarCliente(dni);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar confirmación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ClienteTieneReparaciones(string dni)
        {
            try
            {
                using (SqlConnection connection = conexionSQL.ObtenerConexion())
                {
                    if (connection == null) return false;

                    string query = @"SELECT COUNT(*) FROM Reparaciones r 
                                   INNER JOIN Cliente c ON r.idCliente = c.idCliente 
                                   WHERE c.DNI = @DNI";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DNI", dni);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar reparaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private void EliminarCliente(string dni)
        {
            try
            {
                using (SqlConnection connection = conexionSQL.ObtenerConexion())
                {
                    if (connection == null) return;

                    string query = "DELETE FROM Cliente WHERE DNI = @DNI";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DNI", dni);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cliente eliminado exitosamente.",
                                          "Eliminación Exitosa",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);

                            LimpiarCampos();
                            CargarClientes();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.",
                                          "Error",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos de Búsqueda
        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void CmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            txtBusqueda.Focus();
        }

        private void FiltrarClientes()
        {
            try
            {
                string textoBusqueda = txtBusqueda.Text.Trim();
                string filtroSeleccionado = cmbFiltros.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(filtroSeleccionado))
                {
                    CargarClientes();
                    return;
                }

                using (SqlConnection connection = conexionSQL.ObtenerConexion())
                {
                    if (connection == null) return;

                    string query = "SELECT DNI, Nombre, Apellido, Telefono FROM Cliente";
                    string whereClause = "";

                    if (!string.IsNullOrEmpty(textoBusqueda))
                    {
                        switch (filtroSeleccionado)
                        {
                            case "DNI":
                                whereClause = " WHERE DNI LIKE @Busqueda";
                                break;
                            case "Nombre":
                                whereClause = " WHERE (Nombre LIKE @Busqueda OR Apellido LIKE @Busqueda)";
                                break;
                        }
                    }

                    query += whereClause + " ORDER BY Apellido, Nombre";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(textoBusqueda))
                        {
                            string parametroBusqueda = filtroSeleccionado == "DNI"
                                ? textoBusqueda + "%"
                                : "%" + textoBusqueda + "%";

                            command.Parameters.AddWithValue("@Busqueda", parametroBusqueda);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvClientes.DataSource = null;
                        dgvClientes.DataSource = dataTable;

                        OcultarColumnasAutogeneradas();

                        if (dgvClientes.Rows.Count > 0)
                        {
                            dgvClientes.ClearSelection();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarBusqueda()
        {
            txtBusqueda.Clear();
            cmbFiltros.SelectedIndex = 0;
            CargarClientes();
        }
        #endregion

        #region Validaciones KeyPress
        private void TxtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MostrarError(txtDNI, "El DNI solo puede contener números");
            }
            else
            {
                LimpiarError(txtDNI);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MostrarError(txtNombre, "El nombre solo puede contener letras");
            }
            else
            {
                LimpiarError(txtNombre);
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MostrarError(txtApellido, "El apellido solo puede contener letras");
            }
            else
            {
                LimpiarError(txtApellido);
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
                MostrarError(txtTelefono, "El teléfono solo puede contener números, espacios y guiones");
            }
            else
            {
                LimpiarError(txtTelefono);
            }
        }
        #endregion

        #region Validaciones Leave
        private void TxtDNI_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MostrarError(txtDNI, "El DNI es obligatorio");
                return;
            }

            if (txtDNI.Text.Length < 7 || txtDNI.Text.Length > 8)
            {
                MostrarError(txtDNI, "El DNI debe tener entre 7 y 8 dígitos");
                return;
            }

            LimpiarError(txtDNI);
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MostrarError(txtNombre, "El nombre es obligatorio");
                return;
            }

            if (txtNombre.Text.Trim().Length < 2)
            {
                MostrarError(txtNombre, "El nombre debe tener al menos 2 caracteres");
                return;
            }

            LimpiarError(txtNombre);
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MostrarError(txtApellido, "El apellido es obligatorio");
                return;
            }

            if (txtApellido.Text.Trim().Length < 2)
            {
                MostrarError(txtApellido, "El apellido debe tener al menos 2 caracteres");
                return;
            }

            LimpiarError(txtApellido);
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MostrarError(txtTelefono, "El teléfono es obligatorio");
                return;
            }

            string telefonoLimpio = txtTelefono.Text.Replace(" ", "").Replace("-", "");

            if (telefonoLimpio.Length < 8 || telefonoLimpio.Length > 15)
            {
                MostrarError(txtTelefono, "El teléfono debe tener entre 8 y 15 dígitos");
                return;
            }

            LimpiarError(txtTelefono);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MostrarError(txtEmail, "El email es obligatorio");
                return;
            }

            if (!EsEmailValido(txtEmail.Text))
            {
                MostrarError(txtEmail, "El formato del email no es válido");
                return;
            }

            LimpiarError(txtEmail);
        }

        private void TxtDomicilio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
            {
                MostrarError(txtDomicilio, "El domicilio es obligatorio");
                return;
            }

            if (txtDomicilio.Text.Trim().Length < 5)
            {
                MostrarError(txtDomicilio, "El domicilio debe tener al menos 5 caracteres");
                return;
            }

            LimpiarError(txtDomicilio);
        }
        #endregion

        #region Métodos de Validación
        private bool EsEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void MostrarError(TextBox textBox, string mensaje)
        {
            textBox.BackColor = Color.FromArgb(255, 230, 230);
            textBox.ForeColor = Color.DarkRed;

            ToolTip toolTip = new ToolTip();
            toolTip.Show(mensaje, textBox, 0, textBox.Height, 3000);
        }

        private void LimpiarError(TextBox textBox)
        {
            textBox.BackColor = SystemColors.Window;
            textBox.ForeColor = Color.Black;
        }

        private bool ValidarTodosLosCampos()
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtDNI.Text) || txtDNI.Text.Length < 7 || txtDNI.Text.Length > 8)
            {
                MostrarError(txtDNI, "DNI inválido");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text.Trim().Length < 2)
            {
                MostrarError(txtNombre, "Nombre inválido");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text) || txtApellido.Text.Trim().Length < 2)
            {
                MostrarError(txtApellido, "Apellido inválido");
                esValido = false;
            }

            string telefonoLimpio = txtTelefono.Text.Replace(" ", "").Replace("-", "");
            if (string.IsNullOrWhiteSpace(txtTelefono.Text) || telefonoLimpio.Length < 8 || telefonoLimpio.Length > 15)
            {
                MostrarError(txtTelefono, "Teléfono inválido");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !EsEmailValido(txtEmail.Text))
            {
                MostrarError(txtEmail, "Email inválido");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDomicilio.Text) || txtDomicilio.Text.Trim().Length < 5)
            {
                MostrarError(txtDomicilio, "Domicilio inválido");
                esValido = false;
            }

            return esValido;
        }
        #endregion

        #region Eventos de Botones
        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarTodosLosCampos())
                {
                    MessageBox.Show("Por favor, corrija los errores antes de continuar.",
                                  "Errores de Validación",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                if (modoEdicion)
                {
                    if (txtDNI.Text.Trim() != dniOriginal && ExisteDNI(txtDNI.Text))
                    {
                        MessageBox.Show("Ya existe un cliente con ese DNI.",
                                      "DNI Duplicado",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        return;
                    }

                    if (ActualizarCliente())
                    {
                        MessageBox.Show("Cliente actualizado exitosamente.",
                                      "Éxito",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        LimpiarCampos();
                        DesactivarModoEdicion();
                        CargarClientes();
                    }
                }
                else
                {
                    if (ExisteDNI(txtDNI.Text))
                    {
                        MessageBox.Show("Ya existe un cliente con ese DNI.",
                                      "DNI Duplicado",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        return;
                    }

                    if (GuardarCliente())
                    {
                        MessageBox.Show("Cliente guardado exitosamente.",
                                      "Éxito",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarClientes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar/actualizar el cliente: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarBusqueda();
            DesactivarModoEdicion();
        }
        #endregion

        #region Métodos de Base de Datos
        private bool ExisteDNI(string dni)
        {
            try
            {
                using (SqlConnection connection = conexionSQL.ObtenerConexion())
                {
                    if (connection == null) return false;

                    string query = "SELECT COUNT(*) FROM Cliente WHERE DNI = @DNI";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DNI", dni);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar DNI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool GuardarCliente()
        {
            try
            {
                using (SqlConnection connection = conexionSQL.ObtenerConexion())
                {
                    if (connection == null) return false;

                    string query = @"INSERT INTO Cliente (DNI, Nombre, Apellido, Telefono, Domicilio, Email) 
                                   VALUES (@DNI, @Nombre, @Apellido, @Telefono, @Domicilio, @Email)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DNI", txtDNI.Text.Trim());
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        command.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                        command.Parameters.AddWithValue("@Domicilio", txtDomicilio.Text.Trim());
                        command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ActualizarCliente()
        {
            try
            {
                using (SqlConnection connection = conexionSQL.ObtenerConexion())
                {
                    if (connection == null) return false;

                    string query = @"UPDATE Cliente SET 
                                   DNI = @DNINuevo,
                                   Nombre = @Nombre, 
                                   Apellido = @Apellido, 
                                   Telefono = @Telefono, 
                                   Domicilio = @Domicilio, 
                                   Email = @Email 
                                   WHERE DNI = @DNIOriginal";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DNIOriginal", dniOriginal);
                        command.Parameters.AddWithValue("@DNINuevo", txtDNI.Text.Trim());
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        command.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                        command.Parameters.AddWithValue("@Domicilio", txtDomicilio.Text.Trim());
                        command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection connection = conexionSQL.ObtenerConexion())
                {
                    if (connection == null) return;

                    string query = "SELECT DNI, Nombre, Apellido, Telefono FROM Cliente ORDER BY Apellido, Nombre";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvClientes.DataSource = null;
                        dgvClientes.DataSource = dataTable;

                        OcultarColumnasAutogeneradas();

                        if (dgvClientes.Rows.Count > 0)
                        {
                            dgvClientes.ClearSelection();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcultarColumnasAutogeneradas()
        {
            foreach (DataGridViewColumn column in dgvClientes.Columns)
            {
                if (column.Name != "DNI" && column.Name != "NOMBRE" && column.Name != "APELLIDO" &&
                    column.Name != "TELEFONO" && column.Name != "HISTORIAL")
                {
                    column.Visible = false;
                }
            }
        }
        #endregion

        #region Eventos del DataGridView
        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvClientes.Columns[e.ColumnIndex].Name == "HISTORIAL")
                {
                    DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                    string dni = row.Cells["DNI"].Value?.ToString();

                    if (!string.IsNullOrEmpty(dni))
                    {
                        MessageBox.Show($"Aquí se abriría el historial del cliente con DNI: {dni}",
                                      "Historial",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                }
            }
        }

        #endregion

        #region Métodos Auxiliares
        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDomicilio.Clear();
            txtEmail.Clear();

            LimpiarError(txtDNI);
            LimpiarError(txtNombre);
            LimpiarError(txtApellido);
            LimpiarError(txtTelefono);
            LimpiarError(txtDomicilio);
            LimpiarError(txtEmail);

            txtDNI.Focus();
        }

        #endregion
    }
}