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
            button5 = new Button();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(100, 149, 117);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(23, 501);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(611, 45);
            button5.TabIndex = 39;
            button5.Text = "Guardar Producto";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.ForeColor = Color.Gray;
            textBox5.Location = new Point(23, 442);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(611, 40);
            textBox5.TabIndex = 38;
            textBox5.Text = "0";
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
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(23, 353);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(611, 40);
            textBox4.TabIndex = 36;
            textBox4.Text = "0.00";
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
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(23, 165);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(611, 40);
            textBox2.TabIndex = 33;
            textBox2.Text = "Modelo o Referencia";
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(23, 78);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(611, 40);
            textBox1.TabIndex = 30;
            textBox1.Text = "Nombre del Producto";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(611, 28);
            comboBox1.TabIndex = 40;
            // 
            // EditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 572);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "EditarProducto";
            Text = "EditarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
    }
}