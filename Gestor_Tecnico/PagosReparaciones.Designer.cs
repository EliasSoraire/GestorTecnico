namespace Gestor_Tecnico
{
    partial class PagosReparaciones
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
            dgvReparaciones = new DataGridView();
            colCliente = new DataGridViewTextBoxColumn();
            colEquipo = new DataGridViewTextBoxColumn();
            colPrecioTotal = new DataGridViewTextBoxColumn();
            colTotalPagado = new DataGridViewTextBoxColumn();
            colSaldoRestante = new DataGridViewTextBoxColumn();
            ColSeleccionar = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            lblCliente = new Label();
            lblEquipo = new Label();
            lblMontoTotal = new Label();
            lblTotalPagado = new Label();
            lblSaldo = new Label();
            txtMontoAbonar = new TextBox();
            cmbMedioPago = new ComboBox();
            btnRegistrarPago = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReparaciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReparaciones
            // 
            dgvReparaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReparaciones.Columns.AddRange(new DataGridViewColumn[] { colCliente, colEquipo, colPrecioTotal, colTotalPagado, colSaldoRestante, ColSeleccionar });
            dgvReparaciones.Location = new Point(12, 53);
            dgvReparaciones.Name = "dgvReparaciones";
            dgvReparaciones.RowHeadersWidth = 51;
            dgvReparaciones.Size = new Size(776, 221);
            dgvReparaciones.TabIndex = 0;
            // 
            // colCliente
            // 
            colCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            // 
            // colEquipo
            // 
            colEquipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEquipo.HeaderText = "Equipo";
            colEquipo.MinimumWidth = 6;
            colEquipo.Name = "colEquipo";
            // 
            // colPrecioTotal
            // 
            colPrecioTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrecioTotal.HeaderText = "Precio Total";
            colPrecioTotal.MinimumWidth = 6;
            colPrecioTotal.Name = "colPrecioTotal";
            // 
            // colTotalPagado
            // 
            colTotalPagado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalPagado.HeaderText = "Total Pagado";
            colTotalPagado.MinimumWidth = 6;
            colTotalPagado.Name = "colTotalPagado";
            // 
            // colSaldoRestante
            // 
            colSaldoRestante.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSaldoRestante.HeaderText = "Saldo Restante";
            colSaldoRestante.MinimumWidth = 6;
            colSaldoRestante.Name = "colSaldoRestante";
            // 
            // ColSeleccionar
            // 
            ColSeleccionar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColSeleccionar.HeaderText = "Seleccionar";
            ColSeleccionar.MinimumWidth = 6;
            ColSeleccionar.Name = "ColSeleccionar";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrarPago);
            panel1.Controls.Add(cmbMedioPago);
            panel1.Controls.Add(txtMontoAbonar);
            panel1.Controls.Add(lblSaldo);
            panel1.Controls.Add(lblTotalPagado);
            panel1.Controls.Add(lblMontoTotal);
            panel1.Controls.Add(lblEquipo);
            panel1.Controls.Add(lblCliente);
            panel1.Location = new Point(12, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 271);
            panel1.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(28, 15);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(50, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "label1";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(28, 48);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(50, 20);
            lblEquipo.TabIndex = 1;
            lblEquipo.Text = "label2";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new Point(28, 87);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(50, 20);
            lblMontoTotal.TabIndex = 2;
            lblMontoTotal.Text = "label3";
            // 
            // lblTotalPagado
            // 
            lblTotalPagado.AutoSize = true;
            lblTotalPagado.Location = new Point(28, 116);
            lblTotalPagado.Name = "lblTotalPagado";
            lblTotalPagado.Size = new Size(50, 20);
            lblTotalPagado.TabIndex = 3;
            lblTotalPagado.Text = "label4";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(28, 148);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(50, 20);
            lblSaldo.TabIndex = 4;
            lblSaldo.Text = "label5";
            // 
            // txtMontoAbonar
            // 
            txtMontoAbonar.Location = new Point(41, 183);
            txtMontoAbonar.Name = "txtMontoAbonar";
            txtMontoAbonar.Size = new Size(125, 27);
            txtMontoAbonar.TabIndex = 5;
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(247, 190);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(151, 28);
            cmbMedioPago.TabIndex = 6;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Location = new Point(475, 185);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(94, 29);
            btnRegistrarPago.TabIndex = 7;
            btnRegistrarPago.Text = "button1";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // PagosReparaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(panel1);
            Controls.Add(dgvReparaciones);
            Name = "PagosReparaciones";
            Text = "PagosReparaciones";
            ((System.ComponentModel.ISupportInitialize)dgvReparaciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReparaciones;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colEquipo;
        private DataGridViewTextBoxColumn colPrecioTotal;
        private DataGridViewTextBoxColumn colTotalPagado;
        private DataGridViewTextBoxColumn colSaldoRestante;
        private DataGridViewCheckBoxColumn ColSeleccionar;
        private Panel panel1;
        private Button btnRegistrarPago;
        private ComboBox cmbMedioPago;
        private TextBox txtMontoAbonar;
        private Label lblSaldo;
        private Label lblTotalPagado;
        private Label lblMontoTotal;
        private Label lblEquipo;
        private Label lblCliente;
    }
}