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
            dgvStock = new DataGridView();
            textBox1 = new TextBox();
            button5 = new Button();
            colNombre = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(67, 90, 111);
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, -6);
            label1.Name = "label1";
            label1.Size = new Size(958, 69);
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
            button1.Location = new Point(27, 84);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(206, 93);
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
            button2.Location = new Point(261, 84);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(206, 93);
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
            button3.Location = new Point(491, 84);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(206, 93);
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
            button4.Location = new Point(727, 84);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(206, 93);
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
            label2.Location = new Point(27, 214);
            label2.Name = "label2";
            label2.Size = new Size(906, 54);
            label2.TabIndex = 5;
            label2.Text = "Stock/Productos";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvStock
            // 
            dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStock.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { colNombre, colModelo, colTipo, colStock, colPrecio, colAcciones });
            dgvStock.Location = new Point(27, 338);
            dgvStock.Margin = new Padding(3, 4, 3, 4);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvStock.RowHeadersVisible = false;
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(906, 188);
            dgvStock.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.ForeColor = Color.FromArgb(108, 117, 125);
            textBox1.Location = new Point(630, 289);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 35);
            textBox1.TabIndex = 7;
            textBox1.Text = "Buscar Producto...";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(100, 149, 117);
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(27, 289);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(163, 44);
            button5.TabIndex = 8;
            button5.Text = "Agregar Producto";
            button5.UseVisualStyleBackColor = false;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            // 
            // colModelo
            // 
            colModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colModelo.HeaderText = "Modelo";
            colModelo.MinimumWidth = 6;
            colModelo.Name = "colModelo";
            // 
            // colTipo
            // 
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            // 
            // colAcciones
            // 
            colAcciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 554);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(dgvStock);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaPrincipal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
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
        private DataGridView dgvStock;
        private TextBox textBox1;
        private Button button5;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colAcciones;
    }
}