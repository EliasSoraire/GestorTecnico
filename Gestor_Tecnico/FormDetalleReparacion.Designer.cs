namespace Gestor_Tecnico
{
    partial class FormDetalleReparacion
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
            lblTitulo = new Label();
            lblClienteTexto = new Label();
            lblClienteValor = new Label();
            lblDniTexto = new Label();
            lblDniValor = new Label();
            lblFechaTexto = new Label();
            lblFechaValor = new Label();
            gbDatosGenerales = new GroupBox();
            lblMedioPagoDet = new Label();
            lblMedioPago = new Label();
            txtPresupuestoDet = new TextBox();
            lblPresupuesto = new Label();
            txtDescripcionDet = new TextBox();
            lblDescripcion = new Label();
            txtModeloDet = new TextBox();
            lblModelo = new Label();
            gbEstado = new GroupBox();
            lblValidacionEstado = new Label();
            cbNuevoEstado = new ComboBox();
            lblEstadoTexto = new Label();
            gbFoto = new GroupBox();
            pbFotoEquipo3 = new PictureBox();
            pbFotoEquipo2 = new PictureBox();
            pbFotoEquipo1 = new PictureBox();
            btnGuardarDet = new Button();
            btnCancelarDet = new Button();
            gbDatosGenerales.SuspendLayout();
            gbEstado.SuspendLayout();
            gbFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoEquipo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoEquipo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoEquipo1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle Reparación:";
            // 
            // lblClienteTexto
            // 
            lblClienteTexto.AutoSize = true;
            lblClienteTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblClienteTexto.Location = new Point(20, 55);
            lblClienteTexto.Name = "lblClienteTexto";
            lblClienteTexto.Size = new Size(49, 15);
            lblClienteTexto.TabIndex = 1;
            lblClienteTexto.Text = "Cliente:";
            // 
            // lblClienteValor
            // 
            lblClienteValor.BackColor = Color.White;
            lblClienteValor.BorderStyle = BorderStyle.FixedSingle;
            lblClienteValor.Location = new Point(85, 52);
            lblClienteValor.Name = "lblClienteValor";
            lblClienteValor.Padding = new Padding(5, 2, 0, 0);
            lblClienteValor.Size = new Size(200, 22);
            lblClienteValor.TabIndex = 2;
            lblClienteValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDniTexto
            // 
            lblDniTexto.AutoSize = true;
            lblDniTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDniTexto.Location = new Point(400, 55);
            lblDniTexto.Name = "lblDniTexto";
            lblDniTexto.Size = new Size(32, 15);
            lblDniTexto.TabIndex = 3;
            lblDniTexto.Text = "DNI:";
            // 
            // lblDniValor
            // 
            lblDniValor.BackColor = Color.White;
            lblDniValor.BorderStyle = BorderStyle.FixedSingle;
            lblDniValor.Location = new Point(445, 52);
            lblDniValor.Name = "lblDniValor";
            lblDniValor.Padding = new Padding(5, 2, 0, 0);
            lblDniValor.Size = new Size(120, 22);
            lblDniValor.TabIndex = 4;
            lblDniValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFechaTexto
            // 
            lblFechaTexto.AutoSize = true;
            lblFechaTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaTexto.Location = new Point(20, 85);
            lblFechaTexto.Name = "lblFechaTexto";
            lblFechaTexto.Size = new Size(87, 15);
            lblFechaTexto.TabIndex = 5;
            lblFechaTexto.Text = "Fecha Ingreso:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.BackColor = Color.White;
            lblFechaValor.BorderStyle = BorderStyle.FixedSingle;
            lblFechaValor.Location = new Point(125, 82);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Padding = new Padding(5, 2, 0, 0);
            lblFechaValor.Size = new Size(120, 22);
            lblFechaValor.TabIndex = 6;
            lblFechaValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbDatosGenerales
            // 
            gbDatosGenerales.Controls.Add(lblMedioPagoDet);
            gbDatosGenerales.Controls.Add(lblMedioPago);
            gbDatosGenerales.Controls.Add(txtPresupuestoDet);
            gbDatosGenerales.Controls.Add(lblPresupuesto);
            gbDatosGenerales.Controls.Add(txtDescripcionDet);
            gbDatosGenerales.Controls.Add(lblDescripcion);
            gbDatosGenerales.Controls.Add(txtModeloDet);
            gbDatosGenerales.Controls.Add(lblModelo);
            gbDatosGenerales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbDatosGenerales.ForeColor = Color.FromArgb(64, 64, 64);
            gbDatosGenerales.Location = new Point(20, 120);
            gbDatosGenerales.Name = "gbDatosGenerales";
            gbDatosGenerales.Size = new Size(670, 150);
            gbDatosGenerales.TabIndex = 7;
            gbDatosGenerales.TabStop = false;
            gbDatosGenerales.Text = "Datos Generales";
            // 
            // lblMedioPagoDet
            // 
            lblMedioPagoDet.BackColor = Color.FromArgb(240, 240, 240);
            lblMedioPagoDet.BorderStyle = BorderStyle.FixedSingle;
            lblMedioPagoDet.Font = new Font("Segoe UI", 9F);
            lblMedioPagoDet.Location = new Point(110, 115);
            lblMedioPagoDet.Name = "lblMedioPagoDet";
            lblMedioPagoDet.Padding = new Padding(5, 0, 0, 0);
            lblMedioPagoDet.Size = new Size(150, 23);
            lblMedioPagoDet.TabIndex = 9;
            lblMedioPagoDet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.Font = new Font("Segoe UI", 9F);
            lblMedioPago.Location = new Point(24, 119);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(74, 15);
            lblMedioPago.TabIndex = 8;
            lblMedioPago.Text = "Medio Pago:";
            // 
            // txtPresupuestoDet
            // 
            txtPresupuestoDet.Font = new Font("Segoe UI", 9F);
            txtPresupuestoDet.Location = new Point(435, 28);
            txtPresupuestoDet.Name = "txtPresupuestoDet";
            txtPresupuestoDet.Size = new Size(100, 23);
            txtPresupuestoDet.TabIndex = 5;
            txtPresupuestoDet.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Font = new Font("Segoe UI", 9F);
            lblPresupuesto.Location = new Point(350, 31);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(75, 15);
            lblPresupuesto.TabIndex = 4;
            lblPresupuesto.Text = "Presupuesto:";
            // 
            // txtDescripcionDet
            // 
            txtDescripcionDet.Font = new Font("Segoe UI", 9F);
            txtDescripcionDet.Location = new Point(100, 58);
            txtDescripcionDet.Multiline = true;
            txtDescripcionDet.Name = "txtDescripcionDet";
            txtDescripcionDet.ScrollBars = ScrollBars.Vertical;
            txtDescripcionDet.Size = new Size(540, 50);
            txtDescripcionDet.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F);
            lblDescripcion.Location = new Point(15, 61);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtModeloDet
            // 
            txtModeloDet.Font = new Font("Segoe UI", 9F);
            txtModeloDet.Location = new Point(100, 28);
            txtModeloDet.Name = "txtModeloDet";
            txtModeloDet.Size = new Size(200, 23);
            txtModeloDet.TabIndex = 1;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 9F);
            lblModelo.Location = new Point(15, 31);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 0;
            lblModelo.Text = "Modelo:";
            // 
            // gbEstado
            // 
            gbEstado.Controls.Add(lblValidacionEstado);
            gbEstado.Controls.Add(cbNuevoEstado);
            gbEstado.Controls.Add(lblEstadoTexto);
            gbEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbEstado.ForeColor = Color.FromArgb(64, 64, 64);
            gbEstado.Location = new Point(20, 285);
            gbEstado.Name = "gbEstado";
            gbEstado.Size = new Size(320, 110);
            gbEstado.TabIndex = 8;
            gbEstado.TabStop = false;
            gbEstado.Text = "Estado";
            // 
            // lblValidacionEstado
            // 
            lblValidacionEstado.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblValidacionEstado.ForeColor = Color.Gray;
            lblValidacionEstado.Location = new Point(15, 65);
            lblValidacionEstado.Name = "lblValidacionEstado";
            lblValidacionEstado.Size = new Size(290, 35);
            lblValidacionEstado.TabIndex = 2;
            lblValidacionEstado.Text = "(Al elegir \"Entregado\", valida que saldo = 0)";
            // 
            // cbNuevoEstado
            // 
            cbNuevoEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNuevoEstado.Font = new Font("Segoe UI", 9F);
            cbNuevoEstado.FormattingEnabled = true;
            cbNuevoEstado.Items.AddRange(new object[] { "Pendiente", "En Reparación", "Entregado", "Cancelado" });
            cbNuevoEstado.Location = new Point(110, 30);
            cbNuevoEstado.Name = "cbNuevoEstado";
            cbNuevoEstado.Size = new Size(150, 23);
            cbNuevoEstado.TabIndex = 1;
            // 
            // lblEstadoTexto
            // 
            lblEstadoTexto.AutoSize = true;
            lblEstadoTexto.Font = new Font("Segoe UI", 9F);
            lblEstadoTexto.Location = new Point(15, 33);
            lblEstadoTexto.Name = "lblEstadoTexto";
            lblEstadoTexto.Size = new Size(83, 15);
            lblEstadoTexto.TabIndex = 0;
            lblEstadoTexto.Text = "Nuevo Estado:";
            // 
            // gbFoto
            // 
            gbFoto.Controls.Add(pbFotoEquipo3);
            gbFoto.Controls.Add(pbFotoEquipo2);
            gbFoto.Controls.Add(pbFotoEquipo1);
            gbFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbFoto.ForeColor = Color.FromArgb(64, 64, 64);
            gbFoto.Location = new Point(346, 267);
            gbFoto.Name = "gbFoto";
            gbFoto.Size = new Size(344, 128);
            gbFoto.TabIndex = 9;
            gbFoto.TabStop = false;
            gbFoto.Text = "Foto del Equipo";
            // 
            // pbFotoEquipo3
            // 
            pbFotoEquipo3.BackColor = Color.White;
            pbFotoEquipo3.BorderStyle = BorderStyle.FixedSingle;
            pbFotoEquipo3.Location = new Point(240, 25);
            pbFotoEquipo3.Name = "pbFotoEquipo3";
            pbFotoEquipo3.Size = new Size(94, 93);
            pbFotoEquipo3.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoEquipo3.TabIndex = 3;
            pbFotoEquipo3.TabStop = false;
            // 
            // pbFotoEquipo2
            // 
            pbFotoEquipo2.BackColor = Color.White;
            pbFotoEquipo2.BorderStyle = BorderStyle.FixedSingle;
            pbFotoEquipo2.Location = new Point(125, 25);
            pbFotoEquipo2.Name = "pbFotoEquipo2";
            pbFotoEquipo2.Size = new Size(94, 93);
            pbFotoEquipo2.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoEquipo2.TabIndex = 2;
            pbFotoEquipo2.TabStop = false;
            // 
            // pbFotoEquipo1
            // 
            pbFotoEquipo1.BackColor = Color.White;
            pbFotoEquipo1.BorderStyle = BorderStyle.FixedSingle;
            pbFotoEquipo1.Location = new Point(10, 25);
            pbFotoEquipo1.Name = "pbFotoEquipo1";
            pbFotoEquipo1.Size = new Size(96, 93);
            pbFotoEquipo1.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoEquipo1.TabIndex = 0;
            pbFotoEquipo1.TabStop = false;
            // 
            // btnGuardarDet
            // 
            btnGuardarDet.BackColor = Color.FromArgb(0, 120, 215);
            btnGuardarDet.DialogResult = DialogResult.OK;
            btnGuardarDet.FlatAppearance.BorderSize = 0;
            btnGuardarDet.FlatStyle = FlatStyle.Flat;
            btnGuardarDet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarDet.ForeColor = Color.White;
            btnGuardarDet.Location = new Point(450, 401);
            btnGuardarDet.Name = "btnGuardarDet";
            btnGuardarDet.Size = new Size(120, 35);
            btnGuardarDet.TabIndex = 10;
            btnGuardarDet.Text = "Guardar Cambios";
            btnGuardarDet.UseVisualStyleBackColor = false;
            btnGuardarDet.Click += btnGuardarDet_Click;
            // 
            // btnCancelarDet
            // 
            btnCancelarDet.BackColor = Color.Gray;
            btnCancelarDet.DialogResult = DialogResult.Cancel;
            btnCancelarDet.FlatAppearance.BorderSize = 0;
            btnCancelarDet.FlatStyle = FlatStyle.Flat;
            btnCancelarDet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelarDet.ForeColor = Color.White;
            btnCancelarDet.Location = new Point(580, 401);
            btnCancelarDet.Name = "btnCancelarDet";
            btnCancelarDet.Size = new Size(100, 35);
            btnCancelarDet.TabIndex = 11;
            btnCancelarDet.Text = "Cancelar";
            btnCancelarDet.UseVisualStyleBackColor = false;
            btnCancelarDet.Click += btnCancelarDet_Click;
            // 
            // FormDetalleReparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(704, 441);
            Controls.Add(btnCancelarDet);
            Controls.Add(btnGuardarDet);
            Controls.Add(gbFoto);
            Controls.Add(gbEstado);
            Controls.Add(gbDatosGenerales);
            Controls.Add(lblFechaValor);
            Controls.Add(lblFechaTexto);
            Controls.Add(lblDniValor);
            Controls.Add(lblDniTexto);
            Controls.Add(lblClienteValor);
            Controls.Add(lblClienteTexto);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDetalleReparacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalle de Reparación";
            Load += FormDetalleReparacion_Load;
            gbDatosGenerales.ResumeLayout(false);
            gbDatosGenerales.PerformLayout();
            gbEstado.ResumeLayout(false);
            gbEstado.PerformLayout();
            gbFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFotoEquipo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoEquipo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoEquipo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblClienteTexto;
        private Label lblClienteValor;
        private Label lblDniTexto;
        private Label lblDniValor;
        private Label lblFechaTexto;
        private Label lblFechaValor;
        private Label lblMedioPagoDet;
        private Label lblMedioPago;
        private Label lblPresupuesto;
        private Label lblDescripcion;
        private TextBox txtPresupuestoDet;
        private TextBox txtDescripcionDet;
        private TextBox txtModeloDet;
        private Button btnGuardarDet;
        private Button btnCancelarDet;
        private ComboBox cbNuevoEstado;
        private GroupBox gbDatosGenerales;
        private GroupBox gbEstado;
        private GroupBox gbFoto;
        private PictureBox pbFotoEquipo1;
        private Label lblModelo;
        private Label lblValidacionEstado;
        private Label lblEstadoTexto;
        private PictureBox pbFotoEquipo3;
        private PictureBox pbFotoEquipo2;
    }
}