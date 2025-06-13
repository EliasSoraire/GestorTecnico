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
            btnAgregarProducto = new Button();
            txtStock = new TextBox();
            label8 = new Label();
            txtPrecio = new TextBox();
            label7 = new Label();
            txtModelo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbTipoProducto = new ComboBox();
            SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarProducto.BackColor = Color.FromArgb(100, 149, 117);
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarProducto.Location = new Point(21, 511);
            btnAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(641, 45);
            btnAgregarProducto.TabIndex = 27;
            btnAgregarProducto.Text = "Guardar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStock.ForeColor = Color.Gray;
            txtStock.Location = new Point(21, 448);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(642, 40);
            txtStock.TabIndex = 26;
            txtStock.Text = "0";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 420);
            label8.Name = "label8";
            label8.Size = new Size(165, 25);
            label8.TabIndex = 25;
            label8.Text = "Cantidad en Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.ForeColor = Color.Gray;
            txtPrecio.Location = new Point(21, 359);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(642, 40);
            txtPrecio.TabIndex = 24;
            txtPrecio.Text = "0.00";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 331);
            label7.Name = "label7";
            label7.Size = new Size(147, 25);
            label7.TabIndex = 23;
            label7.Text = "Precio de Venta";
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtModelo.ForeColor = Color.Gray;
            txtModelo.Location = new Point(21, 171);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Multiline = true;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(642, 40);
            txtModelo.TabIndex = 21;
            txtModelo.Text = "Modelo o Referencia";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 238);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 20;
            label6.Text = "Tipo";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 144);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 19;
            label5.Text = "Modelo";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Location = new Point(21, 84);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(642, 40);
            txtNombre.TabIndex = 18;
            txtNombre.Text = "Nombre del Producto";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 55);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 17;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 149, 117);
            label3.Location = new Point(10, 19);
            label3.Name = "label3";
            label3.Size = new Size(245, 36);
            label3.TabIndex = 16;
            label3.Text = "+ Alta de Producto";
            // 
            // cmbTipoProducto
            // 
            cmbTipoProducto.FormattingEnabled = true;
            cmbTipoProducto.Location = new Point(12, 266);
            cmbTipoProducto.Name = "cmbTipoProducto";
            cmbTipoProducto.Size = new Size(637, 28);
            cmbTipoProducto.TabIndex = 28;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 565);
            Controls.Add(cmbTipoProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtStock);
            Controls.Add(label8);
            Controls.Add(txtPrecio);
            Controls.Add(label7);
            Controls.Add(txtModelo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(688, 612);
            MinimizeBox = false;
            MinimumSize = new Size(688, 612);
            Name = "AgregarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label3;
        private ComboBox cmbTipoProducto;
    }
}