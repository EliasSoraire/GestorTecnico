        using System;
        using System.Data;
        using System.Data.SqlClient;
        using System.Drawing;
        using System.Globalization;
        using System.IO;
        using System.Text;
        using System.Windows.Forms;
        using QuestPDF.Fluent;
        using QuestPDF.Infrastructure;


namespace Gestor_Tecnico
{
    public partial class Reparaciones : Form
    {
        private readonly List<string> rutasImagenSeleccionadas = new List<string>();

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
            QuestPDF.Settings.License = LicenseType.Community;
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
            using var ofd = new OpenFileDialog
            {
                Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp",
                Multiselect = true,
                Title = "Seleccionar hasta 3 imágenes del equipo"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            if (ofd.FileNames.Length > 3)
            {
                MessageBox.Show("Máximo 3 imágenes por reparación.", "Límite excedido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rutasImagenSeleccionadas.Clear();
            rutasImagenSeleccionadas.AddRange(ofd.FileNames);

            MessageBox.Show($"Se seleccionaron {rutasImagenSeleccionadas.Count} imagen(es).");
        }

        private void btnGuardarReparacion_Click(object sender, EventArgs e)
        {
            /* ---------- VALIDACIONES (sin cambios) ---------- */
            if (cbDniCliente.SelectedIndex < 0) { MessageBox.Show("Seleccioná un DNI de cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbDniCliente.Focus(); return; }
            if (cbTipoEquipo.SelectedIndex < 0) { MessageBox.Show("Seleccioná un tipo de equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbTipoEquipo.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtModelo.Text)) { MessageBox.Show("El campo Modelo es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtModelo.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) { MessageBox.Show("El campo Descripción es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtDescripcion.Focus(); return; }
            if (!decimal.TryParse(txtPresupuesto.Text.Trim(), out var presupuesto) || presupuesto <= 0) { MessageBox.Show("El Presupuesto debe ser un número mayor que cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtPresupuesto.Focus(); return; }
            if (cbMedioPago.SelectedIndex < 0) { MessageBox.Show("Seleccioná un medio de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbMedioPago.Focus(); return; }
            if (dtpFechaIngreso.Value.Date > DateTime.Today) { MessageBox.Show("La Fecha de Ingreso no puede ser posterior a hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); dtpFechaIngreso.Focus(); return; }

            /* ---------- OBTENER idCliente ---------- */
            int idCliente;
            try
            {
                using var cnCli = new ConexionSQL().ObtenerConexion();
                using var cmdCli = new SqlCommand("SELECT idCliente FROM Cliente WHERE DNI = @dni", cnCli);
                cmdCli.Parameters.AddWithValue("@dni", cbDniCliente.SelectedValue);
                object result = cmdCli.ExecuteScalar();
                if (result == null) { MessageBox.Show("El DNI seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                idCliente = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* ---------- INSERTS EN TRANSACCIÓN ---------- */
            int idReparacion;
            using var cn = new ConexionSQL().ObtenerConexion();
            using var tx = cn.BeginTransaction();
            try
            {
                /* a) Reparaciones */
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
                    cmd.Parameters.AddWithValue("@est", 1); // Pendiente
                    cmd.Parameters.AddWithValue("@monto", presupuesto);
                    idReparacion = Convert.ToInt32(cmd.ExecuteScalar());
                }

                /* b) Pago inicial */
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

                /* c) FOTOS OPCIONALES */
                if (rutasImagenSeleccionadas.Count > 0)
                {
                    string carpetaFotos = Path.Combine(Application.StartupPath, "FotosReparaciones");
                    Directory.CreateDirectory(carpetaFotos);

                    foreach (string rutaOriginal in rutasImagenSeleccionadas)
                    {
                        string ext = Path.GetExtension(rutaOriginal);
                        string nombreArchivo = $"Rep_{idReparacion}_{Guid.NewGuid()}{ext}";
                        string destino = Path.Combine(carpetaFotos, nombreArchivo);

                        File.Copy(rutaOriginal, destino, true);

                        const string sqlFoto = @"
        INSERT INTO FotosReparaciones (idReparacion, RutaFoto)
        VALUES (@rep, @ruta);";

                        using var cmdFoto = new SqlCommand(sqlFoto, cn, tx);
                        cmdFoto.Parameters.AddWithValue("@rep", idReparacion);
                        cmdFoto.Parameters.AddWithValue("@ruta", nombreArchivo);
                        cmdFoto.ExecuteNonQuery();
                    }
                }


                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }

            MessageBox.Show("Reparación registrada con éxito.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarReparacionesEnDGV();
            LimpiarFormulario();
            rutasImagenSeleccionadas.Clear();
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
        internal class ResumenMes
        {
            public int Mes { get; set; }
            public int CantRep { get; set; }
            public decimal MontoRep { get; set; }
            public int CantVen { get; set; }
            public decimal MontoVen { get; set; }
        }
        internal class DetalleRenglon
        {
            public DateTime Fecha { get; set; }
            public string Descripcion { get; set; } = "";
            public decimal Monto { get; set; }
        }
        internal class ReporteAnualDoc : IDocument
        {
            public int Anio { get; set; }
            public IList<ResumenMes> Resumen { get; set; } = new List<ResumenMes>();
            public IDictionary<int, List<DetalleRenglon>> DetRep { get; set; } = new Dictionary<int, List<DetalleRenglon>>();
            public IDictionary<int, List<DetalleRenglon>> DetVen { get; set; } = new Dictionary<int, List<DetalleRenglon>>();

            public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

            public void Compose(IDocumentContainer doc)
            {
                /* ======= PÁGINA 1 – RESUMEN ======= */
                doc.Page(p =>
                {
                    p.Header().Column(c =>
                    {
                        c.Item().Text("REPORTE DE VENTAS Y REPARACIONES").SemiBold().FontSize(18).AlignCenter();
                        c.Item().Text($"AÑO {Anio}").SemiBold().FontSize(14).AlignCenter();
                        c.Item().Text($"Generado: {DateTime.Now:g}").FontSize(10).AlignCenter();
                    });

                    /* Tabla */
                    p.Content().Table(t =>
                    {
                        t.ColumnsDefinition(c =>
                        {
                            c.RelativeColumn();
                            c.ConstantColumn(55);
                            c.ConstantColumn(75);
                            c.ConstantColumn(55);
                            c.ConstantColumn(75);
                        });

                        void Enc(string s)
                        {
                            t.Cell().Background("#B0C4DE").Padding(4).Text(s).SemiBold().AlignCenter();
                        }

                        t.Header(h =>
                        {
                            Enc("Mes");
                            Enc("Rep.");
                            Enc("$ Rep.");
                            Enc("Ventas");
                            Enc("$ Ventas");
                        });

                        foreach (var r in Resumen.OrderBy(x => x.Mes))
                        {
                            string mes = new CultureInfo("es-AR")
                                                   .DateTimeFormat.GetMonthName(r.Mes).ToUpperInvariant();

                            // Para evitar errores por encadenar void, hacemos cada llamada por separado:
                            t.Cell().Text(mes);
                            t.Cell().AlignCenter();

                            t.Cell().Text(r.CantRep.ToString());
                            t.Cell().AlignCenter();

                            t.Cell().Text(r.MontoRep.ToString("C"));
                            t.Cell().AlignRight();

                            t.Cell().Text(r.CantVen.ToString());
                            t.Cell().AlignCenter();

                            t.Cell().Text(r.MontoVen.ToString("C"));
                            t.Cell().AlignRight();
                        }

                        void Tot(string s)
                        {
                            t.Cell().Background("#D3D3D3").Padding(4).Text(s).SemiBold();
                        }

                        t.Footer(f =>
                        {
                            Tot("TOTAL");
                            Tot(Resumen.Sum(x => x.CantRep).ToString());
                            Tot(Resumen.Sum(x => x.MontoRep).ToString("C"));
                            Tot(Resumen.Sum(x => x.CantVen).ToString());
                            Tot(Resumen.Sum(x => x.MontoVen).ToString("C"));
                        });
                    });

                    p.Footer().AlignCenter().Text(x =>
                    {
                        x.Span("Página ");
                        x.CurrentPageNumber();
                        x.Span(" / ");
                        x.TotalPages();
                    });
                });

                /* ======= DETALLE MES A MES ======= */
                foreach (var mes in Resumen.Where(r => r.CantRep + r.CantVen > 0).OrderBy(r => r.Mes))
                {
                    doc.Page(p =>
                    {
                        string nomMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes.Mes).ToUpperInvariant();

                        p.Header().Text($"{nomMes} {Anio} – DETALLE").SemiBold().FontSize(16).AlignCenter();

                        p.Content().Column(col =>
                        {
                            /* Reparaciones */
                            col.Item().Background("#F0F8FF").Padding(4).Text($"REPARACIONES ENTREGADAS ({mes.CantRep})").SemiBold();
                            foreach (var d in DetRep.TryGetValue(mes.Mes, out var listaRep) ? listaRep : new List<DetalleRenglon>())
                            {
                                col.Item().Text($"• {d.Fecha:dd/MM}   {d.Descripcion}   {d.Monto:C}");
                            }

                            col.Item().PaddingVertical(8);

                            /* Ventas */
                            col.Item().Background("#F0F8FF").Padding(4).Text($"VENTAS ({mes.CantVen})").SemiBold();
                            foreach (var d in DetVen.TryGetValue(mes.Mes, out var listaVen) ? listaVen : new List<DetalleRenglon>())
                            {
                                col.Item().Text($"• {d.Fecha:dd/MM}   {d.Descripcion}   {d.Monto:C}");
                            }
                        });

                        p.Footer().AlignCenter().Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                            x.Span(" / ");
                            x.TotalPages();
                        });
                    });
                }
            }
        }
        private List<ResumenMes> ObtenerResumenAnual(
        int anio,
        out Dictionary<int, List<DetalleRenglon>> detRep,
        out Dictionary<int, List<DetalleRenglon>> detVen)
        {
            detRep = Enumerable.Range(1, 12).ToDictionary(m => m, _ => new List<DetalleRenglon>());
            detVen = Enumerable.Range(1, 12).ToDictionary(m => m, _ => new List<DetalleRenglon>());

            var lista = Enumerable.Range(1, 12).Select(m => new ResumenMes { Mes = m }).ToList();

            string sqlResumenRep = @"SELECT MONTH(FechaEntrega), COUNT(*), SUM(MontoTotal)
                             FROM   Reparaciones
                             WHERE  idEstado = 3 AND YEAR(FechaEntrega)=@anio
                             GROUP  BY MONTH(FechaEntrega)";
            string sqlResumenVen = @"SELECT MONTH(FechaVenta), COUNT(*), SUM(MontoTotal)
                             FROM   Ventas
                             WHERE  YEAR(FechaVenta)=@anio
                             GROUP  BY MONTH(FechaVenta)";

            string sqlDetRep = @"SELECT MONTH(FechaEntrega),
                                FechaEntrega,
                                Modelo,
                                MontoTotal
                         FROM   Reparaciones
                         WHERE  idEstado=3 AND YEAR(FechaEntrega)=@anio
                         ORDER  BY FechaEntrega";

            string sqlDetVen = @"SELECT MONTH(FechaVenta),
                                FechaVenta,
                                p.Nombre + ' x' + CAST(d.Cantidad AS varchar),
                                d.SubTotal
                         FROM   Ventas v
                         JOIN   DetalleVenta d ON d.idVenta = v.idVenta
                         JOIN   Producto     p ON p.idProducto = d.idProducto
                         WHERE  YEAR(FechaVenta)=@anio
                         ORDER  BY FechaVenta";

            using var cn = new ConexionSQL().ObtenerConexion();

            void FResumen(string sql, Action<int, int, decimal> setter)
            {
                using var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@anio", anio);
                using var rd = cmd.ExecuteReader();
                while (rd.Read())
                    setter(rd.GetInt32(0), rd.GetInt32(1),
                           rd.IsDBNull(2) ? 0 : rd.GetDecimal(2));
            }

            FResumen(sqlResumenRep, (m, cant, mto) => { lista[m - 1].CantRep = cant; lista[m - 1].MontoRep = mto; });
            FResumen(sqlResumenVen, (m, cant, mto) => { lista[m - 1].CantVen = cant; lista[m - 1].MontoVen = mto; });

            void FDetalle(string sql, Dictionary<int, List<DetalleRenglon>> dic)
            {
                using var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@anio", anio);
                using var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dic[rd.GetInt32(0)].Add(new DetalleRenglon
                    {
                        Fecha = rd.GetDateTime(1),
                        Descripcion = rd.GetString(2),
                        Monto = rd.GetDecimal(3)
                    });
                }
            }

            FDetalle(sqlDetRep, detRep);
            FDetalle(sqlDetVen, detVen);

            return lista;
        }
        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            int anio = DateTime.Now.Year;

            var resumen = ObtenerResumenAnual(anio, out var detRep, out var detVen);

            if (resumen.All(x => x.CantRep + x.CantVen == 0))
            {
                MessageBox.Show("No hay datos registrados en este año.");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "PDF|*.pdf",
                FileName = $"Reporte_{anio}.pdf"
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            QuestPDF.Settings.License = LicenseType.Community;

            var doc = new ReporteAnualDoc
            {
                Anio = anio,
                Resumen = resumen,
                DetRep = detRep,
                DetVen = detVen
            };

            doc.GeneratePdf(sfd.FileName);

            MessageBox.Show("PDF generado correctamente.", "Éxito");
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = sfd.FileName,
                UseShellExecute = true
            });
        }
    }
}