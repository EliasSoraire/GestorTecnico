namespace Gestor_Tecnico
{
    partial class Reparaciones
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
            colNombre = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPresupuesto = new DataGridViewTextBoxColumn();
            colMedioPago = new DataGridViewTextBoxColumn();
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
            dtpFechaEntrega = new DateTimePicker();
            label13 = new Label();
            btnVerPagos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReparaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(88, 129, 148);
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(1015, 55);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Reparaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerarPDF.BackColor = Color.FromArgb(136, 108, 108);
            btnGenerarPDF.ForeColor = Color.White;
            btnGenerarPDF.Location = new Point(569, 511);
            btnGenerarPDF.Margin = new Padding(3, 4, 3, 4);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(390, 44);
            btnGenerarPDF.TabIndex = 41;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            // 
            // btnGuardarReparacion
            // 
            btnGuardarReparacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarReparacion.BackColor = Color.FromArgb(88, 129, 148);
            btnGuardarReparacion.ForeColor = Color.White;
            btnGuardarReparacion.Location = new Point(569, 479);
            btnGuardarReparacion.Margin = new Padding(3, 4, 3, 4);
            btnGuardarReparacion.Name = "btnGuardarReparacion";
            btnGuardarReparacion.Size = new Size(390, 40);
            btnGuardarReparacion.TabIndex = 40;
            btnGuardarReparacion.Text = "Guardar Reparacion";
            btnGuardarReparacion.UseVisualStyleBackColor = false;
            btnGuardarReparacion.Click += btnGuardarReparacion_Click;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaIngreso.Location = new Point(569, 381);
            dtpFechaIngreso.Margin = new Padding(3, 4, 3, 4);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(389, 27);
            dtpFechaIngreso.TabIndex = 39;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(67, 90, 111);
            label9.Location = new Point(568, 355);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 38;
            label9.Text = "Fecha de Ingreso";
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPresupuesto.BackColor = Color.White;
            txtPresupuesto.ForeColor = Color.FromArgb(108, 117, 125);
            txtPresupuesto.Location = new Point(568, 228);
            txtPresupuesto.Margin = new Padding(3, 4, 3, 4);
            txtPresupuesto.Multiline = true;
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(390, 41);
            txtPresupuesto.TabIndex = 32;
            txtPresupuesto.Leave += txtPresupuesto_Leave;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(67, 90, 111);
            label7.Location = new Point(64, 284);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 33;
            label7.Text = "Datos del Cliente";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(67, 90, 111);
            label6.Location = new Point(568, 199);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 31;
            label6.Text = "Presupuesto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.ForeColor = Color.FromArgb(108, 117, 125);
            txtDescripcion.Location = new Point(64, 228);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(390, 41);
            txtDescripcion.TabIndex = 30;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(67, 90, 111);
            label5.Location = new Point(64, 199);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 29;
            label5.Text = "Descripcion";
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtModelo.BackColor = Color.White;
            txtModelo.ForeColor = Color.FromArgb(108, 117, 125);
            txtModelo.Location = new Point(568, 143);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Multiline = true;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(390, 41);
            txtModelo.TabIndex = 28;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(67, 90, 111);
            label3.Location = new Point(568, 115);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 27;
            label3.Text = "Modelo";
            // 
            // cbTipoEquipo
            // 
            cbTipoEquipo.BackColor = Color.White;
            cbTipoEquipo.ForeColor = Color.FromArgb(67, 90, 111);
            cbTipoEquipo.FormattingEnabled = true;
            cbTipoEquipo.Location = new Point(65, 143);
            cbTipoEquipo.Margin = new Padding(3, 4, 3, 4);
            cbTipoEquipo.Name = "cbTipoEquipo";
            cbTipoEquipo.Size = new Size(390, 28);
            cbTipoEquipo.TabIndex = 26;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(67, 90, 111);
            label4.Location = new Point(64, 115);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 25;
            label4.Text = "Tipo de Equipo";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(67, 90, 111);
            label2.Location = new Point(34, 65);
            label2.Name = "label2";
            label2.Size = new Size(393, 45);
            label2.TabIndex = 24;
            label2.Text = "+ Ingreso de Reparacion";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvReparaciones
            // 
            dgvReparaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReparaciones.BackgroundColor = Color.White;
            dgvReparaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReparaciones.Columns.AddRange(new DataGridViewColumn[] { colNombre, colTipo, colModelo, colDescripcion, colPresupuesto, colMedioPago, colFechaIngreso, colFechaEntrega, colAcciones });
            dgvReparaciones.Location = new Point(-1, 596);
            dgvReparaciones.Margin = new Padding(3, 4, 3, 4);
            dgvReparaciones.Name = "dgvReparaciones";
            dgvReparaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReparaciones.RowHeadersVisible = false;
            dgvReparaciones.RowHeadersWidth = 51;
            dgvReparaciones.Size = new Size(1015, 199);
            dgvReparaciones.TabIndex = 47;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            // 
            // colTipo
            // 
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipo.DataPropertyName = "Tipo";
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            // 
            // colModelo
            // 
            colModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colModelo.DataPropertyName = "Modelo";
            colModelo.HeaderText = "Modelo";
            colModelo.MinimumWidth = 6;
            colModelo.Name = "colModelo";
            // 
            // colDescripcion
            // 
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDescripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            colDescripcion.DefaultCellStyle = dataGridViewCellStyle1;
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.Width = 116;
            // 
            // colPresupuesto
            // 
            colPresupuesto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPresupuesto.DataPropertyName = "Presupuesto";
            colPresupuesto.HeaderText = "Presupuesto";
            colPresupuesto.MinimumWidth = 6;
            colPresupuesto.Name = "colPresupuesto";
            // 
            // colMedioPago
            // 
            colMedioPago.DataPropertyName = "MedioPago";
            colMedioPago.HeaderText = "Medio de Pago";
            colMedioPago.MinimumWidth = 6;
            colMedioPago.Name = "colMedioPago";
            colMedioPago.Width = 125;
            // 
            // colFechaIngreso
            // 
            colFechaIngreso.DataPropertyName = "FechaIngreso";
            colFechaIngreso.HeaderText = "Fecha Ingreso";
            colFechaIngreso.MinimumWidth = 6;
            colFechaIngreso.Name = "colFechaIngreso";
            colFechaIngreso.Width = 125;
            // 
            // colFechaEntrega
            // 
            colFechaEntrega.DataPropertyName = "FechaEntrega";
            colFechaEntrega.HeaderText = "Fecha Entrega";
            colFechaEntrega.MinimumWidth = 6;
            colFechaEntrega.Name = "colFechaEntrega";
            colFechaEntrega.Width = 125;
            // 
            // colAcciones
            // 
            colAcciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.Resizable = DataGridViewTriState.True;
            colAcciones.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarCliente.BackColor = Color.White;
            txtBuscarCliente.ForeColor = Color.FromArgb(108, 117, 125);
            txtBuscarCliente.Location = new Point(486, 559);
            txtBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            txtBuscarCliente.Multiline = true;
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(191, 28);
            txtBuscarCliente.TabIndex = 43;
            txtBuscarCliente.Text = "Buscar Cliente";
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // cbEstado
            // 
            cbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbEstado.BackColor = Color.White;
            cbEstado.ForeColor = Color.FromArgb(67, 90, 111);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(333, 559);
            cbEstado.Margin = new Padding(3, 4, 3, 4);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(126, 28);
            cbEstado.TabIndex = 46;
            cbEstado.Tag = "";
            cbEstado.Text = "Estado";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(67, 90, 111);
            label11.Location = new Point(265, 564);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 44;
            label11.Text = "Filtros:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F);
            label12.ForeColor = Color.FromArgb(67, 90, 111);
            label12.Location = new Point(34, 559);
            label12.Name = "label12";
            label12.Size = new Size(227, 25);
            label12.TabIndex = 48;
            label12.Text = "Listado de Reparaciones";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(67, 90, 111);
            label10.Location = new Point(569, 284);
            label10.Name = "label10";
            label10.Size = new Size(141, 25);
            label10.TabIndex = 50;
            label10.Text = "Medio de Pago";
            // 
            // cbMedioPago
            // 
            cbMedioPago.BackColor = Color.White;
            cbMedioPago.ForeColor = Color.FromArgb(67, 90, 111);
            cbMedioPago.FormattingEnabled = true;
            cbMedioPago.Location = new Point(569, 313);
            cbMedioPago.Margin = new Padding(3, 4, 3, 4);
            cbMedioPago.Name = "cbMedioPago";
            cbMedioPago.Size = new Size(380, 28);
            cbMedioPago.TabIndex = 51;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(67, 90, 111);
            label8.Location = new Point(64, 381);
            label8.Name = "label8";
            label8.Size = new Size(141, 25);
            label8.TabIndex = 52;
            label8.Text = "Subir Imagen";
            // 
            // btnImagen
            // 
            btnImagen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnImagen.BackColor = Color.FromArgb(88, 129, 148);
            btnImagen.ForeColor = Color.White;
            btnImagen.Location = new Point(64, 411);
            btnImagen.Margin = new Padding(3, 4, 3, 4);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(151, 44);
            btnImagen.TabIndex = 53;
            btnImagen.Text = "Imagen";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // cbDniCliente
            // 
            cbDniCliente.BackColor = Color.White;
            cbDniCliente.ForeColor = Color.FromArgb(67, 90, 111);
            cbDniCliente.FormattingEnabled = true;
            cbDniCliente.Location = new Point(64, 328);
            cbDniCliente.Margin = new Padding(3, 4, 3, 4);
            cbDniCliente.Name = "cbDniCliente";
            cbDniCliente.Size = new Size(390, 28);
            cbDniCliente.TabIndex = 54;
            cbDniCliente.Text = "Documento";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaEntrega.Location = new Point(569, 445);
            dtpFechaEntrega.Margin = new Padding(3, 4, 3, 4);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(389, 27);
            dtpFechaEntrega.TabIndex = 56;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(67, 90, 111);
            label13.Location = new Point(568, 419);
            label13.Name = "label13";
            label13.Size = new Size(141, 25);
            label13.TabIndex = 55;
            label13.Text = "Fecha de Entrega";
            // 
            // btnVerPagos
            // 
            btnVerPagos.Location = new Point(64, 462);
            btnVerPagos.Name = "btnVerPagos";
            btnVerPagos.Size = new Size(150, 44);
            btnVerPagos.TabIndex = 57;
            btnVerPagos.Text = "Ver Pagos";
            btnVerPagos.UseVisualStyleBackColor = true;
            btnVerPagos.Click += btnVerPagos_Click;
            // 
            // Reparaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 248);
            ClientSize = new Size(1009, 799);
            Controls.Add(btnVerPagos);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(label13);
            Controls.Add(cbDniCliente);
            Controls.Add(btnImagen);
            Controls.Add(label8);
            Controls.Add(cbMedioPago);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(dgvReparaciones);
            Controls.Add(txtBuscarCliente);
            Controls.Add(cbEstado);
            Controls.Add(label11);
            Controls.Add(btnGenerarPDF);
            Controls.Add(btnGuardarReparacion);
            Controls.Add(label1);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(cbTipoEquipo);
            Controls.Add(label3);
            Controls.Add(txtModelo);
            Controls.Add(label5);
            Controls.Add(txtPresupuesto);
            Controls.Add(txtDescripcion);
            Controls.Add(label7);
            Controls.Add(label6);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 696);
            Name = "Reparaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reparaciones";
            ((System.ComponentModel.ISupportInitialize)dgvReparaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DateTimePicker dtpFechaEntrega;
        private Label label13;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPresupuesto;
        private DataGridViewTextBoxColumn colMedioPago;
        private DataGridViewTextBoxColumn colFechaIngreso;
        private DataGridViewTextBoxColumn colFechaEntrega;
        private DataGridViewButtonColumn colAcciones;
        private Button btnVerPagos;
    }
}