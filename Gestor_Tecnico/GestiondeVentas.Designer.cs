namespace Gestor_Tecnico
{
    partial class GestiondeVentas
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
            label1 = new Label();
            panelMainContent = new Panel();
            panelSalesHistory = new Panel();
            dataGridView3 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewButtonColumn();
            label7 = new Label();
            panelShoppingCart = new Panel();
            button2 = new Button();
            label6 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            label5 = new Label();
            panelProductSearch = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panelHeader.SuspendLayout();
            panelMainContent.SuspendLayout();
            panelSalesHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panelShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelProductSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 53, 65);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(879, 91);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(213, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Administra las ventas del negocio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Ventas";
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(236, 240, 241);
            panelMainContent.Controls.Add(panelSalesHistory);
            panelMainContent.Controls.Add(panelShoppingCart);
            panelMainContent.Controls.Add(panelProductSearch);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(0, 91);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Padding = new Padding(20);
            panelMainContent.Size = new Size(879, 589);
            panelMainContent.TabIndex = 1;
            // 
            // panelSalesHistory
            // 
            panelSalesHistory.BackColor = Color.White;
            panelSalesHistory.Controls.Add(dataGridView3);
            panelSalesHistory.Controls.Add(label7);
            panelSalesHistory.Dock = DockStyle.Fill;
            panelSalesHistory.Location = new Point(20, 400);
            panelSalesHistory.Margin = new Padding(0, 20, 0, 0);
            panelSalesHistory.Name = "panelSalesHistory";
            panelSalesHistory.Padding = new Padding(20);
            panelSalesHistory.Size = new Size(839, 169);
            panelSalesHistory.TabIndex = 2;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column5, Column7, Column8, Column9 });
            dataGridView3.Location = new Point(20, 55);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.Size = new Size(771, 54);
            dataGridView3.TabIndex = 1;
            // 
            // Column5
            // 
            Column5.HeaderText = "Fecha";
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Productos";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Total";
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "PDF";
            Column9.Name = "Column9";
            Column9.Width = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(41, 53, 65);
            label7.Location = new Point(20, 20);
            label7.Name = "label7";
            label7.Size = new Size(178, 25);
            label7.TabIndex = 0;
            label7.Text = "Historial de Ventas";
            // 
            // panelShoppingCart
            // 
            panelShoppingCart.BackColor = Color.White;
            panelShoppingCart.Controls.Add(label6);
            panelShoppingCart.Controls.Add(label3);
            panelShoppingCart.Controls.Add(button2);
            panelShoppingCart.Controls.Add(dataGridView2);
            panelShoppingCart.Controls.Add(label5);
            panelShoppingCart.Dock = DockStyle.Top;
            panelShoppingCart.Location = new Point(20, 220);
            panelShoppingCart.Margin = new Padding(0, 20, 0, 0);
            panelShoppingCart.Name = "panelShoppingCart";
            panelShoppingCart.Padding = new Padding(20);
            panelShoppingCart.Size = new Size(839, 180);
            panelShoppingCart.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(39, 174, 96);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(651, 133);
            button2.Name = "button2";
            button2.Size = new Size(140, 35);
            button2.TabIndex = 2;
            button2.Text = "💳 Finalizar Venta";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(39, 174, 96);
            label6.Location = new Point(556, 139);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 1;
            label6.Text = "$0,00";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(100, 85, 66);
            label3.Location = new Point(500, 139);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 0;
            label3.Text = "Total:";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column3 });
            dataGridView2.Location = new Point(20, 55);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(771, 80);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Producto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Precio";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "Subtotal";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 81;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quitar";
            Column3.Name = "Column3";
            Column3.Width = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(41, 53, 65);
            label5.Location = new Point(20, 20);
            label5.Name = "label5";
            label5.Size = new Size(185, 25);
            label5.TabIndex = 0;
            label5.Text = "Carrito de Compras";
            // 
            // panelProductSearch
            // 
            panelProductSearch.BackColor = Color.White;
            panelProductSearch.Controls.Add(dataGridView1);
            panelProductSearch.Controls.Add(button1);
            panelProductSearch.Controls.Add(textBox4);
            panelProductSearch.Controls.Add(label4);
            panelProductSearch.Controls.Add(label2);
            panelProductSearch.Dock = DockStyle.Top;
            panelProductSearch.Location = new Point(20, 20);
            panelProductSearch.Name = "panelProductSearch";
            panelProductSearch.Padding = new Padding(20);
            panelProductSearch.Size = new Size(839, 200);
            panelProductSearch.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column6 });
            dataGridView1.Location = new Point(20, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(771, 55);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Producto";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Precio";
            Column2.Name = "Column2";
            Column2.Width = 69;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Stock";
            Column4.Name = "Column4";
            Column4.Width = 64;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Acciones";
            Column6.Name = "Column6";
            Column6.Width = 84;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(52, 73, 94);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(671, 74);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 3;
            button1.Text = "🔍 Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 10F);
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(20, 80);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Buscar por nombre o modelo...";
            textBox4.Size = new Size(619, 25);
            textBox4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(100, 85, 66);
            label4.Location = new Point(20, 55);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 1;
            label4.Text = "Buscar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 53, 65);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 0;
            label2.Text = "Nueva Venta";
            // 
            // GestiondeVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(879, 680);
            Controls.Add(panelMainContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GestiondeVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Ventas";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMainContent.ResumeLayout(false);
            panelSalesHistory.ResumeLayout(false);
            panelSalesHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panelShoppingCart.ResumeLayout(false);
            panelShoppingCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelProductSearch.ResumeLayout(false);
            panelProductSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Header components
        private Panel panelHeader;
        private Label label1;
        private Label lblSubtitle;

        // Main content
        private Panel panelMainContent;

        // Product search section
        private Panel panelProductSearch;
        private Label label2;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;

        // Shopping cart section
        private Panel panelShoppingCart;
        private Label label5;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn Column3;
        private Label label3;
        private Label label6;
        private Button button2;

        // Sales history section
        private Panel panelSalesHistory;
        private Label label7;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewButtonColumn Column9;
    }
}