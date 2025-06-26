namespace Gestor_Tecnico
{
    partial class Reparaciones
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            btnGenerarPDF = new Button();
            btnGuardarReparacion = new Button();
            dtpFechaIngreso = new DateTimePicker();
            label9 = new Label();
            txtPresupuesto = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtModelo = new TextBox();
            label3 = new Label();
            cbTipoEquipo = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            dgvReparaciones = new DataGridView();
            colIdReparacion = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colFechaIngreso = new DataGridViewTextBoxColumn();
            colFechaEntrega = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            txtBuscarCliente = new TextBox();
            cbEstado = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            cbMedioPago = new ComboBox();
            label8 = new Label();
            btnImagen = new Button();
            cbDniCliente = new ComboBox();
            panelHeader = new Panel();
            panelForm = new Panel();
            panelGrid = new Panel();
            panelFilters = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvReparaciones).BeginInit();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelGrid.SuspendLayout();
            panelFilters.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1184, 65);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Reparaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerarPDF.BackColor = Color.FromArgb(233, 69, 96);
            btnGenerarPDF.FlatAppearance.BorderSize = 0;
            btnGenerarPDF.FlatStyle = FlatStyle.Flat;
            btnGenerarPDF.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGenerarPDF.ForeColor = Color.White;
            btnGenerarPDF.Location = new Point(409, 256);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(320, 40);
            btnGenerarPDF.TabIndex = 41;
            btnGenerarPDF.Text = "📄 Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            // 
            // btnGuardarReparacion
            // 
            btnGuardarReparacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarReparacion.BackColor = Color.FromArgb(46, 125, 50);
            btnGuardarReparacion.FlatAppearance.BorderSize = 0;
            btnGuardarReparacion.FlatStyle = FlatStyle.Flat;
            btnGuardarReparacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardarReparacion.ForeColor = Color.White;
            btnGuardarReparacion.Location = new Point(760, 256);
            btnGuardarReparacion.Name = "btnGuardarReparacion";
            btnGuardarReparacion.Size = new Size(320, 40);
            btnGuardarReparacion.TabIndex = 40;
            btnGuardarReparacion.Text = "💾 Guardar Reparación";
            btnGuardarReparacion.UseVisualStyleBackColor = false;
            btnGuardarReparacion.Click += btnGuardarReparacion_Click;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpFechaIngreso.Font = new Font("Segoe UI", 10F);
            dtpFechaIngreso.Location = new Point(748, 70);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(320, 25);
            dtpFechaIngreso.TabIndex = 39;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(99, 110, 125);
            label9.Location = new Point(748, 50);
            label9.Name = "label9";
            label9.Size = new Size(150, 15);
            label9.TabIndex = 38;
            label9.Text = "Fecha de Ingreso";
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.BackColor = Color.White;
            txtPresupuesto.BorderStyle = BorderStyle.FixedSingle;
            txtPresupuesto.Font = new Font("Segoe UI", 10F);
            txtPresupuesto.ForeColor = Color.FromArgb(47, 54, 64);
            txtPresupuesto.Location = new Point(370, 120);
            txtPresupuesto.Multiline = true;
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(320, 35);
            txtPresupuesto.TabIndex = 32;
            txtPresupuesto.Leave += txtPresupuesto_Leave;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(99, 110, 125);
            label7.Location = new Point(25, 165);
            label7.Name = "label7";
            label7.Size = new Size(150, 15);
            label7.TabIndex = 33;
            label7.Text = "Cliente";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(99, 110, 125);
            label6.Location = new Point(370, 100);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 31;
            label6.Text = "Presupuesto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.FromArgb(47, 54, 64);
            txtDescripcion.Location = new Point(25, 120);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(320, 35);
            txtDescripcion.TabIndex = 30;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(99, 110, 125);
            label5.Location = new Point(25, 100);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 29;
            label5.Text = "Descripción del Problema";
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.White;
            txtModelo.BorderStyle = BorderStyle.FixedSingle;
            txtModelo.Font = new Font("Segoe UI", 10F);
            txtModelo.ForeColor = Color.FromArgb(47, 54, 64);
            txtModelo.Location = new Point(370, 70);
            txtModelo.Multiline = true;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(320, 25);
            txtModelo.TabIndex = 28;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(99, 110, 125);
            label3.Location = new Point(370, 50);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 27;
            label3.Text = "Modelo";
            // 
            // cbTipoEquipo
            // 
            cbTipoEquipo.BackColor = Color.White;
            cbTipoEquipo.FlatStyle = FlatStyle.Flat;
            cbTipoEquipo.Font = new Font("Segoe UI", 10F);
            cbTipoEquipo.ForeColor = Color.FromArgb(47, 54, 64);
            cbTipoEquipo.FormattingEnabled = true;
            cbTipoEquipo.Location = new Point(25, 70);
            cbTipoEquipo.Name = "cbTipoEquipo";
            cbTipoEquipo.Size = new Size(320, 25);
            cbTipoEquipo.TabIndex = 26;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(99, 110, 125);
            label4.Location = new Point(25, 50);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 25;
            label4.Text = "Tipo de Equipo";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(47, 54, 64);
            label2.Location = new Point(25, 10);
            label2.Name = "label2";
            label2.Size = new Size(300, 30);
            label2.TabIndex = 24;
            label2.Text = "Nueva Reparación";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvReparaciones
            // 
            dgvReparaciones.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvReparaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReparaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReparaciones.BackgroundColor = Color.White;
            dgvReparaciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReparaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReparaciones.Columns.AddRange(new DataGridViewColumn[] { colIdReparacion, colEstado, colNombre, colTipo, colModelo, colFechaIngreso, colFechaEntrega, colAcciones });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 239, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReparaciones.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReparaciones.EnableHeadersVisualStyles = false;
            dgvReparaciones.GridColor = Color.FromArgb(225, 232, 240);
            dgvReparaciones.Location = new Point(25, 95);
            dgvReparaciones.Name = "dgvReparaciones";
            dgvReparaciones.RowHeadersVisible = false;
            dgvReparaciones.RowHeadersWidth = 51;
            dgvReparaciones.RowTemplate.Height = 35;
            dgvReparaciones.Size = new Size(1134, 214);
            dgvReparaciones.TabIndex = 47;
            // 
            // colIdReparacion
            // 
            colIdReparacion.DataPropertyName = "idReparacion";
            colIdReparacion.HeaderText = "ID";
            colIdReparacion.Name = "colIdReparacion";
            colIdReparacion.Visible = false;
            colIdReparacion.Width = 50;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.Width = 120;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Cliente";
            colNombre.MinimumWidth = 150;
            colNombre.Name = "colNombre";
            // 
            // colTipo
            // 
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipo.DataPropertyName = "Tipo";
            colTipo.HeaderText = "Tipo de Equipo";
            colTipo.MinimumWidth = 120;
            colTipo.Name = "colTipo";
            // 
            // colModelo
            // 
            colModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colModelo.DataPropertyName = "Modelo";
            colModelo.HeaderText = "Modelo";
            colModelo.MinimumWidth = 100;
            colModelo.Name = "colModelo";
            // 
            // colFechaIngreso
            // 
            colFechaIngreso.DataPropertyName = "FechaIngreso";
            colFechaIngreso.HeaderText = "Fecha de Ingreso";
            colFechaIngreso.Name = "colFechaIngreso";
            colFechaIngreso.Width = 140;
            // 
            // colFechaEntrega
            // 
            colFechaEntrega.DataPropertyName = "FechaEntrega";
            colFechaEntrega.HeaderText = "Fecha de Entrega";
            colFechaEntrega.Name = "colFechaEntrega";
            colFechaEntrega.Visible = false;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 100;
            colAcciones.Name = "colAcciones";
            colAcciones.Resizable = DataGridViewTriState.True;
            colAcciones.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarCliente.BackColor = Color.White;
            txtBuscarCliente.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarCliente.Font = new Font("Segoe UI", 10F);
            txtBuscarCliente.ForeColor = Color.FromArgb(47, 54, 64);
            txtBuscarCliente.Location = new Point(735, 10);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.PlaceholderText = "🔍 Buscar cliente...";
            txtBuscarCliente.Size = new Size(200, 25);
            txtBuscarCliente.TabIndex = 43;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // cbEstado
            // 
            cbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbEstado.BackColor = Color.White;
            cbEstado.FlatStyle = FlatStyle.Flat;
            cbEstado.Font = new Font("Segoe UI", 10F);
            cbEstado.ForeColor = Color.FromArgb(47, 54, 64);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(565, 10);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(150, 25);
            cbEstado.TabIndex = 46;
            cbEstado.Text = "Estado";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(99, 110, 125);
            label11.Location = new Point(495, 12);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 44;
            label11.Text = "Filtros:";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(47, 54, 64);
            label12.Location = new Point(25, 15);
            label12.Name = "label12";
            label12.Size = new Size(300, 30);
            label12.TabIndex = 48;
            label12.Text = "Lista de Reparaciones";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(99, 110, 125);
            label10.Location = new Point(370, 165);
            label10.Name = "label10";
            label10.Size = new Size(150, 15);
            label10.TabIndex = 50;
            label10.Text = "Medio de Pago";
            // 
            // cbMedioPago
            // 
            cbMedioPago.BackColor = Color.White;
            cbMedioPago.FlatStyle = FlatStyle.Flat;
            cbMedioPago.Font = new Font("Segoe UI", 10F);
            cbMedioPago.ForeColor = Color.FromArgb(47, 54, 64);
            cbMedioPago.FormattingEnabled = true;
            cbMedioPago.Location = new Point(370, 185);
            cbMedioPago.Name = "cbMedioPago";
            cbMedioPago.Size = new Size(320, 25);
            cbMedioPago.TabIndex = 51;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(99, 110, 125);
            label8.Location = new Point(25, 241);
            label8.Name = "label8";
            label8.Size = new Size(150, 15);
            label8.TabIndex = 52;
            label8.Text = "Imagen del Equipo";
            // 
            // btnImagen
            // 
            btnImagen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnImagen.BackColor = Color.FromArgb(116, 125, 140);
            btnImagen.FlatAppearance.BorderSize = 0;
            btnImagen.FlatStyle = FlatStyle.Flat;
            btnImagen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnImagen.ForeColor = Color.White;
            btnImagen.Location = new Point(25, 261);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(360, 35);
            btnImagen.TabIndex = 53;
            btnImagen.Text = "📷 Seleccionar Imagen";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // cbDniCliente
            // 
            cbDniCliente.BackColor = Color.White;
            cbDniCliente.FlatStyle = FlatStyle.Flat;
            cbDniCliente.Font = new Font("Segoe UI", 10F);
            cbDniCliente.ForeColor = Color.FromArgb(47, 54, 64);
            cbDniCliente.FormattingEnabled = true;
            cbDniCliente.Location = new Point(25, 185);
            cbDniCliente.Name = "cbDniCliente";
            cbDniCliente.Size = new Size(320, 25);
            cbDniCliente.TabIndex = 54;
            cbDniCliente.Text = "Seleccionar Cliente";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(47, 54, 64);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 65);
            panelHeader.TabIndex = 100;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(250, 251, 252);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(cbTipoEquipo);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(txtDescripcion);
            panelForm.Controls.Add(label7);
            panelForm.Controls.Add(cbDniCliente);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(txtModelo);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(txtPresupuesto);
            panelForm.Controls.Add(label10);
            panelForm.Controls.Add(cbMedioPago);
            panelForm.Controls.Add(label9);
            panelForm.Controls.Add(dtpFechaIngreso);
            panelForm.Controls.Add(label8);
            panelForm.Controls.Add(btnImagen);
            panelForm.Controls.Add(btnGuardarReparacion);
            panelForm.Controls.Add(btnGenerarPDF);
            panelForm.Dock = DockStyle.Top;
            panelForm.Location = new Point(0, 65);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(25, 20, 25, 20);
            panelForm.Size = new Size(1184, 350);
            panelForm.TabIndex = 101;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(label12);
            panelGrid.Controls.Add(panelFilters);
            panelGrid.Controls.Add(dgvReparaciones);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 415);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(25, 15, 25, 25);
            panelGrid.Size = new Size(1184, 334);
            panelGrid.TabIndex = 102;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(label11);
            panelFilters.Controls.Add(cbEstado);
            panelFilters.Controls.Add(txtBuscarCliente);
            panelFilters.Dock = DockStyle.Top;
            panelFilters.Location = new Point(25, 15);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(1134, 40);
            panelFilters.TabIndex = 103;
            // 
            // Reparaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 251, 252);
            ClientSize = new Size(1184, 749);
            Controls.Add(panelGrid);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1200, 700);
            Name = "Reparaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Reparaciones - Sistema Técnico";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvReparaciones).EndInit();
            panelHeader.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelGrid.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnGenerarPDF;
        private Button btnGuardarReparacion;
        private DateTimePicker dtpFechaIngreso;
        private Label label9;
        private TextBox txtPresupuesto;
        private Label label7;
        private Label label6;
        private TextBox txtDescripcion;
        private Label label5;
        private TextBox txtModelo;
        private Label label3;
        private ComboBox cbTipoEquipo;
        private Label label4;
        private Label label2;
        private DataGridView dgvReparaciones;
        private TextBox txtBuscarCliente;
        private ComboBox cbEstado;
        private Label label11;
        private Label label12;
        private Label label10;
        private ComboBox cbMedioPago;
        private Label label8;
        private Button btnImagen;
        private ComboBox cbDniCliente;
        private Panel panelHeader;
        private Panel panelForm;
        private Panel panelGrid;
        private Panel panelFilters;
        private DataGridViewTextBoxColumn colIdReparacion;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colFechaIngreso;
        private DataGridViewTextBoxColumn colFechaEntrega;
        private DataGridViewButtonColumn colAcciones;
    }
}