namespace Gestor_Tecnico
{
    partial class Reportes
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
            panelConfig = new Panel();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            panelStats = new Panel();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panelGrid = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label12 = new Label();
            panelHeader.SuspendLayout();
            panelConfig.SuspendLayout();
            panelStats.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panelHeader.Size = new Size(827, 91);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(210, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Generación y análisis de reportes";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(116, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reportes";
            // 
            // panelConfig
            // 
            panelConfig.BackColor = Color.White;
            panelConfig.Controls.Add(button2);
            panelConfig.Controls.Add(button1);
            panelConfig.Controls.Add(dateTimePicker2);
            panelConfig.Controls.Add(label5);
            panelConfig.Controls.Add(dateTimePicker1);
            panelConfig.Controls.Add(label3);
            panelConfig.Controls.Add(comboBox1);
            panelConfig.Controls.Add(label4);
            panelConfig.Controls.Add(label2);
            panelConfig.Location = new Point(20, 113);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(787, 220);
            panelConfig.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 73, 94);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(410, 170);
            button2.Name = "button2";
            button2.Size = new Size(350, 35);
            button2.TabIndex = 31;
            button2.Text = "📄 Generar PDF";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 53, 65);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 170);
            button1.Name = "button1";
            button1.Size = new Size(350, 35);
            button1.TabIndex = 30;
            button1.Text = "📊 Generar Reporte";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 10F);
            dateTimePicker2.Location = new Point(410, 130);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(350, 25);
            dateTimePicker2.TabIndex = 29;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(41, 53, 65);
            label5.Location = new Point(410, 100);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 28;
            label5.Text = "Fecha (Hasta)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(30, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 25);
            dateTimePicker1.TabIndex = 27;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(41, 53, 65);
            label3.Location = new Point(30, 100);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 26;
            label3.Text = "Fecha (Desde)";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Semanal", "Mensual", "Anual" });
            comboBox1.Location = new Point(410, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(350, 25);
            comboBox1.TabIndex = 25;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(41, 53, 65);
            label4.Location = new Point(410, 30);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.TabIndex = 24;
            label4.Text = "Tipo de Reporte";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 53, 65);
            label2.Location = new Point(20, 17);
            label2.Name = "label2";
            label2.Size = new Size(206, 25);
            label2.TabIndex = 23;
            label2.Text = "Configurar Reporte";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(236, 240, 241);
            panelStats.Controls.Add(label7);
            panelStats.Controls.Add(label6);
            panelStats.Controls.Add(label8);
            panelStats.Controls.Add(label9);
            panelStats.Controls.Add(label10);
            panelStats.Controls.Add(label11);
            panelStats.Location = new Point(20, 355);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(787, 88);
            panelStats.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(39, 174, 96);
            label7.Location = new Point(20, 42);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 40;
            label7.Text = "$ 500.000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(52, 73, 94);
            label6.Location = new Point(20, 17);
            label6.Name = "label6";
            label6.Size = new Size(93, 19);
            label6.TabIndex = 41;
            label6.Text = "Total Ventas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(39, 174, 96);
            label8.Location = new Point(270, 42);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 42;
            label8.Text = "$ 500.000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(52, 73, 94);
            label9.Location = new Point(270, 17);
            label9.Name = "label9";
            label9.Size = new Size(140, 19);
            label9.TabIndex = 43;
            label9.Text = "Total Reparaciones:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(39, 174, 96);
            label10.Location = new Point(550, 42);
            label10.Name = "label10";
            label10.Size = new Size(115, 25);
            label10.TabIndex = 44;
            label10.Text = "$ 1.000.000";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(52, 73, 94);
            label11.Location = new Point(550, 17);
            label11.Name = "label11";
            label11.Size = new Size(102, 19);
            label11.TabIndex = 45;
            label11.Text = "Total General:";
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dataGridView1);
            panelGrid.Controls.Add(label12);
            panelGrid.Location = new Point(20, 465);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(787, 150);
            panelGrid.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.GridColor = Color.FromArgb(189, 195, 199);
            dataGridView1.Location = new Point(20, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(747, 90);
            dataGridView1.TabIndex = 33;
            // 
            // Column1
            // 
            Column1.HeaderText = "Fecha";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Descripción";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Monto";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(41, 53, 65);
            label12.Location = new Point(20, 17);
            label12.Name = "label12";
            label12.Size = new Size(248, 25);
            label12.TabIndex = 32;
            label12.Text = "Detalles de Transacciones";
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(827, 637);
            Controls.Add(panelGrid);
            Controls.Add(panelStats);
            Controls.Add(panelConfig);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Reportes";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelConfig.ResumeLayout(false);
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelConfig;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label2;
        private Panel panelStats;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panelGrid;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label12;
    }
}