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
            button5 = new Button();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(100, 149, 117);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(18, 434);
            button5.Name = "button5";
            button5.Size = new Size(561, 38);
            button5.TabIndex = 27;
            button5.Text = "Guardar Producto";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.ForeColor = Color.Gray;
            textBox5.Location = new Point(18, 381);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(562, 35);
            textBox5.TabIndex = 26;
            textBox5.Text = "0";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 357);
            label8.Name = "label8";
            label8.Size = new Size(144, 21);
            label8.TabIndex = 25;
            label8.Text = "Cantidad en Stock";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(18, 305);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(562, 35);
            textBox4.TabIndex = 24;
            textBox4.Text = "0.00";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 281);
            label7.Name = "label7";
            label7.Size = new Size(129, 21);
            label7.TabIndex = 23;
            label7.Text = "Precio de Venta";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(18, 225);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(562, 35);
            textBox3.TabIndex = 22;
            textBox3.Text = "Tipo (funda, cargador, etc)";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(18, 145);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(562, 35);
            textBox2.TabIndex = 21;
            textBox2.Text = "Modelo o Referencia";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 202);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 20;
            label6.Text = "Tipo";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 122);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 19;
            label5.Text = "Modelo";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(18, 71);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(562, 35);
            textBox1.TabIndex = 18;
            textBox1.Text = "Nombre del Producto";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 47);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 17;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 149, 117);
            label3.Location = new Point(9, 16);
            label3.Name = "label3";
            label3.Size = new Size(214, 31);
            label3.TabIndex = 16;
            label3.Text = "+ Alta de Producto";
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 488);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(604, 527);
            MinimizeBox = false;
            MinimumSize = new Size(604, 527);
            Name = "AgregarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
    }
}