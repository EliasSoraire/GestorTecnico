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
            label1.Size = new Size(831, 50);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(90, 76, 105);
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(158, 460);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(122, 30);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.FromArgb(123, 104, 144);
            btnGuardarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarCliente.Location = new Point(18, 460);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(122, 30);
            btnGuardarCliente.TabIndex = 34;
            btnGuardarCliente.Text = "Guardar Cliente";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(18, 420);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 25);
            txtEmail.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(90, 76, 105);
            label7.Location = new Point(18, 400);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 32;
            label7.Text = "Direccion Email";
            // 
            // txtDomicilio
            // 
            txtDomicilio.ForeColor = Color.Gray;
            txtDomicilio.Location = new Point(18, 360);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(263, 25);
            txtDomicilio.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(90, 76, 105);
            label6.Location = new Point(18, 340);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 30;
            label6.Text = "Domicilio";
            // 
            // txtTelefono
            // 
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.Location = new Point(18, 300);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(263, 25);
            txtTelefono.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(90, 76, 105);
            label5.Location = new Point(18, 280);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 28;
            label5.Text = "Numero de Telefono";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Location = new Point(18, 180);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(263, 25);
            txtNombre.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(90, 76, 105);
            label3.Location = new Point(20, 160);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 26;
            label3.Text = "Nombre";
            // 
            // txtDNI
            // 
            txtDNI.ForeColor = Color.Gray;
            txtDNI.Location = new Point(20, 120);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(263, 25);
            txtDNI.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(90, 76, 105);
            label4.Location = new Point(20, 100);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 24;
            label4.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(123, 104, 144);
            label2.Location = new Point(18, 60);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 23;
            label2.Text = "+ Alta de Cliente";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { DNI, NOMBRE, APELLIDO, TELEFONO, HISTORIAL });
            dgvClientes.Location = new Point(378, 149);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(427, 339);
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
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.ForeColor = Color.Gray;
            txtBusqueda.Location = new Point(673, 106);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(132, 25);
            txtBusqueda.TabIndex = 37;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(123, 104, 144);
            label8.Location = new Point(378, 60);
            label8.Name = "label8";
            label8.Size = new Size(198, 28);
            label8.TabIndex = 36;
            label8.Text = "Listado de Clientes";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbFiltros
            // 
            cmbFiltros.FormattingEnabled = true;
            cmbFiltros.Location = new Point(567, 106);
            cmbFiltros.Name = "cmbFiltros";
            cmbFiltros.Size = new Size(79, 25);
            cmbFiltros.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(90, 76, 105);
            label9.Location = new Point(19, 220);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 26;
            label9.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = Color.Gray;
            txtApellido.Location = new Point(17, 240);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(263, 25);
            txtApellido.TabIndex = 27;
            // 
            // GestiondeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 504);
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
            MinimumSize = new Size(702, 431);
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