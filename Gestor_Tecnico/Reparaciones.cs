using iTextSharp.text;
using iTextSharp.text.pdf; // ← AGREGAR ESTA LÍNEA
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;

namespace Gestor_Tecnico
{
    public partial class Reparaciones : Form
    {
        private string rutaImagenSeleccionada = string.Empty;

        public Reparaciones()
        {
            InitializeComponent();
            CargarFiltroEstados();
            cbEstado.SelectedIndexChanged += (s, e) => CargarReparacionesEnDGV();
            this.Load += Reparaciones_Load;
            dgvReparaciones.CellClick += dgvReparaciones_CellClick;
        }
        private void Reparaciones_Load(object sender, EventArgs e)
        {
            try
            {
                using var prueba = new ConexionSQL().ObtenerConexion();
            }
            catch
            {
                this.Enabled = false;
                return;
            }

            CargarCombos();
            CargarReparacionesEnDGV();
        }
        private void btnImagen_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    rutaImagenSeleccionada = ofd.FileName;
            }
        }

        private void btnGuardarReparacion_Click(object sender, EventArgs e)
        {
            if (cbDniCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccioná un DNI de cliente.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDniCliente.Focus();
                return;
            }
            if (cbTipoEquipo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccioná un tipo de equipo.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTipoEquipo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("El campo Modelo es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("El campo Descripción es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }
            if (!decimal.TryParse(txtPresupuesto.Text.Trim(), out var presupuesto) || presupuesto <= 0)
            {
                MessageBox.Show("El Presupuesto debe ser un número mayor que cero.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPresupuesto.Focus();
                return;
            }

            if (cbMedioPago.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccioná un medio de pago.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMedioPago.Focus();
                return;
            }

            if (dtpFechaIngreso.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La Fecha de Ingreso no puede ser posterior a hoy.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaIngreso.Focus();
                return;
            }

            // VERIFICACIÓN DE CONEXIÓN + OBTENER idCliente DESDE DNI
            int idCliente;
            try
            {
                using (var cn = new ConexionSQL().ObtenerConexion())
                using (var cmd = new SqlCommand("SELECT idCliente FROM Cliente WHERE DNI = @dni", cn))
                {
                    cmd.Parameters.AddWithValue("@dni", cbDniCliente.SelectedValue);
                    var result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("El DNI seleccionado no existe.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    idCliente = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}", "Error de conexión",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idReparacion;
            using (var cn = new ConexionSQL().ObtenerConexion())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    string sqlRep = @"
                INSERT INTO Reparaciones
                  (idCliente, idTipoEquipo, Modelo, DescripcionProblema,
                   PresupuestoEstimado, FechaIngreso, idEstado, MontoTotal)
                VALUES
                  (@cli, @tipo, @mod, @desc, @pres, @ing, @est, @monto);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    using (var cmd = new SqlCommand(sqlRep, cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@cli", idCliente);
                        cmd.Parameters.AddWithValue("@tipo", cbTipoEquipo.SelectedValue);
                        cmd.Parameters.AddWithValue("@mod", txtModelo.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@pres", presupuesto);
                        cmd.Parameters.AddWithValue("@ing", dtpFechaIngreso.Value.Date);
                        cmd.Parameters.AddWithValue("@est", 1);
                        cmd.Parameters.AddWithValue("@monto", presupuesto);
                        idReparacion = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string sqlPago = @"
                INSERT INTO PagosReparacion
                  (idReparacion, idMedioPago, Monto, FechaPago)
                VALUES
                  (@rep, @mp, @monto, @fpago);";
                    using (var cmd = new SqlCommand(sqlPago, cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@rep", idReparacion);
                        cmd.Parameters.AddWithValue("@mp", cbMedioPago.SelectedValue);
                        cmd.Parameters.AddWithValue("@monto", presupuesto);
                        cmd.Parameters.AddWithValue("@fpago", dtpFechaIngreso.Value.Date);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }

            GenerarPDFReparacion(idReparacion);

            CargarReparacionesEnDGV();
            LimpiarFormulario();
        }
        private void txtPresupuesto_Leave(object sender, EventArgs e)
        {
            var raw = txtPresupuesto.Text.Trim().Replace(',', '.');
            if (decimal.TryParse(raw, NumberStyles.AllowDecimalPoint,
                                 CultureInfo.InvariantCulture, out var val))
            {
                // Formato regional: 2 decimales, separador de miles
                txtPresupuesto.Text = val.ToString("N2", CultureInfo.CurrentCulture);
            }
        }

        private void LimpiarFormulario()
        {
            cbDniCliente.SelectedIndex = -1;
            cbTipoEquipo.SelectedIndex = -1;
            cbMedioPago.SelectedIndex = -1;
            txtModelo.Clear();
            txtDescripcion.Clear();
            txtPresupuesto.Clear();
            dtpFechaIngreso.Value = DateTime.Today;
        }
        private void CargarCombos()
        {
            try
            {
                // 1) Clientes
                var dtCli = new DataTable();
                using (var cn = new ConexionSQL().ObtenerConexion())
                using (var da = new SqlDataAdapter("SELECT DNI FROM Cliente ORDER BY DNI", cn))
                    da.Fill(dtCli);

                cbDniCliente.DataSource = dtCli;
                cbDniCliente.DisplayMember = "DNI";
                cbDniCliente.ValueMember = "DNI";
                cbDniCliente.SelectedIndex = -1;

                // 2) Tipos de Equipo
                var dtTipo = new DataTable();
                using (var cn = new ConexionSQL().ObtenerConexion())
                using (var da = new SqlDataAdapter("SELECT idEquipo, Descripcion FROM TipoEquipo ORDER BY Descripcion", cn))
                    da.Fill(dtTipo);

                cbTipoEquipo.DataSource = dtTipo;
                cbTipoEquipo.DisplayMember = "Descripcion";
                cbTipoEquipo.ValueMember = "idEquipo";
                cbTipoEquipo.SelectedIndex = -1;

                // 3) Medios de Pago
                var dtPago = new DataTable();
                using (var cn = new ConexionSQL().ObtenerConexion())
                using (var da = new SqlDataAdapter("SELECT idMedioPago, Descripcion FROM MediosPago ORDER BY Descripcion", cn))
                    da.Fill(dtPago);

                cbMedioPago.DataSource = dtPago;
                cbMedioPago.DisplayMember = "Descripcion";
                cbMedioPago.ValueMember = "idMedioPago";
                cbMedioPago.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo conectar a la base de datos:\n{ex.Message}",
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = false;                     // Deshabilita el form
            }
        }

        private void CargarFiltroEstados()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("texto", typeof(string));
                dt.Rows.Add(0, "Todos");

                // Cargar estados reales desde la base de datos
                using (var cn = new ConexionSQL().ObtenerConexion())
                using (var cmd = new SqlCommand("SELECT idEstado, Descripcion FROM EstadosReparacion ORDER BY idEstado", cn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(reader["idEstado"], reader["Descripcion"]);
                    }
                }

                cbEstado.DataSource = dt;
                cbEstado.ValueMember = "id";
                cbEstado.DisplayMember = "texto";
                cbEstado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                // Fallback a estados hardcodeados si no se puede conectar
                var dt = new DataTable();
                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("texto", typeof(string));
                dt.Rows.Add(0, "Todos");
                dt.Rows.Add(1, "Pendiente");
                dt.Rows.Add(2, "En Reparacion");
                dt.Rows.Add(3, "Entregado");
                dt.Rows.Add(4, "Cancelado");
                dt.Rows.Add(5, "Arreglado");

                cbEstado.DataSource = dt;
                cbEstado.ValueMember = "id";
                cbEstado.DisplayMember = "texto";
                cbEstado.SelectedIndex = 0;

                MessageBox.Show($"No se pudieron cargar los estados desde la base de datos. Usando valores por defecto.\nError: {ex.Message}",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarReparacionesEnDGV()
        {
            var sb = new StringBuilder();

            // 1) Armado del SELECT con comas bien colocadas
            sb.AppendLine("SELECT");
            sb.AppendLine("  r.idReparacion        AS idReparacion,");
            sb.AppendLine("  er.Descripcion        AS Estado,");
            sb.AppendLine("  c.Nombre + ' ' + c.Apellido AS Nombre,");
            sb.AppendLine("  te.Descripcion        AS Tipo,");
            sb.AppendLine("  r.Modelo              AS Modelo,");
            sb.AppendLine("  r.FechaIngreso        AS FechaIngreso,");
            sb.AppendLine("  r.FechaEntrega        AS FechaEntrega");
            sb.AppendLine("FROM Reparaciones r");
            sb.AppendLine("  INNER JOIN Cliente          c  ON r.idCliente    = c.idCliente");
            sb.AppendLine("  INNER JOIN TipoEquipo       te ON r.idTipoEquipo = te.idEquipo");
            sb.AppendLine("  INNER JOIN EstadosReparacion er ON r.idEstado   = er.idEstado");

            // 2) filtros dinámicos
            var filtros = new List<string>();
            int idEst = Convert.ToInt32(cbEstado.SelectedValue);
            if (idEst > 0)
                filtros.Add("r.idEstado = @estado");

            if (!string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
                filtros.Add("(c.DNI LIKE @busq OR c.Nombre LIKE @busq OR c.Apellido LIKE @busq)");

            if (filtros.Count > 0)
                sb.AppendLine("WHERE " + string.Join(" AND ", filtros));

            sb.AppendLine("ORDER BY r.FechaIngreso DESC;");

            // 3) Ejecutar y bindear
            var dt = new DataTable();
            try
            {
                using var cn = new ConexionSQL().ObtenerConexion();
                using var cmd = new SqlCommand(sb.ToString(), cn);

                if (idEst > 0)
                    cmd.Parameters.AddWithValue("@estado", idEst);

                if (!string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
                    cmd.Parameters.AddWithValue("@busq", $"%{txtBuscarCliente.Text.Trim()}%");

                using var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sin conexión: {ex.Message}",
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                                     // aborta la carga
            }

            dgvReparaciones.AutoGenerateColumns = false;
            dgvReparaciones.DataSource = dt;

            // Mostrar u ocultar FechaEntrega según filtro
            const int ID_ARREGLADO = 3;
            bool mostrarEntrega = idEst == ID_ARREGLADO;
            dgvReparaciones.Columns["colFechaEntrega"].Visible = mostrarEntrega;

            // 0: Estado
            if (dgvReparaciones.Columns.Contains("colEstado"))
                dgvReparaciones.Columns["colEstado"].DisplayIndex = 0;

            // 1: Nombre (Cliente)
            if (dgvReparaciones.Columns.Contains("colNombre"))
                dgvReparaciones.Columns["colNombre"].DisplayIndex = 1;

            // 2: Tipo
            if (dgvReparaciones.Columns.Contains("colTipo"))
                dgvReparaciones.Columns["colTipo"].DisplayIndex = 2;

            // 3: Modelo
            if (dgvReparaciones.Columns.Contains("colModelo"))
                dgvReparaciones.Columns["colModelo"].DisplayIndex = 3;

            // 4: FechaIngreso
            if (dgvReparaciones.Columns.Contains("colFechaIngreso"))
                dgvReparaciones.Columns["colFechaIngreso"].DisplayIndex = 4;

            // 5: FechaEntrega (solo si visible)
            if (mostrarEntrega && dgvReparaciones.Columns.Contains("colFechaEntrega"))
                dgvReparaciones.Columns["colFechaEntrega"].DisplayIndex = 5;

            // 6: Acciones (botón)
            if (dgvReparaciones.Columns.Contains("colAcciones"))
                dgvReparaciones.Columns["colAcciones"].DisplayIndex = mostrarEntrega ? 6 : 5;
        }

        private void dgvReparaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvReparaciones.Columns[e.ColumnIndex].Name != "colAcciones") return;

            int idRep = (int)dgvReparaciones.Rows[e.RowIndex]
                            .Cells["colIdReparacion"].Value;

            using var detalle = new FormDetalleReparacion(idRep);

            var result = detalle.ShowDialog();

            if (result == DialogResult.OK)
                CargarReparacionesEnDGV();
        }
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            CargarReparacionesEnDGV();
        }

        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            PagosReparaciones pagosReparaciones = new PagosReparaciones();
            pagosReparaciones.ShowDialog();
        }

        private void GenerarPDFReparacion(int idReparacion)
        {
            try
            {
                // Crear carpeta en Descargas si no existe
                string carpetaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "Comprobantes_Reparaciones");
                if (!Directory.Exists(carpetaDescargas))
                    Directory.CreateDirectory(carpetaDescargas);

                // Obtener datos de la reparación
                string cliente = "", equipo = "", modelo = "", problema = "", precio = "", medioPago = "", fecha = "";

                using (var cn = new ConexionSQL().ObtenerConexion())
                {
                    string sql = @"
                SELECT 
                    c.Nombre + ' ' + c.Apellido AS Cliente,
                    c.DNI,
                    c.Telefono,
                    te.Descripcion AS TipoEquipo,
                    r.Modelo,
                    r.DescripcionProblema,
                    r.PresupuestoEstimado,
                    mp.Descripcion AS MedioPago,
                    r.FechaIngreso
                FROM Reparaciones r
                INNER JOIN Cliente c ON r.idCliente = c.idCliente
                INNER JOIN TipoEquipo te ON r.idTipoEquipo = te.idEquipo
                INNER JOIN PagosReparacion pr ON r.idReparacion = pr.idReparacion
                INNER JOIN MediosPago mp ON pr.idMedioPago = mp.idMedioPago
                WHERE r.idReparacion = @id";

                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", idReparacion);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cliente = reader["Cliente"].ToString();
                                string dni = reader["DNI"].ToString();
                                string telefono = reader["Telefono"].ToString();
                                equipo = reader["TipoEquipo"].ToString();
                                modelo = reader["Modelo"].ToString();
                                problema = reader["DescripcionProblema"].ToString();
                                precio = Convert.ToDecimal(reader["PresupuestoEstimado"]).ToString("C");
                                medioPago = reader["MedioPago"].ToString();
                                fecha = Convert.ToDateTime(reader["FechaIngreso"]).ToString("dd/MM/yyyy");

                                cliente = $"{cliente} - DNI: {dni} - TEL: {telefono}";
                            }
                        }
                    }
                }

                // Crear nombre del archivo
                string nombreArchivo = $"Comprobante_{cliente.Split('-')[0].Trim()}_{fecha.Replace("/", "-")}_{DateTime.Now:HHmmss}.pdf";
                string rutaCompleta = Path.Combine(carpetaDescargas, nombreArchivo);

                // Crear documento PDF - USAR NOMBRE COMPLETO PARA EVITAR AMBIGÜEDAD
                iTextSharp.text.Document documento = new iTextSharp.text.Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(documento, new FileStream(rutaCompleta, FileMode.Create));
                documento.Open();

                // Fuentes
                var fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                var fontPequena = FontFactory.GetFont(FontFactory.HELVETICA, 8);

                // Encabezado
                Paragraph titulo = new Paragraph("COMPROBANTE DE REPARACIÓN", fontTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                documento.Add(titulo);

                documento.Add(new Paragraph("\n"));

                Paragraph direccion = new Paragraph("MUÑECAS 2326 TELÉFONO: 3813419715", fontSubtitulo);
                direccion.Alignment = Element.ALIGN_CENTER;
                documento.Add(direccion);

                Paragraph horarios = new Paragraph("LUNES A VIERNES DE 9:30AM A 13:00PM Y DE 17:00PM A 21:30PM\nSÁBADOS DE 11:00AM A 21:00PM DE CORRIDO.", fontNormal);
                horarios.Alignment = Element.ALIGN_CENTER;
                documento.Add(horarios);

                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph($"Fecha de ingreso: {fecha}", fontNormal));
                documento.Add(new Paragraph("\n"));

                // Datos del cliente y equipo
                documento.Add(new Paragraph($"CLIENTE: {cliente}", fontNormal));
                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph($"MARCA Y MODELO: {equipo} {modelo}", fontNormal));
                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph($"FALLA DEL EQUIPO: {problema}", fontNormal));
                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph($"MEDIO DE PAGO: {medioPago}", fontNormal));
                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph($"TOTAL: {precio}", fontSubtitulo));
                documento.Add(new Paragraph("\n"));

                // Términos y condiciones
                documento.Add(new Paragraph("Presupuesto de 48 hs hábiles y sujeto al dólar blue", fontSubtitulo));
                documento.Add(new Paragraph("\n"));

                string[] terminos = {
            "1. Todo presupuesto no aceptado el cliente tendrá que pagar el costo de la revisión.",
            "2. Toda reparación tiene garantía de 15 días continuos a partir de la fecha de entrega.",
            "3. Después de 30 días de su fecha de ingreso, se cobrará $500 por día adicional.",
            "4. La empresa no se hace responsable por pérdida o extravío pasando los 30 días.",
            "5. El cliente renuncia a las leyes 26.361, 24.240, 5672, 26.951.",
            "6. La empresa no se hace responsable de la pérdida de información o datos.",
            "7. La empresa no responde por pérdida de SIMCARD o memoria MICRO SD.",
            "8. No me responsabilizo por el origen de los equipos ni por pérdidas por siniestro.",
            "9. No se aceptarán reclamos por fallas no detectadas en equipos con defectos previos.",
            "10. El cliente está de acuerdo con los términos y condiciones."
        };

                foreach (string termino in terminos)
                {
                    documento.Add(new Paragraph(termino, fontPequena));
                }

                documento.Add(new Paragraph("\n\n"));
                documento.Add(new Paragraph("FIRMA DEL CLIENTE _____________", fontPequena));

                documento.Close();

                // Preguntar si quiere abrir el PDF
                var resultado = MessageBox.Show($"Reparación guardada exitosamente.\n\n¿Desea abrir el comprobante PDF?",
                                              "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}