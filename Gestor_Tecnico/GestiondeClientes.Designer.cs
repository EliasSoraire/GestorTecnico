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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelForm = new Panel();
            lblFormTitle = new Label();
            label4 = new Label();
            txtDNI = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label9 = new Label();
            txtApellido = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtDomicilio = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            btnGuardarCliente = new Button();
            btnLimpiar = new Button();
            panelData = new Panel();
            panelSearch = new Panel();
            lblDataTitle = new Label();
            cmbFiltros = new ComboBox();
            txtBusqueda = new TextBox();
            dgvClientes = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            HISTORIAL = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelData.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 53, 65);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1050, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(18, 47);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(171, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Administración de Clientes";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de Clientes";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(lblFormTitle);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(txtDNI);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(txtNombre);
            panelForm.Controls.Add(label9);
            panelForm.Controls.Add(txtApellido);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(txtTelefono);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(txtDomicilio);
            panelForm.Controls.Add(label7);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(btnGuardarCliente);
            panelForm.Controls.Add(btnLimpiar);
            panelForm.Location = new Point(18, 100);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(332, 520);
            panelForm.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblFormTitle.Location = new Point(18, 20);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(188, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "📝 Datos del Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(52, 73, 94);
            label4.Location = new Point(18, 65);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 24;
            label4.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Font = new Font("Segoe UI", 11.25F);
            txtDNI.ForeColor = Color.Black;
            txtDNI.Location = new Point(18, 90);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(298, 27);
            txtDNI.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(52, 73, 94);
            label3.Location = new Point(18, 130);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 26;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 11.25F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(18, 155);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 27);
            txtNombre.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(52, 73, 94);
            label9.Location = new Point(18, 195);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 26;
            label9.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 11.25F);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(18, 220);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(298, 27);
            txtApellido.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(52, 73, 94);
            label5.Location = new Point(18, 260);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 28;
            label5.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Segoe UI", 11.25F);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(18, 285);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(298, 27);
            txtTelefono.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(52, 73, 94);
            label6.Location = new Point(18, 325);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 30;
            label6.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            txtDomicilio.BorderStyle = BorderStyle.FixedSingle;
            txtDomicilio.Font = new Font("Segoe UI", 11.25F);
            txtDomicilio.ForeColor = Color.Black;
            txtDomicilio.Location = new Point(18, 350);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(298, 27);
            txtDomicilio.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(52, 73, 94);
            label7.Location = new Point(18, 390);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 32;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(18, 415);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 27);
            txtEmail.TabIndex = 33;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.FromArgb(41, 53, 65);
            btnGuardarCliente.FlatAppearance.BorderSize = 0;
            btnGuardarCliente.FlatStyle = FlatStyle.Flat;
            btnGuardarCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnGuardarCliente.ForeColor = Color.White;
            btnGuardarCliente.Location = new Point(18, 465);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(140, 40);
            btnGuardarCliente.TabIndex = 34;
            btnGuardarCliente.Text = "💾 Guardar Cliente";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(189, 195, 199);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(41, 53, 65);
            btnLimpiar.Location = new Point(175, 465);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 40);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "🗑️ Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panelData
            // 
            panelData.BackColor = Color.White;
            panelData.Controls.Add(panelSearch);
            panelData.Controls.Add(dgvClientes);
            panelData.Location = new Point(368, 100);
            panelData.Name = "panelData";
            panelData.Size = new Size(665, 520);
            panelData.TabIndex = 2;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(236, 240, 241);
            panelSearch.Controls.Add(lblDataTitle);
            panelSearch.Controls.Add(cmbFiltros);
            panelSearch.Controls.Add(txtBusqueda);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(665, 80);
            panelSearch.TabIndex = 0;
            // 
            // lblDataTitle
            // 
            lblDataTitle.AutoSize = true;
            lblDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDataTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblDataTitle.Location = new Point(18, 20);
            lblDataTitle.Name = "lblDataTitle";
            lblDataTitle.Size = new Size(176, 25);
            lblDataTitle.TabIndex = 0;
            lblDataTitle.Text = "📋 Lista de Clientes";
            // 
            // cmbFiltros
            // 
            cmbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltros.Font = new Font("Segoe UI", 11.25F);
            cmbFiltros.FormattingEnabled = true;
            cmbFiltros.Location = new Point(358, 45);
            cmbFiltros.Name = "cmbFiltros";
            cmbFiltros.Size = new Size(123, 28);
            cmbFiltros.TabIndex = 39;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Segoe UI", 11.25F);
            txtBusqueda.ForeColor = Color.Black;
            txtBusqueda.Location = new Point(487, 45);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "🔍 Buscar cliente...";
            txtBusqueda.Size = new Size(161, 27);
            txtBusqueda.TabIndex = 37;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { DNI, NOMBRE, APELLIDO, TELEFONO, HISTORIAL });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(189, 195, 199);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(41, 53, 65);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.GridColor = Color.FromArgb(223, 228, 234);
            dgvClientes.Location = new Point(18, 100);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(630, 400);
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
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 3;
            label1.Text = "Gestion de Clientes";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 4;
            label2.Text = "+ Alta de Cliente";
            label2.Visible = false;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 5;
            label8.Text = "Listado de Clientes";
            label8.Visible = false;
            // 
            // GestiondeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1050, 640);
            Controls.Add(panelData);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label8);
            Font = new Font("Segoe UI", 9.75F);
            MinimumSize = new Size(1052, 640);
            Name = "GestiondeClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes - Sistema Técnico";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelData.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Nuevos controles modernos
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelForm;
        private Label lblFormTitle;
        private Panel panelData;
        private Panel panelSearch;
        private Label lblDataTitle;

        // Controles existentes (mantener nombres originales)
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