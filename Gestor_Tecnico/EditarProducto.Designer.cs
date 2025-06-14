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
            btnGuardarProducto = new Button();
            txtEditarStock = new TextBox();
            label8 = new Label();
            txtEditarPrecio = new TextBox();
            label7 = new Label();
            txtEditarModelo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtEditarNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbEditarTipoProducto = new ComboBox();
            SuspendLayout();
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarProducto.BackColor = Color.FromArgb(100, 149, 117);
            btnGuardarProducto.FlatStyle = FlatStyle.Flat;
            btnGuardarProducto.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarProducto.Location = new Point(23, 501);
            btnGuardarProducto.Margin = new Padding(3, 4, 3, 4);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(611, 45);
            btnGuardarProducto.TabIndex = 39;
            btnGuardarProducto.Text = "Guardar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            // 
            // txtEditarStock
            // 
            txtEditarStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEditarStock.ForeColor = Color.Gray;
            txtEditarStock.Location = new Point(23, 442);
            txtEditarStock.Margin = new Padding(3, 4, 3, 4);
            txtEditarStock.Multiline = true;
            txtEditarStock.Name = "txtEditarStock";
            txtEditarStock.Size = new Size(611, 40);
            txtEditarStock.TabIndex = 38;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 413);
            label8.Name = "label8";
            label8.Size = new Size(165, 25);
            label8.TabIndex = 37;
            label8.Text = "Cantidad en Stock";
            // 
            // txtEditarPrecio
            // 
            txtEditarPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEditarPrecio.ForeColor = Color.Gray;
            txtEditarPrecio.Location = new Point(23, 353);
            txtEditarPrecio.Margin = new Padding(3, 4, 3, 4);
            txtEditarPrecio.Multiline = true;
            txtEditarPrecio.Name = "txtEditarPrecio";
            txtEditarPrecio.Size = new Size(611, 40);
            txtEditarPrecio.TabIndex = 36;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 324);
            label7.Name = "label7";
            label7.Size = new Size(147, 25);
            label7.TabIndex = 35;
            label7.Text = "Precio de Venta";
            // 
            // txtEditarModelo
            // 
            txtEditarModelo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEditarModelo.ForeColor = Color.Gray;
            txtEditarModelo.Location = new Point(23, 165);
            txtEditarModelo.Margin = new Padding(3, 4, 3, 4);
            txtEditarModelo.Multiline = true;
            txtEditarModelo.Name = "txtEditarModelo";
            txtEditarModelo.Size = new Size(611, 40);
            txtEditarModelo.TabIndex = 33;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 230);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 32;
            label6.Text = "Tipo";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 136);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 31;
            label5.Text = "Modelo";
            // 
            // txtEditarNombre
            // 
            txtEditarNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEditarNombre.ForeColor = Color.Gray;
            txtEditarNombre.Location = new Point(23, 78);
            txtEditarNombre.Margin = new Padding(3, 4, 3, 4);
            txtEditarNombre.Multiline = true;
            txtEditarNombre.Name = "txtEditarNombre";
            txtEditarNombre.Size = new Size(611, 40);
            txtEditarNombre.TabIndex = 30;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 49);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 29;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 149, 117);
            label3.Location = new Point(23, 9);
            label3.Name = "label3";
            label3.Size = new Size(192, 36);
            label3.TabIndex = 28;
            label3.Text = "Editar Producto";
            // 
            // cmbEditarTipoProducto
            // 
            cmbEditarTipoProducto.DisplayMember = "Descripcion";
            cmbEditarTipoProducto.FormattingEnabled = true;
            cmbEditarTipoProducto.Location = new Point(23, 265);
            cmbEditarTipoProducto.Name = "cmbEditarTipoProducto";
            cmbEditarTipoProducto.Size = new Size(611, 28);
            cmbEditarTipoProducto.TabIndex = 40;
            cmbEditarTipoProducto.ValueMember = "idTipoProducto";
            // 
            // EditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 572);
            Controls.Add(cmbEditarTipoProducto);
            Controls.Add(btnGuardarProducto);
            Controls.Add(txtEditarStock);
            Controls.Add(label8);
            Controls.Add(txtEditarPrecio);
            Controls.Add(label7);
            Controls.Add(txtEditarModelo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEditarNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "EditarProducto";
            Text = "EditarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label3;
        private ComboBox cmbEditarTipoProducto;
    }
}