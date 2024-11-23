using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;

namespace AuctionDesktopProgram
{
    public partial class ProductosNoOfertados : Form
    {
        private readonly IProductoBusiness _productoBusiness;
        private readonly ISubastaBusiness _subastaBusiness;
        private readonly Loading loadingForm = new();
        private Subasta Subastas;
        public ProductosNoOfertados(IProductoBusiness productoBusiness, ISubastaBusiness subastaBusiness)
        {
            _subastaBusiness = subastaBusiness;
            _productoBusiness = productoBusiness;
            InitializeComponent();

        }

        private AutoCompleteStringCollection PopulateComboBox()
        {
            AutoCompleteStringCollection subastas = [];
            subastas.Add("Todas");
            try
            {
                var allsubastas = _subastaBusiness.GetSuccessful();
                if (allsubastas is null || allsubastas.Count == 0)
                {
                    return subastas;
                }

                subastas.AddRange(allsubastas.Select(s => ($"Subasta N°{s.IdSubasta}")).ToArray());
                return subastas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return subastas;
            }
        }

        private void MostrarValoresGlobales()
        {
            var productosSinOfertas = _productoBusiness.GetProductosSinOfertas();
            int totalSinOfertas = productosSinOfertas.Count;

            var productosConOfertas = _subastaBusiness.GetProductoWinners();
            int totalConOfertas = productosConOfertas.Count;

            int totalProductos = totalSinOfertas + totalConOfertas;

            if (totalProductos == 0)
            {
                labelProdNoVendidos.Text = "0";
                label3.Text = "0";
                label4.Text = "0";
                labelProdVendidosPorcentual.Text = "0";
                return;
            }

            double porcentajeSinOfertas = Math.Round((double)totalSinOfertas / totalProductos * 100, 1);
            double porcentajeConOfertas = Math.Round((double)totalConOfertas / totalProductos * 100, 1);

            labelProdNoVendidos.Text = totalSinOfertas.ToString();
            label3.Text = totalConOfertas.ToString();
            label4.Text = porcentajeSinOfertas.ToString();
            labelProdVendidosPorcentual.Text = porcentajeConOfertas.ToString();
            label2.Text = "Valores globales de todas las subastas";
        }
        private void UpdateDescription()
        {
            if (Subastas is not null)
            {
                int subastaId = Subastas.IdSubasta;

                // Contar productos sin ofertas y con ofertas directamente de la lista de productos de la subasta
                int totalSinOfertas = Subastas.Productos.Count(p => !p.Ofertas.Any());
                int totalConOfertas = Subastas.Productos.Count(p => p.Ofertas.Any());

                // Actualizar los labels para los productos no vendidos y vendidos
                labelProdNoVendidos.Text = totalSinOfertas.ToString();
                label3.Text = totalConOfertas.ToString();

                // Calcular el total de productos en la subasta seleccionada
                int totalProductos = totalSinOfertas + totalConOfertas;

                // Validar para evitar divisiones por cero
                if (totalProductos == 0)
                {
                    Console.WriteLine("No hay productos en la subasta.");
                    return;
                }

                // Calcular porcentajes
                double porcentajeSinOfertas = Math.Round((double)totalSinOfertas / totalProductos * 100, 0);
                double porcentajeConOfertas = Math.Round((double)totalConOfertas / totalProductos * 100, 0);

                // Actualizar labels para los porcentajes
                label4.Text = porcentajeSinOfertas.ToString();
                labelProdVendidosPorcentual.Text = porcentajeConOfertas.ToString();

                // Actualizar la descripción de la subasta
                label2.Text = Subastas.Descripcion;
            }
        }

