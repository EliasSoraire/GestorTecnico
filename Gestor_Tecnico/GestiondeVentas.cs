using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Gestor_Tecnico
{
    public partial class GestiondeVentas : Form
    {
        private ConexionSQL conexionSQL;
        private List<ProductoCarrito> carrito;
        private decimal totalVenta = 0;

        public GestiondeVentas()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();
            carrito = new List<ProductoCarrito>();
            ConfigurarEventos();
            CargarProductos();
            CargarMediosPago();
            CargarHistorialVentas();
            ConfigurarDataGridView();
        }

        private void ConfigurarEventos()
        {
            btnAgregarProducto.Click += BtnAgregarProducto_Click;
            btnFinalizarVenta.Click += BtnFinalizarVenta_Click;
            btnGenerarPDF.Click += BtnGenerarPDF_Click;
            dgvCarrito.CellClick += DgvCarrito_CellClick;
            cmbProducto.SelectedIndexChanged += CmbProducto_SelectedIndexChanged;
        }

        private void ConfigurarDataGridView()
        {
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.ReadOnly = true;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvHistorialVentas.AllowUserToAddRows = false;
            dgvHistorialVentas.ReadOnly = true;
            dgvHistorialVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"SELECT p.idProducto, p.Nombre, p.Modelo, p.PrecioVenta, p.Stock, tp.Descripcion as TipoProducto
                                       FROM Producto p 
                                       INNER JOIN TiposProducto tp ON p.idTipoProducto = tp.idTipoProducto
                                       WHERE p.Stock > 0
                                       ORDER BY p.Nombre";

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        SqlDataReader reader = cmd.ExecuteReader();

                        cmbProducto.Items.Clear();
                        cmbProducto.ValueMember = "idProducto";
                        cmbProducto.DisplayMember = "DisplayText";

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        foreach (DataRow row in dt.Rows)
                        {
                            var producto = new
                            {
                                idProducto = Convert.ToInt32(row["idProducto"]),
                                DisplayText = $"{row["Nombre"]} - {row["Modelo"]} ({row["TipoProducto"]}) - Stock: {row["Stock"]} - ${row["PrecioVenta"]:F2}",
                                Nombre = row["Nombre"].ToString(),
                                Modelo = row["Modelo"].ToString(),
                                PrecioVenta = Convert.ToDecimal(row["PrecioVenta"]),
                                Stock = Convert.ToInt32(row["Stock"])
                            };
                            cmbProducto.Items.Add(producto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMediosPago()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = "SELECT idMedioPago, Descripcion FROM MediosPago ORDER BY Descripcion";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        SqlDataReader reader = cmd.ExecuteReader();

                        cmbMetodoPago.Items.Clear();
                        cmbMetodoPago.ValueMember = "idMedioPago";
                        cmbMetodoPago.DisplayMember = "Descripcion";

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        foreach (DataRow row in dt.Rows)
                        {
                            var medioPago = new
                            {
                                idMedioPago = Convert.ToInt32(row["idMedioPago"]),
                                Descripcion = row["Descripcion"].ToString()
                            };
                            cmbMetodoPago.Items.Add(medioPago);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar medios de pago: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorialVentas()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"SELECT DISTINCT v.FechaVenta, p.Nombre + ' - ' + p.Modelo as Producto, 
                                       dv.Cantidad, mp.Descripcion as MetodoPago, v.MontoTotal
                                       FROM Ventas v
                                       INNER JOIN DetalleVenta dv ON v.idVenta = dv.idVenta
                                       INNER JOIN Producto p ON dv.idProducto = p.idProducto
                                       INNER JOIN MediosPago mp ON v.idMedioPago = mp.idMedioPago
                                       ORDER BY v.FechaVenta DESC";

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvHistorialVentas.Rows.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            dgvHistorialVentas.Rows.Add(
                                Convert.ToDateTime(row["FechaVenta"]).ToString("dd/MM/yyyy"),
                                row["Producto"].ToString(),
                                "", // Modelo ya incluido en Producto
                                row["Cantidad"].ToString(),
                                row["MetodoPago"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar historial: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem != null)
            {
                dynamic producto = cmbProducto.SelectedItem;
                numCantidad.Maximum = producto.Stock;
                numCantidad.Value = 1;
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dynamic productoSeleccionado = cmbProducto.SelectedItem;
            int cantidad = (int)numCantidad.Value;

            var productoEnCarrito = carrito.FirstOrDefault(p => p.IdProducto == productoSeleccionado.idProducto);
            int cantidadEnCarrito = productoEnCarrito?.Cantidad ?? 0;

            if (cantidadEnCarrito + cantidad > productoSeleccionado.Stock)
            {
                MessageBox.Show($"No hay suficiente stock. Disponible: {productoSeleccionado.Stock}, En carrito: {cantidadEnCarrito}",
                               "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productoEnCarrito != null)
            {
                productoEnCarrito.Cantidad += cantidad;
                productoEnCarrito.Subtotal = productoEnCarrito.Cantidad * productoEnCarrito.PrecioUnitario;
            }
            else
            {
                var nuevoProducto = new ProductoCarrito
                {
                    IdProducto = productoSeleccionado.idProducto,
                    Nombre = $"{productoSeleccionado.Nombre} - {productoSeleccionado.Modelo}",
                    PrecioUnitario = productoSeleccionado.PrecioVenta,
                    Cantidad = cantidad,
                    Subtotal = productoSeleccionado.PrecioVenta * cantidad
                };
                carrito.Add(nuevoProducto);
            }

            ActualizarCarrito();
            CalcularTotal();

            cmbProducto.SelectedIndex = -1;
            numCantidad.Value = 1;
        }

        private void ActualizarCarrito()
        {
            dgvCarrito.Rows.Clear();
            foreach (var producto in carrito)
            {
                dgvCarrito.Rows.Add(
                    producto.Nombre,
                    $"${producto.PrecioUnitario:F2}",
                    producto.Cantidad,
                    $"${producto.Subtotal:F2}",
                    "Quitar"
                );
            }
        }

        private void CalcularTotal()
        {
            totalVenta = carrito.Sum(p => p.Subtotal);
            lblMontoTotal.Text = $"${totalVenta:F2}";
        }

        private void DgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCarrito.Columns["colQuitar"].Index)
            {
                if (MessageBox.Show("¿Está seguro de quitar este producto del carrito?", "Confirmar",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    carrito.RemoveAt(e.RowIndex);
                    ActualizarCarrito();
                    CalcularTotal();
                }
            }
        }

        private void BtnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMetodoPago.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un método de pago.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarStockDisponible())
            {
                MessageBox.Show("No hay suficiente stock para algunos productos. Verifique el carrito.",
                               "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"¿Confirmar venta por ${totalVenta:F2}?", "Confirmar Venta",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProcesarVenta();
            }
        }

        private bool ValidarStockDisponible()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        foreach (var producto in carrito)
                        {
                            string query = "SELECT Stock FROM Producto WHERE idProducto = @idProducto";
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@idProducto", producto.IdProducto);

                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                int stockActual = Convert.ToInt32(result);
                                if (stockActual < producto.Cantidad)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        // ... [todo el código previo queda igual hasta ProcesarVenta()]

        private void ProcesarVenta()
        {
            SqlTransaction transaction = null;
            SqlConnection conexion = null;

            try
            {
                conexion = conexionSQL.ObtenerConexion();
                if (conexion != null)
                {
                    transaction = conexion.BeginTransaction();

                    string queryVenta = @"INSERT INTO Ventas (FechaVenta, idMedioPago, MontoTotal) 
                            OUTPUT INSERTED.idVenta 
                            VALUES (@FechaVenta, @idMedioPago, @MontoTotal)";

                    SqlCommand cmdVenta = new SqlCommand(queryVenta, conexion, transaction);
                    cmdVenta.Parameters.AddWithValue("@FechaVenta", DateTime.Now);
                    cmdVenta.Parameters.AddWithValue("@idMedioPago", ((dynamic)cmbMetodoPago.SelectedItem).idMedioPago);
                    cmdVenta.Parameters.AddWithValue("@MontoTotal", totalVenta);

                    int idVenta = (int)cmdVenta.ExecuteScalar();

                    foreach (var producto in carrito)
                    {
                        string queryDetalle = @"INSERT INTO DetalleVenta (idVenta, idProducto, Cantidad, PrecioUnitario, SubTotal) 
                               VALUES (@idVenta, @idProducto, @Cantidad, @PrecioUnitario, @SubTotal)";

                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, transaction);
                        cmdDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                        cmdDetalle.Parameters.AddWithValue("@idProducto", producto.IdProducto);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
                        cmdDetalle.Parameters.AddWithValue("@SubTotal", producto.Subtotal);
                        cmdDetalle.ExecuteNonQuery();

                        string queryStock = "UPDATE Producto SET Stock = Stock - @Cantidad WHERE idProducto = @idProducto";
                        SqlCommand cmdStock = new SqlCommand(queryStock, conexion, transaction);
                        cmdStock.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                        cmdStock.Parameters.AddWithValue("@idProducto", producto.IdProducto);
                        cmdStock.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    // IMPORTANTE: Cerrar la conexión antes de generar el ticket
                    conexion.Close();
                    conexion.Dispose();

                    var resultado = MessageBox.Show($"Venta registrada exitosamente.\nNúmero de venta: {idVenta}\n\n¿Desea generar el ticket de esta venta?",
                        "Venta Completada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (resultado == DialogResult.Yes)
                    {
                        // Esperar un momento para asegurar que la conexión se cierre completamente
                        System.Threading.Thread.Sleep(100);
                        GenerarTicketPDF(idVenta);
                    }

                    LimpiarFormulario();
                    CargarProductos();
                    CargarHistorialVentas();
                }
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show($"Error al procesar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurar que la conexión se cierre en el bloque finally
                transaction?.Dispose();
                conexion?.Close();
                conexion?.Dispose();
            }
        }

        private void GenerarTicketPDF(int idVenta)
        {
            try
            {
                DataTable ventaInfo = new DataTable();
                DataTable detalleInfo = new DataTable();

                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    string queryVenta = @"
                SELECT v.FechaVenta, v.MontoTotal, m.Descripcion as MedioPago
                FROM Ventas v
                JOIN MediosPago m ON v.idMedioPago = m.idMedioPago
                WHERE v.idVenta = @idVenta";

                    using (SqlCommand cmd = new SqlCommand(queryVenta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idVenta", idVenta);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(ventaInfo);
                        }
                    }

                    string queryDetalles = @"
                SELECT p.Nombre, p.Modelo, dv.Cantidad, dv.PrecioUnitario, dv.SubTotal
                FROM DetalleVenta dv
                JOIN Producto p ON dv.idProducto = p.idProducto
                WHERE dv.idVenta = @idVenta";

                    using (SqlCommand cmd = new SqlCommand(queryDetalles, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idVenta", idVenta);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(detalleInfo);
                        }
                    }
                }

                if (ventaInfo.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos de la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string nombreArchivo = $"Ticket_Venta_{idVenta}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string rutaCompleta = Path.Combine(path, nombreArchivo);

                using (var doc = new iTextSharp.text.Document())
                {
                    iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(rutaCompleta, FileMode.Create));
                    doc.Open();

                    for (int i = 0; i < 2; i++)
                    {
                        doc.Add(new Paragraph("TICKET DE VENTA") { Alignment = Element.ALIGN_CENTER });
                        doc.Add(new Paragraph("----------------------------------------------"));
                        doc.Add(new Paragraph($"Nº Venta: {idVenta}"));
                        doc.Add(new Paragraph($"Fecha: {Convert.ToDateTime(ventaInfo.Rows[0]["FechaVenta"]):dd/MM/yyyy HH:mm}"));
                        doc.Add(new Paragraph($"Medio de Pago: {ventaInfo.Rows[0]["MedioPago"]}"));
                        doc.Add(new Paragraph(" "));

                        PdfPTable tabla = new PdfPTable(4);
                        tabla.WidthPercentage = 100;
                        tabla.SetWidths(new float[] { 4, 1, 2, 2 });
                        tabla.AddCell("Producto");
                        tabla.AddCell("Cant");
                        tabla.AddCell("Precio");
                        tabla.AddCell("Subtotal");

                        foreach (DataRow row in detalleInfo.Rows)
                        {
                            string nombre = row["Nombre"].ToString();
                            string modelo = row["Modelo"].ToString();
                            int cantidad = Convert.ToInt32(row["Cantidad"]);
                            decimal precio = Convert.ToDecimal(row["PrecioUnitario"]);
                            decimal subtotal = Convert.ToDecimal(row["SubTotal"]);

                            tabla.AddCell($"{nombre} {modelo}");
                            tabla.AddCell(cantidad.ToString());
                            tabla.AddCell(precio.ToString("C2"));
                            tabla.AddCell(subtotal.ToString("C2"));
                        }

                        doc.Add(tabla);
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph($"TOTAL: {Convert.ToDecimal(ventaInfo.Rows[0]["MontoTotal"]):C2}"));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph("Gracias por su compra!") { Alignment = Element.ALIGN_CENTER });

                        // Agregar línea de corte entre los tickets
                        if (i == 0)
                        {
                            doc.Add(new Paragraph("\n\n-------------------------- CORTAR AQUÍ --------------------------\n\n")
                            {
                                Alignment = Element.ALIGN_CENTER,
                                SpacingBefore = 10,
                                SpacingAfter = 10
                            });
                        }
                    }


                    doc.Close();
                }

                var abrir = MessageBox.Show($"Ticket PDF generado en el escritorio:\n{nombreArchivo}\n\u00bfDesea abrirlo?", "PDF generado", MessageBoxButtons.YesNo);
                if (abrir == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = rutaCompleta,
                        UseShellExecute = true
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método adicional para validar la conexión antes de usarla
        private bool ValidarConexion()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        if (conexion.State != ConnectionState.Open)
                        {
                            conexion.Open();
                        }
                        return conexion.State == ConnectionState.Open;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }








        private void LimpiarFormulario()
        {
            carrito.Clear();
            ActualizarCarrito();
            totalVenta = 0;
            lblMontoTotal.Text = "$0,00";
            cmbProducto.SelectedIndex = -1;
            cmbMetodoPago.SelectedIndex = -1;
            numCantidad.Value = 1;
        }

        private void BtnGenerarPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de PDF no implementada en este ejemplo.", "Información",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class ProductoCarrito
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }


}