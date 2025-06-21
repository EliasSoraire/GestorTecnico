namespace Gestor_Tecnico
{
    partial class EditarProducto
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
            // Header Panel
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();

            // Main Content Panel
            panelContent = new Panel();

            // Input Fields
            txtEditarNombre = new TextBox();
            txtEditarModelo = new TextBox();
            txtEditarPrecio = new TextBox();
            txtEditarStock = new TextBox();
            cmbEditarTipoProducto = new ComboBox();

            // Labels
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();

            // Action Panel
            panelActions = new Panel();
            btnGuardarProducto = new Button();

            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelActions.SuspendLayout();
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
            panelHeader.Size = new Size(646, 91);
            panelHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Editar Producto";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(30, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(199, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Modifica la información del producto";

            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(txtEditarNombre);
            panelContent.Controls.Add(label4);
            panelContent.Controls.Add(txtEditarModelo);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(cmbEditarTipoProducto);
            panelContent.Controls.Add(label6);
            panelContent.Controls.Add(txtEditarPrecio);
            panelContent.Controls.Add(label7);
            panelContent.Controls.Add(txtEditarStock);
            panelContent.Controls.Add(label8);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 91);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(30, 30, 30, 80);
            panelContent.Size = new Size(646, 481);
            panelContent.TabIndex = 1;

            // 
            // label4 - Nombre
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(52, 73, 94);
            label4.Location = new Point(30, 30);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 0;
            label4.Text = "Nombre";

            // 
            // txtEditarNombre
            // 
            txtEditarNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEditarNombre.BackColor = Color.FromArgb(236, 240, 241);
            txtEditarNombre.BorderStyle = BorderStyle.None;
            txtEditarNombre.Font = new Font("Segoe UI", 12F);
            txtEditarNombre.ForeColor = Color.FromArgb(52, 73, 94);
            txtEditarNombre.Location = new Point(30, 58);
            txtEditarNombre.Margin = new Padding(3, 4, 3, 4);
            txtEditarNombre.Multiline = true;
            txtEditarNombre.Name = "txtEditarNombre";
            txtEditarNombre.Padding = new Padding(12, 10, 12, 10);
            txtEditarNombre.Size = new Size(586, 40);
            txtEditarNombre.TabIndex = 1;

            // 
            // label5 - Modelo
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(52, 73, 94);
            label5.Location = new Point(30, 120);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 2;
            label5.Text = "Modelo";

            // 
            // txtEditarModelo
            // 
            txtEditarModelo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEditarModelo.BackColor = Color.FromArgb(236, 240, 241);
            txtEditarModelo.BorderStyle = BorderStyle.None;
            txtEditarModelo.Font = new Font("Segoe UI", 12F);
            txtEditarModelo.ForeColor = Color.FromArgb(52, 73, 94);
            txtEditarModelo.Location = new Point(30, 148);
            txtEditarModelo.Margin = new Padding(3, 4, 3, 4);
            txtEditarModelo.Multiline = true;
            txtEditarModelo.Name = "txtEditarModelo";
            txtEditarModelo.Padding = new Padding(12, 10, 12, 10);
            txtEditarModelo.Size = new Size(586, 40);
            txtEditarModelo.TabIndex = 3;

            // 
            // label6 - Tipo
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(52, 73, 94);
            label6.Location = new Point(30, 210);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 4;
            label6.Text = "Tipo";

            // 
            // cmbEditarTipoProducto
            // 
            cmbEditarTipoProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbEditarTipoProducto.BackColor = Color.FromArgb(236, 240, 241);
            cmbEditarTipoProducto.DisplayMember = "Descripcion";
            cmbEditarTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditarTipoProducto.FlatStyle = FlatStyle.Flat;
            cmbEditarTipoProducto.Font = new Font("Segoe UI", 12F);
            cmbEditarTipoProducto.ForeColor = Color.FromArgb(52, 73, 94);
            cmbEditarTipoProducto.FormattingEnabled = true;
            cmbEditarTipoProducto.Location = new Point(30, 238);
            cmbEditarTipoProducto.Name = "cmbEditarTipoProducto";
            cmbEditarTipoProducto.Size = new Size(586, 29);
            cmbEditarTipoProducto.TabIndex = 5;
            cmbEditarTipoProducto.ValueMember = "idTipoProducto";

            // 
            // label7 - Precio
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(52, 73, 94);
            label7.Location = new Point(30, 290);
            label7.Name = "label7";
            label7.Size = new Size(129, 21);
            label7.TabIndex = 6;
            label7.Text = "Precio de Venta";

            // 
            // txtEditarPrecio
            // 
            txtEditarPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEditarPrecio.BackColor = Color.FromArgb(236, 240, 241);
            txtEditarPrecio.BorderStyle = BorderStyle.None;
            txtEditarPrecio.Font = new Font("Segoe UI", 12F);
            txtEditarPrecio.ForeColor = Color.FromArgb(52, 73, 94);
            txtEditarPrecio.Location = new Point(30, 318);
            txtEditarPrecio.Margin = new Padding(3, 4, 3, 4);
            txtEditarPrecio.Multiline = true;
            txtEditarPrecio.Name = "txtEditarPrecio";
            txtEditarPrecio.Padding = new Padding(12, 10, 12, 10);
            txtEditarPrecio.Size = new Size(586, 40);
            txtEditarPrecio.TabIndex = 7;

            // 
            // label8 - Stock
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(52, 73, 94);
            label8.Location = new Point(30, 380);
            label8.Name = "label8";
            label8.Size = new Size(147, 21);
            label8.TabIndex = 8;
            label8.Text = "Cantidad en Stock";

            // 
            // txtEditarStock
            // 
            txtEditarStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEditarStock.BackColor = Color.FromArgb(236, 240, 241);
            txtEditarStock.BorderStyle = BorderStyle.None;
            txtEditarStock.Font = new Font("Segoe UI", 12F);
            txtEditarStock.ForeColor = Color.FromArgb(52, 73, 94);
            txtEditarStock.Location = new Point(30, 408);
            txtEditarStock.Margin = new Padding(3, 4, 3, 4);
            txtEditarStock.Multiline = true;
            txtEditarStock.Name = "txtEditarStock";
            txtEditarStock.Padding = new Padding(12, 10, 12, 10);
            txtEditarStock.Size = new Size(586, 40);
            txtEditarStock.TabIndex = 9;

            // 
            // panelActions
            // 
            panelActions.BackColor = Color.FromArgb(236, 240, 241);
            panelActions.Controls.Add(btnGuardarProducto);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 492);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(30, 20, 30, 20);
            panelActions.Size = new Size(646, 80);
            panelActions.TabIndex = 2;

            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarProducto.BackColor = Color.FromArgb(39, 174, 96);
            btnGuardarProducto.FlatAppearance.BorderSize = 0;
            btnGuardarProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 155, 86);
            btnGuardarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            btnGuardarProducto.FlatStyle = FlatStyle.Flat;
            btnGuardarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardarProducto.ForeColor = Color.White;
            btnGuardarProducto.Location = new Point(30, 20);
            btnGuardarProducto.Margin = new Padding(3, 4, 3, 4);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(586, 40);
            btnGuardarProducto.TabIndex = 10;
            btnGuardarProducto.Text = "💾 Guardar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = false;

            // 
            // EditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(646, 572);
            Controls.Add(panelActions);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Producto - Gestor Técnico";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelContent;
        private Panel panelActions;
        private Button btnGuardarProducto;
        private TextBox txtEditarStock;
        private Label label8;
        private TextBox txtEditarPrecio;
        private Label label7;
        private TextBox txtEditarModelo;
        private Label label6;
        private Label label5;
        private TextBox txtEditarNombre;
        private Label label4;
        private ComboBox cmbEditarTipoProducto;
    }
}