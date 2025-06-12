namespace Gestor_Tecnico
{
    partial class GestiondeClientes
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
            label1 = new Label();
            button2 = new Button();
            btnGuardarCliente = new Button();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDomicilio = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtNombres = new TextBox();
            label3 = new Label();
            txtDNI = new TextBox();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            textBox7 = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(123, 104, 144);
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(831, 50);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(90, 76, 105);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(158, 382);
            button2.Name = "button2";
            button2.Size = new Size(122, 30);
            button2.TabIndex = 35;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.FromArgb(123, 104, 144);
            btnGuardarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarCliente.Location = new Point(18, 382);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(122, 30);
            btnGuardarCliente.TabIndex = 34;
            btnGuardarCliente.Text = "Guardar Cliente";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(18, 336);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 25);
            txtEmail.TabIndex = 33;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(90, 76, 105);
            label7.Location = new Point(18, 314);
            label7.Name = "label7";
            label7.Size = new Size(262, 18);
            label7.TabIndex = 32;
            label7.Text = "Direccion Email";
            // 
            // txtDomicilio
            // 
            txtDomicilio.ForeColor = Color.Gray;
            txtDomicilio.Location = new Point(18, 280);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(263, 25);
            txtDomicilio.TabIndex = 31;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(90, 76, 105);
            label6.Location = new Point(18, 259);
            label6.Name = "label6";
            label6.Size = new Size(262, 18);
            label6.TabIndex = 30;
            label6.Text = "Domicilio";
            // 
            // txtTelefono
            // 
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.Location = new Point(18, 225);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(263, 25);
            txtTelefono.TabIndex = 29;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(90, 76, 105);
            label5.Location = new Point(18, 204);
            label5.Name = "label5";
            label5.Size = new Size(262, 18);
            label5.TabIndex = 28;
            label5.Text = "Numero de Telefono";
            // 
            // txtNombres
            // 
            txtNombres.ForeColor = Color.Gray;
            txtNombres.Location = new Point(18, 170);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(263, 25);
            txtNombres.TabIndex = 27;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(90, 76, 105);
            label3.Location = new Point(18, 149);
            label3.Name = "label3";
            label3.Size = new Size(262, 18);
            label3.TabIndex = 26;
            label3.Text = "Nombre y Apellido";
            // 
            // txtDNI
            // 
            txtDNI.ForeColor = Color.Gray;
            txtDNI.Location = new Point(18, 115);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(263, 25);
            txtDNI.TabIndex = 25;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(90, 76, 105);
            label4.Location = new Point(18, 94);
            label4.Name = "label4";
            label4.Size = new Size(262, 18);
            label4.TabIndex = 24;
            label4.Text = "DNI";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(123, 104, 144);
            label2.Location = new Point(18, 60);
            label2.Name = "label2";
            label2.Size = new Size(175, 26);
            label2.TabIndex = 23;
            label2.Text = "+ Alta de Cliente";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5 });
            dataGridView1.Location = new Point(378, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(427, 285);
            dataGridView1.TabIndex = 38;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 80F;
            Column1.HeaderText = "DNI";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 120F;
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Telefono";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 80F;
            Column5.HeaderText = "Historial";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(673, 87);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(132, 25);
            textBox7.TabIndex = 37;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(123, 104, 144);
            label8.Location = new Point(378, 64);
            label8.Name = "label8";
            label8.Size = new Size(172, 18);
            label8.TabIndex = 36;
            label8.Text = "Listado de Clientes";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(567, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(79, 25);
            comboBox1.TabIndex = 39;
            // 
            // GestiondeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 429);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(btnGuardarCliente);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtDomicilio);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtNombres);
            Controls.Add(label3);
            Controls.Add(txtDNI);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(702, 431);
            Name = "GestiondeClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Clientes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button btnGuardarCliente;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtDomicilio;
        private Label label6;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtNombres;
        private Label label3;
        private TextBox txtDNI;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column5;
        private Label label8;
        private ComboBox comboBox1;
    }
}