        private SortableBindingList<Producto> CargarProductosNoOfertados()
        {
            var productosSolicitados = _productoBusiness.GetProductosSinOfertas();

            if (productosSolicitados.Count() != 0)
            {
                return  new SortableBindingList<Producto>(productosSolicitados);
            }
            else
            {
                MessageBox.Show("No se encontraron productos solicitados pendientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new SortableBindingList<Producto>(new List<Producto>());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex < 1)
                {
                    MostrarValoresGlobales();
                    return;
                }
                else
                {

                    if (!int.TryParse(comboBox1.SelectedItem.ToString().Replace("Subasta N°", ""), out int subastaId))
                    {
                        MessageBox.Show("Por favor ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Subastas = _subastaBusiness.GetById(subastaId);
                    UpdateDescription();
                }
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show($"No se encontró la subasta: {ex.Message}", "Subasta no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerateGeneralReportPdf(string filePath)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    // Datos generales
                    var allSubastas = _subastaBusiness.GetAll(); // Método para obtener todas las subastas
                    if (allSubastas == null || !allSubastas.Any())
                    {
                        MessageBox.Show("No se encontraron subastas disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir del método si no hay subastas
                    }
                    var totalProductosNoVendidos = 0;
                    var totalProductosVendidos = 0;

                    // Cabecera del reporte
                    document.Add(new Paragraph("Reporte General de Productos No Vendidos")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));

                    // Agregar tabla de resumen
                    Table summaryTable = new Table(2);
                    summaryTable.AddHeaderCell(new Cell().Add(new Paragraph("Descripción").SetBold()));
                    summaryTable.AddHeaderCell(new Cell().Add(new Paragraph("Cantidad").SetBold()));

                    // Recopilar información sobre productos
                    foreach (var subasta in allSubastas)
                    {
                        // Verificar que subasta.Productos no sea null antes de usarla
                        if (subasta.Productos != null)
                        {
                            var productosNoVendidos = subasta.Productos
                                .Where(p => p.Ofertas != null && !p.Ofertas.Any()) // Verificar p.Ofertas no sea null
                                .ToList();

                            totalProductosNoVendidos += productosNoVendidos.Count;
                            totalProductosVendidos += subasta.Productos.Count(p => p.Ofertas != null && p.Ofertas.Any());

                            // Agregar al documento
                            if (productosNoVendidos.Count > 0)
                            {
                                summaryTable.AddCell(new Cell().Add(new Paragraph($"Subasta Nº{subasta.IdSubasta}: {subasta.Descripcion}")));
                                summaryTable.AddCell(new Cell().Add(new Paragraph(productosNoVendidos.Count.ToString())));
                            }
                        }
                    }

                    document.Add(summaryTable.SetMarginBottom(20));

                    // Agregar resumen de total de productos
                    document.Add(new Paragraph($"Total de productos no vendidos: {totalProductosNoVendidos}")
                        .SetFontSize(12).SetMarginBottom(5));
                    document.Add(new Paragraph($"Total de productos vendidos: {totalProductosVendidos}")
                        .SetFontSize(12).SetMarginBottom(5));

                    double totalProductos = totalProductosNoVendidos + totalProductosVendidos;
                    if (totalProductos > 0)
                    {
                        double porcentajeNoVendidos = Math.Round((double)totalProductosNoVendidos / totalProductos * 100, 2);
                        double porcentajeVendidos = Math.Round((double)totalProductosVendidos / totalProductos * 100, 2);
                        document.Add(new Paragraph($"Porcentaje de productos no vendidos: {porcentajeNoVendidos}%")
                            .SetFontSize(12).SetMarginBottom(5));
                        document.Add(new Paragraph($"Porcentaje de productos vendidos: {porcentajeVendidos}%")
                            .SetFontSize(12).SetMarginBottom(20));
                    }

                    // Detallar cada subasta con los productos no vendidos
                    foreach (var subasta in allSubastas)
                    {
                        // Verificar que subasta.Productos no sea null antes de usarla
                        if (subasta.Productos != null)
                        {
                            var productosNoVendidos = subasta.Productos
                                .Where(p => p.Ofertas != null && !p.Ofertas.Any()) // Verificar p.Ofertas no sea null
                                .ToList();

                            if (productosNoVendidos.Count > 0)
                            {
                                document.Add(new Paragraph($"Subasta Nº{subasta.IdSubasta}: {subasta.Descripcion}")
                                    .SetFontSize(14).SetBold().SetMarginTop(20));

                                Table productTable = new Table(4);
                                productTable.AddHeaderCell(new Cell().Add(new Paragraph("#").SetBold()));
                                productTable.AddHeaderCell(new Cell().Add(new Paragraph("Nombre").SetBold()));
                                productTable.AddHeaderCell(new Cell().Add(new Paragraph("Precio Base").SetBold()));
                                productTable.AddHeaderCell(new Cell().Add(new Paragraph("Fecha de Solicitud").SetBold()));

                                foreach (var product in productosNoVendidos)
                                {
                                    productTable.AddCell(new Cell().Add(new Paragraph(product.IdProducto.ToString())));
                                    productTable.AddCell(new Cell().Add(new Paragraph(product.Nombre ?? "N/A"))); // Manejar posibles valores nulos
                                    productTable.AddCell(new Cell().Add(new Paragraph($"${product.PrecioBase:N2}")));
                                    productTable.AddCell(new Cell().Add(new Paragraph(product.FechaSolicitud.ToString("dd/MM/yyyy"))));
                                }

                                document.Add(productTable.SetMarginBottom(10));
                            }
                        }
                    }

                    document.Add(new Paragraph($"Fecha de generación del reporte: {DateTime.Now:dd/MM/yyyy HH:mm}")
                        .SetFontSize(10)
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetMarginTop(30));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el archivo\n {ex}");
            }

            MessageBox.Show("Archivo PDF guardado correctamente!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "ReporteProductosNoVendidos.pdf" // Nombre fijo para el reporte general
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GenerateGeneralReportPdf(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProductosNoOfertados_Load(object sender, EventArgs e)
        {
            ShowLoading();
            this.LoadingProcess.RunWorkerAsync();

        }

        private void LoadingProcess_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var subastasAutocomplete = PopulateComboBox();
            var ProductosNoOfertados = CargarProductosNoOfertados();

            var results = new Dictionary<string, object>
            {
                {"ComboboxItems", subastasAutocomplete },
                {"DataGridSource", ProductosNoOfertados},
            };

            e.Result = results;

        }

        private void LoadingProcess_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Dictionary<string, object> results)
            {
                var subastas = (AutoCompleteStringCollection)results["ComboboxItems"];
                var sortableprods = (SortableBindingList<Producto>)results["DataGridSource"];

                comboBox1.AutoCompleteCustomSource = subastas;
                comboBox1.DataSource = subastas;
                comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ProductosDataGrid.DataSource = sortableprods;
                LoadinPanel.Dispose();
                loadingForm.Close();
            }
        }

        private void ShowLoading()
        {
            loadingForm.TopLevel = false;
            loadingForm.FormBorderStyle = FormBorderStyle.None;
            loadingForm.Dock = DockStyle.Fill;
            LoadinPanel.Controls.Add(loadingForm);
            LoadinPanel.Tag = loadingForm;
            LoadinPanel.BringToFront();
            LoadinPanel.Visible = true;
            loadingForm.Show();
        }
    }
}
