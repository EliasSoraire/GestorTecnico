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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            label1 = new Label();
            panelNavigation = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelContent = new Panel();
            label2 = new Label();
            btnAgregarProducto = new Button();
            txtBuscarProducto = new TextBox();
            dgvStock = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelNavigation.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 53, 65);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1050, 77);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestor Técnico";
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.FromArgb(52, 73, 94);
            panelNavigation.Controls.Add(button1);
            panelNavigation.Controls.Add(button2);
            panelNavigation.Controls.Add(button3);
            panelNavigation.Controls.Add(button4);
            panelNavigation.Dock = DockStyle.Left;
            panelNavigation.Location = new Point(0, 77);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(192, 501);
            panelNavigation.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 73, 94);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(13, 0, 0, 0);
            button1.Size = new Size(192, 51);
            button1.TabIndex = 0;
            button1.Text = "🔧 Reparaciones";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 73, 94);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 51);
            button2.Name = "button2";
            button2.Padding = new Padding(13, 0, 0, 0);
            button2.Size = new Size(192, 51);
            button2.TabIndex = 1;
            button2.Text = "💰 Ventas";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(52, 73, 94);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 102);
            button3.Name = "button3";
            button3.Padding = new Padding(13, 0, 0, 0);
            button3.Size = new Size(192, 51);
            button3.TabIndex = 2;
            button3.Text = "👥 Clientes";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(52, 73, 94);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 153);
            button4.Name = "button4";
            button4.Padding = new Padding(13, 0, 0, 0);
            button4.Size = new Size(192, 51);
            button4.TabIndex = 3;
            button4.Text = "📊 Reportes";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(236, 240, 241);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(btnAgregarProducto);
            panelContent.Controls.Add(txtBuscarProducto);
            panelContent.Controls.Add(dgvStock);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(192, 77);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(18, 17, 18, 17);
            panelContent.Size = new Size(858, 501);
            panelContent.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 53, 65);
            label2.Location = new Point(18, 17);
            label2.Name = "label2";
            label2.Size = new Size(185, 30);
            label2.TabIndex = 0;
            label2.Text = "Stock/Productos";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(39, 174, 96);
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(18, 60);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(131, 34);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "➕ Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarProducto.Font = new Font("Segoe UI", 10F);
            txtBuscarProducto.ForeColor = Color.FromArgb(108, 117, 125);
            txtBuscarProducto.Location = new Point(639, 64);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PlaceholderText = "Buscar Producto...";
            txtBuscarProducto.Size = new Size(202, 25);
            txtBuscarProducto.TabIndex = 2;
            // 
            // dgvStock
            // 
            dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStock.BackgroundColor = Color.White;
            dgvStock.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { colNombre, colModelo, colTipo, colStock, colPrecio, colAcciones });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 220, 220);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStock.GridColor = Color.FromArgb(200, 200, 200);
            dgvStock.Location = new Point(18, 110);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersVisible = false;
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(822, 373);
            dgvStock.TabIndex = 3;
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
            colAcciones.Resizable = DataGridViewTriState.True;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1050, 578);
            Controls.Add(panelContent);
            Controls.Add(panelNavigation);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor Técnico - Panel Principal";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavigation.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Panel panelNavigation;
        private Panel panelContent;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private DataGridView dgvStock;
        private TextBox txtBuscarProducto;
        private Button btnAgregarProducto;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colAcciones;
    }
}