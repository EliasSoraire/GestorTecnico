namespace Gestor_Tecnico
{
    partial class GestiondeClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnLimpiar = new Button();
            btnGuardarCliente = new Button();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDomicilio = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtDNI = new TextBox();
            label4 = new Label();
            label2 = new Label();
            dgvClientes = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            HISTORIAL = new DataGridViewTextBoxColumn();
            txtBusqueda = new TextBox();
            label8 = new Label();
            cmbFiltros = new ComboBox();
            label9 = new Label();
            txtApellido = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(123, 104, 144);
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(950, 50);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(90, 76, 105);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(181, 490);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(139, 30);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.FromArgb(123, 104, 144);
            btnGuardarCliente.FlatStyle = FlatStyle.Popup;
            btnGuardarCliente.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarCliente.Location = new Point(21, 490);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(139, 30);
            btnGuardarCliente.TabIndex = 34;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(23, 450);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(90, 76, 105);
            label7.Location = new Point(21, 425);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 32;
            label7.Text = "Direccion Email";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtDomicilio.ForeColor = Color.Black;
            txtDomicilio.Location = new Point(23, 385);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(300, 27);
            txtDomicilio.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(90, 76, 105);
            label6.Location = new Point(21, 360);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 30;
            label6.Text = "Domicilio";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(23, 320);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(300, 27);
            txtTelefono.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(90, 76, 105);
            label5.Location = new Point(21, 295);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 28;
            label5.Text = "Numero de Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(23, 190);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 27);
            txtNombre.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(90, 76, 105);
            label3.Location = new Point(23, 165);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 26;
            label3.Text = "Nombre";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtDNI.ForeColor = Color.Black;
            txtDNI.Location = new Point(25, 125);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(300, 27);
            txtDNI.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(90, 76, 105);
            label4.Location = new Point(23, 100);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 24;
            label4.Text = "DNI";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(123, 104, 144);
            label2.Location = new Point(21, 60);
            label2.Name = "label2";
            label2.Size = new Size(378, 32);
            label2.TabIndex = 23;
            label2.Text = "+ Alta de Cliente";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { DNI, NOMBRE, APELLIDO, TELEFONO, HISTORIAL });
            dgvClientes.Location = new Point(432, 149);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(488, 376);
            dgvClientes.TabIndex = 38;
            // 
            // DNI
            // 
            DNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            // 
            // NOMBRE
            // 
            NOMBRE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            APELLIDO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.Name = "APELLIDO";
            // 
            // TELEFONO
            // 
            TELEFONO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TELEFONO.HeaderText = "TELEFONO";
            TELEFONO.Name = "TELEFONO";
            // 
            // HISTORIAL
            // 
            HISTORIAL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HISTORIAL.HeaderText = "HISTORIAL";
            HISTORIAL.Name = "HISTORIAL";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBusqueda.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusqueda.ForeColor = Color.Black;
            txtBusqueda.Location = new Point(729, 106);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(190, 30);
            txtBusqueda.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(123, 104, 144);
            label8.Location = new Point(432, 60);
            label8.Name = "label8";
            label8.Size = new Size(233, 32);
            label8.TabIndex = 36;
            label8.Text = "Listado de Clientes";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbFiltros
            // 
            cmbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltros.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFiltros.FormattingEnabled = true;
            cmbFiltros.Location = new Point(594, 108);
            cmbFiltros.Name = "cmbFiltros";
            cmbFiltros.Size = new Size(110, 28);
            cmbFiltros.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(90, 76, 105);
            label9.Location = new Point(22, 230);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 26;
            label9.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(21, 255);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 27);
            txtApellido.TabIndex = 27;
            // 
            // GestiondeClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 541);
            Controls.Add(cmbFiltros);
            Controls.Add(dgvClientes);
            Controls.Add(txtBusqueda);
            Controls.Add(label8);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardarCliente);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtDomicilio);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(txtDNI);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            MinimumSize = new Size(800, 431);
            Name = "GestiondeClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Clientes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLimpiar;
        private Button btnGuardarCliente;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtDomicilio;
        private Label label6;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtDNI;
        private Label label4;
        private Label label2;
        private DataGridView dgvClientes;
        private TextBox txtBusqueda;
        private Label label8;
        private ComboBox cmbFiltros;
        private Label label9;
        private TextBox txtApellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn HISTORIAL;
    }
}