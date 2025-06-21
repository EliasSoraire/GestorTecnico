namespace Gestor_Tecnico
{
    partial class AgregarProducto
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
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelContent = new Panel();
            panelFormFields = new Panel();
            btnAgregarProducto = new Button();
            txtStock = new TextBox();
            label8 = new Label();
            txtPrecio = new TextBox();
            label7 = new Label();
            cmbTipoProducto = new ComboBox();
            label6 = new Label();
            txtModelo = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelFormFields.SuspendLayout();
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
            panelHeader.Size = new Size(670, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 50);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(188, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Ingrese los datos del producto";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📦 Agregar Producto";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(236, 240, 241);
            panelContent.Controls.Add(panelFormFields);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 80);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(670, 485);
            panelContent.TabIndex = 1;
            // 
            // panelFormFields
            // 
            panelFormFields.BackColor = Color.White;
            panelFormFields.Controls.Add(btnAgregarProducto);
            panelFormFields.Controls.Add(txtStock);
            panelFormFields.Controls.Add(label8);
            panelFormFields.Controls.Add(txtPrecio);
            panelFormFields.Controls.Add(label7);
            panelFormFields.Controls.Add(cmbTipoProducto);
            panelFormFields.Controls.Add(label6);
            panelFormFields.Controls.Add(txtModelo);
            panelFormFields.Controls.Add(label5);
            panelFormFields.Controls.Add(txtNombre);
            panelFormFields.Controls.Add(label4);
            panelFormFields.Dock = DockStyle.Fill;
            panelFormFields.Location = new Point(20, 20);
            panelFormFields.Name = "panelFormFields";
            panelFormFields.Padding = new Padding(30);
            panelFormFields.Size = new Size(630, 445);
            panelFormFields.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarProducto.BackColor = Color.FromArgb(39, 174, 96);
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(30, 380);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(570, 50);
            btnAgregarProducto.TabIndex = 27;
            btnAgregarProducto.Text = "💾 Guardar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.Font = new Font("Segoe UI", 11F);
            txtStock.ForeColor = Color.FromArgb(52, 73, 94);
            txtStock.Location = new Point(30, 330);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(10);
            txtStock.Size = new Size(570, 35);
            txtStock.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(52, 73, 94);
            label8.Location = new Point(30, 305);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 25;
            label8.Text = "Cantidad en Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Font = new Font("Segoe UI", 11F);
            txtPrecio.ForeColor = Color.FromArgb(52, 73, 94);
            txtPrecio.Location = new Point(30, 260);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Padding = new Padding(10);
            txtPrecio.Size = new Size(570, 35);
            txtPrecio.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(52, 73, 94);
            label7.Location = new Point(30, 235);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 23;
            label7.Text = "Precio de Venta";
            // 
            // cmbTipoProducto
            // 
            cmbTipoProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoProducto.FlatStyle = FlatStyle.Flat;
            cmbTipoProducto.Font = new Font("Segoe UI", 11F);
            cmbTipoProducto.ForeColor = Color.FromArgb(52, 73, 94);
            cmbTipoProducto.FormattingEnabled = true;
            cmbTipoProducto.Location = new Point(30, 190);
            cmbTipoProducto.Name = "cmbTipoProducto";
            cmbTipoProducto.Size = new Size(570, 28);
            cmbTipoProducto.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(52, 73, 94);
            label6.Location = new Point(30, 165);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 20;
            label6.Text = "Tipo";
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtModelo.BorderStyle = BorderStyle.None;
            txtModelo.Font = new Font("Segoe UI", 11F);
            txtModelo.ForeColor = Color.FromArgb(52, 73, 94);
            txtModelo.Location = new Point(30, 120);
            txtModelo.Multiline = true;
            txtModelo.Name = "txtModelo";
            txtModelo.Padding = new Padding(10);
            txtModelo.Size = new Size(570, 35);
            txtModelo.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(52, 73, 94);
            label5.Location = new Point(30, 95);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 19;
            label5.Text = "Modelo";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.ForeColor = Color.FromArgb(52, 73, 94);
            txtNombre.Location = new Point(30, 50);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(10);
            txtNombre.Size = new Size(570, 35);
            txtNombre.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(52, 73, 94);
            label4.Location = new Point(30, 25);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 17;
            label4.Text = "Nombre";
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(670, 565);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión - Agregar Producto";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelFormFields.ResumeLayout(false);
            panelFormFields.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel panelContent;
        private Panel panelFormFields;
        private Button btnAgregarProducto;
        private TextBox txtStock;
        private Label label8;
        private TextBox txtPrecio;
        private Label label7;
        private TextBox txtModelo;
        private Label label6;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private ComboBox cmbTipoProducto;
    }
}