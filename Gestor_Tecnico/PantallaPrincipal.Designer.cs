namespace Gestor_Tecnico
{
    partial class PantallaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(67, 90, 111);
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, -5);
            label1.Name = "label1";
            label1.Size = new Size(838, 59);
            label1.TabIndex = 0;
            label1.Text = "Pantalla Principal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(88, 129, 148);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 71);
            button1.Name = "button1";
            button1.Size = new Size(180, 79);
            button1.TabIndex = 1;
            button1.Text = "Reparaciones";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(145, 123, 96);
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(228, 71);
            button2.Name = "button2";
            button2.Size = new Size(180, 79);
            button2.TabIndex = 2;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.FromArgb(123, 104, 144);
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(430, 71);
            button3.Name = "button3";
            button3.Size = new Size(180, 79);
            button3.TabIndex = 3;
            button3.Text = "Clientes";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.BackColor = Color.FromArgb(150, 102, 102);
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(636, 71);
            button4.Name = "button4";
            button4.Size = new Size(180, 79);
            button4.TabIndex = 4;
            button4.Text = "Reportes";
            button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 16.2F);
            label2.ForeColor = Color.FromArgb(67, 90, 111);
            label2.Location = new Point(24, 182);
            label2.Name = "label2";
            label2.Size = new Size(793, 46);
            label2.TabIndex = 5;
            label2.Text = "Stock/Productos";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(24, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(793, 160);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Modelo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Tipo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Stock";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Precio";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Acciones";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.ForeColor = Color.FromArgb(108, 117, 125);
            textBox1.Location = new Point(551, 246);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 30);
            textBox1.TabIndex = 7;
            textBox1.Text = "Buscar Producto...";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(100, 149, 117);
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(24, 246);
            button5.Name = "button5";
            button5.Size = new Size(143, 37);
            button5.TabIndex = 8;
            button5.Text = "Agregar Producto";
            button5.UseVisualStyleBackColor = false;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 471);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "PantallaPrincipal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBox1;
        private Button button5;
    }
}