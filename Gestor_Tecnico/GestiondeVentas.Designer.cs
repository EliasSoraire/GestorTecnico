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
            panelEncabezado = new Panel();
            lblTitulo = new Label();
            panelContenidoPrincipal = new Panel();
            panelHistorialVentas = new Panel();
            lblHistorialVentas = new Label();
            btnGenerarPDF = new Button();
            dgvHistorialVentas = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colNombreProducto = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colCantidadHistorial = new DataGridViewTextBoxColumn();
            colMetodoPago = new DataGridViewTextBoxColumn();
            panelNuevaVenta = new Panel();
            lblNuevaVenta = new Label();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblCantidad = new Label();
            numCantidad = new NumericUpDown();
            btnAgregarProducto = new Button();
            dgvCarrito = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colQuitar = new DataGridViewButtonColumn();
            lblMetodoPago = new Label();
            cmbMetodoPago = new ComboBox();
            lblTotal = new Label();
            lblMontoTotal = new Label();
            btnFinalizarVenta = new Button();
            panelEncabezado.SuspendLayout();
            panelContenidoPrincipal.SuspendLayout();
            panelHistorialVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).BeginInit();
            panelNuevaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.BackColor = Color.FromArgb(41, 53, 65);
            panelEncabezado.Controls.Add(lblTitulo);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(900, 60);
            panelEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Ventas";
            // 
            // panelContenidoPrincipal
            // 
            panelContenidoPrincipal.BackColor = Color.FromArgb(236, 240, 241);
            panelContenidoPrincipal.Controls.Add(panelHistorialVentas);
            panelContenidoPrincipal.Controls.Add(panelNuevaVenta);
            panelContenidoPrincipal.Dock = DockStyle.Fill;
            panelContenidoPrincipal.Location = new Point(0, 60);
            panelContenidoPrincipal.Name = "panelContenidoPrincipal";
            panelContenidoPrincipal.Padding = new Padding(20);
            panelContenidoPrincipal.Size = new Size(900, 640);
            panelContenidoPrincipal.TabIndex = 1;
            // 
            // panelHistorialVentas
            // 
            panelHistorialVentas.BackColor = Color.White;
            panelHistorialVentas.Controls.Add(lblHistorialVentas);
            panelHistorialVentas.Controls.Add(btnGenerarPDF);
            panelHistorialVentas.Controls.Add(dgvHistorialVentas);
            panelHistorialVentas.Dock = DockStyle.Fill;
            panelHistorialVentas.Location = new Point(20, 390);
            panelHistorialVentas.Margin = new Padding(0, 20, 0, 0);
            panelHistorialVentas.Name = "panelHistorialVentas";
            panelHistorialVentas.Padding = new Padding(20);
            panelHistorialVentas.Size = new Size(860, 230);
            panelHistorialVentas.TabIndex = 1;
            // 
            // lblHistorialVentas
            // 
            lblHistorialVentas.AutoSize = true;
            lblHistorialVentas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHistorialVentas.ForeColor = Color.FromArgb(41, 53, 65);
            lblHistorialVentas.Location = new Point(20, 20);
            lblHistorialVentas.Name = "lblHistorialVentas";
            lblHistorialVentas.Size = new Size(178, 25);
            lblHistorialVentas.TabIndex = 0;
            lblHistorialVentas.Text = "Historial de Ventas";
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.BackColor = Color.FromArgb(192, 57, 43);
            btnGenerarPDF.FlatAppearance.BorderSize = 0;
            btnGenerarPDF.FlatStyle = FlatStyle.Flat;
            btnGenerarPDF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerarPDF.ForeColor = Color.White;
            btnGenerarPDF.Location = new Point(720, 19);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(120, 30);
            btnGenerarPDF.TabIndex = 2;
            btnGenerarPDF.Text = "📄 Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            // 
            // dgvHistorialVentas
            // 
            dgvHistorialVentas.BackgroundColor = Color.White;
            dgvHistorialVentas.BorderStyle = BorderStyle.None;
            dgvHistorialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialVentas.Columns.AddRange(new DataGridViewColumn[] { colFecha, colNombreProducto, colModelo, colCantidadHistorial, colMetodoPago });
            dgvHistorialVentas.Location = new Point(23, 55);
            dgvHistorialVentas.Name = "dgvHistorialVentas";
            dgvHistorialVentas.RowHeadersVisible = false;
            dgvHistorialVentas.Size = new Size(817, 155);
            dgvHistorialVentas.TabIndex = 1;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.Width = 125;
            // 
            // colNombreProducto
            // 
            colNombreProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombreProducto.HeaderText = "Producto";
            colNombreProducto.Name = "colNombreProducto";
            colNombreProducto.ReadOnly = true;
            // 
            // colModelo
            // 
            colModelo.HeaderText = "Modelo";
            colModelo.Name = "colModelo";
            colModelo.ReadOnly = true;
            colModelo.Width = 120;
            // 
            // colCantidadHistorial
            // 
            colCantidadHistorial.HeaderText = "Cantidad";
            colCantidadHistorial.Name = "colCantidadHistorial";
            colCantidadHistorial.ReadOnly = true;
            colCantidadHistorial.Width = 80;
            // 
            // colMetodoPago
            // 
            colMetodoPago.HeaderText = "Método de Pago";
            colMetodoPago.Name = "colMetodoPago";
            colMetodoPago.ReadOnly = true;
            colMetodoPago.Width = 130;
            // 
            // panelNuevaVenta
            // 
            panelNuevaVenta.BackColor = Color.White;
            panelNuevaVenta.Controls.Add(lblNuevaVenta);
            panelNuevaVenta.Controls.Add(lblProducto);
            panelNuevaVenta.Controls.Add(cmbProducto);
            panelNuevaVenta.Controls.Add(lblCantidad);
            panelNuevaVenta.Controls.Add(numCantidad);
            panelNuevaVenta.Controls.Add(btnAgregarProducto);
            panelNuevaVenta.Controls.Add(dgvCarrito);
            panelNuevaVenta.Controls.Add(lblMetodoPago);
            panelNuevaVenta.Controls.Add(cmbMetodoPago);
            panelNuevaVenta.Controls.Add(lblTotal);
            panelNuevaVenta.Controls.Add(lblMontoTotal);
            panelNuevaVenta.Controls.Add(btnFinalizarVenta);
            panelNuevaVenta.Dock = DockStyle.Top;
            panelNuevaVenta.Location = new Point(20, 20);
            panelNuevaVenta.Name = "panelNuevaVenta";
            panelNuevaVenta.Padding = new Padding(20);
            panelNuevaVenta.Size = new Size(860, 370);
            panelNuevaVenta.TabIndex = 0;
            // 
            // lblNuevaVenta
            // 
            lblNuevaVenta.AutoSize = true;
            lblNuevaVenta.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNuevaVenta.ForeColor = Color.FromArgb(41, 53, 65);
            lblNuevaVenta.Location = new Point(20, 20);
            lblNuevaVenta.Name = "lblNuevaVenta";
            lblNuevaVenta.Size = new Size(125, 25);
            lblNuevaVenta.TabIndex = 0;
            lblNuevaVenta.Text = "Nueva Venta";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10F);
            lblProducto.ForeColor = Color.FromArgb(100, 85, 66);
            lblProducto.Location = new Point(20, 60);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(68, 19);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Font = new Font("Segoe UI", 10F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(20, 85);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(350, 25);
            cmbProducto.TabIndex = 2;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F);
            lblCantidad.ForeColor = Color.FromArgb(100, 85, 66);
            lblCantidad.Location = new Point(390, 60);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(67, 19);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            numCantidad.Font = new Font("Segoe UI", 10F);
            numCantidad.Location = new Point(390, 85);
            numCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(80, 25);
            numCantidad.TabIndex = 4;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(52, 73, 94);
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(490, 85);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(100, 25);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "➕ Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // dgvCarrito
            // 
            dgvCarrito.BackgroundColor = Color.White;
            dgvCarrito.BorderStyle = BorderStyle.None;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { colProducto, colPrecio, colCantidad, colSubtotal, colQuitar });
            dgvCarrito.Location = new Point(20, 130);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.Size = new Size(820, 130);
            dgvCarrito.TabIndex = 6;
            // 
            // colProducto
            // 
            colProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 69;
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 85;
            // 
            // colSubtotal
            // 
            colSubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            colSubtotal.Width = 81;
            // 
            // colQuitar
            // 
            colQuitar.HeaderText = "Quitar";
            colQuitar.Name = "colQuitar";
            colQuitar.Width = 80;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 10F);
            lblMetodoPago.ForeColor = Color.FromArgb(100, 85, 66);
            lblMetodoPago.Location = new Point(20, 275);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(118, 19);
            lblMetodoPago.TabIndex = 7;
            lblMetodoPago.Text = "Método de Pago:";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.Font = new Font("Segoe UI", 10F);
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Débito",
            "Tarjeta de Crédito",
            "Transferencia Bancaria",
            "Mercado Pago",
            "Cheque",
            "Cuenta Corriente"});
            cmbMetodoPago.Location = new Point(150, 275);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(200, 25);
            cmbMetodoPago.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(41, 53, 65);
            lblTotal.Location = new Point(650, 315);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 21);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total:";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMontoTotal.ForeColor = Color.FromArgb(39, 174, 96);
            lblMontoTotal.Location = new Point(710, 315);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(50, 21);
            lblMontoTotal.TabIndex = 10;
            lblMontoTotal.Text = "$0,00";
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.BackColor = Color.FromArgb(39, 174, 96);
            btnFinalizarVenta.FlatAppearance.BorderSize = 0;
            btnFinalizarVenta.FlatStyle = FlatStyle.Flat;
            btnFinalizarVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFinalizarVenta.ForeColor = Color.White;
            btnFinalizarVenta.Location = new Point(20, 310);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(140, 35);
            btnFinalizarVenta.TabIndex = 11;
            btnFinalizarVenta.Text = "💳 Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            // 
            // GestiondeVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(900, 700);
            Controls.Add(panelContenidoPrincipal);
            Controls.Add(panelEncabezado);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GestiondeVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Ventas";
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panelContenidoPrincipal.ResumeLayout(false);
            panelHistorialVentas.ResumeLayout(false);
            panelHistorialVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).EndInit();
            panelNuevaVenta.ResumeLayout(false);
            panelNuevaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Componentes del encabezado
        private Panel panelEncabezado;
        private Label lblTitulo;

        // Contenido principal
        private Panel panelContenidoPrincipal;

        // Sección nueva venta
        private Panel panelNuevaVenta;
        private Label lblNuevaVenta;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblCantidad;
        private NumericUpDown numCantidad;
        private Button btnAgregarProducto;
        private DataGridView dgvCarrito;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewButtonColumn colQuitar;
        private Label lblMetodoPago;
        private ComboBox cmbMetodoPago;
        private Label lblTotal;
        private Label lblMontoTotal;
        private Button btnFinalizarVenta;

        // Sección historial de ventas
        private Panel panelHistorialVentas;
        private Label lblHistorialVentas;
        private Button btnGenerarPDF;
        private DataGridView dgvHistorialVentas;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colNombreProducto;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colCantidadHistorial;
        private DataGridViewTextBoxColumn colMetodoPago;
    }
}