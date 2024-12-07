using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using AuctionDesktopProgram.Helper;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;

namespace AuctionDesktopProgram
{
    public partial class FormVendidos : Form
    {
        private readonly ISubastaBusiness _subastaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly Loading loadingForm = new Loading();

        public FormVendidos(ISubastaBusiness subastaBusiness, IProductoBusiness productoBusiness)
        {
            _subastaBusiness = subastaBusiness;
            _productoBusiness = productoBusiness;
            InitializeComponent();
            kryptonButton1.Enabled = true;
        }

        private void FormVendidos_Load(object sender, EventArgs e)
        {
            this.LoadingProcess.RunWorkerAsync();
            ShowLoading();
            //var productosVendidos = _subastaBusiness.GetProductoWinners()
            //    .Select(winner => new ProductoVendidoDisplay
            //    {
            //        NombreProducto = winner.Nombre ?? "-",
            //        NombreGanador = winner.NombreGanador ?? "-",
            //        PrecioBase = winner.PrecioBase,
            //        MontoFinal = winner.Monto,
            //        GananciaVendedor = winner.Monto - (winner.Monto * 0.10m),
            //        GananciaEmpresa = winner.Monto * 0.10m
            //    }).ToList();

            //var sortableProductos = new SortableBindingList<ProductoVendidoDisplay>(productosVendidos);

            //if (sortableProductos.Any())
            //{
            //    ProductoDataGrid.DataSource = sortableProductos;
            //}
            //else
            //{
            //    MessageBox.Show("No hay productos vendidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        public void GenerateVendidosReportPdf(string filePath)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    // Encabezado del reporte
                    document.Add(new Paragraph("Reporte de Productos Vendidos")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));

                    // Obtener productos vendidos
                    var productosVendidos = _subastaBusiness.GetProductoWinners()
                        .Select(winner => new
                        {
                            NombreProducto = winner.Nombre ?? "-",
                            NombreGanador = winner.NombreGanador ?? "-",
                            PrecioBase = winner.PrecioBase,
                            MontoFinal = winner.Monto,
                            GananciaVendedor = winner.Monto - (winner.Monto * 0.10m),
                            GananciaEmpresa = winner.Monto * 0.10m
                        }).ToList();

                    if (productosVendidos.Any())
                    {
                        // Crear tabla de resumen
                        Table productTable = new Table(5);
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Producto").SetBold()));
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Ganador").SetBold()));
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Precio Base").SetBold()));
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Monto Final").SetBold()));
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Ganancia Empresa").SetBold()));

                        // Agregar filas con datos de productos vendidos
                        foreach (var product in productosVendidos)
                        {
                            productTable.AddCell(new Cell().Add(new Paragraph(product.NombreProducto)));
                            productTable.AddCell(new Cell().Add(new Paragraph(product.NombreGanador)));
                            productTable.AddCell(new Cell().Add(new Paragraph($"${product.PrecioBase:N2}")));
                            productTable.AddCell(new Cell().Add(new Paragraph($"${product.MontoFinal:N2}")));
                            productTable.AddCell(new Cell().Add(new Paragraph($"${product.GananciaEmpresa:N2}")));
                        }

                        document.Add(productTable.SetMarginBottom(20));
                    }
                    else
                    {
                        document.Add(new Paragraph("No se encontraron productos vendidos.").SetFontSize(12));
                    }

                    // Agregar fecha de generación del reporte
                    document.Add(new Paragraph($"Fecha de generación del reporte: {DateTime.Now:dd/MM/yyyy HH:mm}")
                        .SetFontSize(10)
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetMarginTop(30));
                }

                MessageBox.Show("Archivo PDF guardado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo para guardar el archivo PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "ReporteProductosVendidos.pdf" // Nombre sugerido para el archivo PDF
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    // Verificar si la ruta es válida
                    if (string.IsNullOrWhiteSpace(filePath))
                    {
                        MessageBox.Show("Ruta de archivo no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Llamar al método para generar el reporte PDF en la ruta seleccionada
                    GenerateVendidosReportPdf(filePath);
                }
                catch (Exception ex)
                {
                    // Mostrar el error si ocurre algún problema al generar el PDF
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadingProcess_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var productosVendidos = _subastaBusiness.GetProductoWinners()
            .Select(winner => new ProductoVendidoDisplay
            {
                NombreProducto = winner.Nombre ?? "-",
                NombreGanador = winner.NombreGanador ?? "-",
                ApellidoGanador = winner.ApellidoGanador ?? "-",
                PrecioBase = winner.PrecioBase,
                MontoFinal = winner.Monto,
                GananciaVendedor = winner.Monto - (winner.Monto * 0.10m),
                GananciaEmpresa = winner.Monto * 0.10m
            }).ToList();

            e.Result = new SortableBindingList<ProductoVendidoDisplay>(productosVendidos);
        }

        private void LoadingProcess_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                var sortableProductos = e.Result as SortableBindingList<ProductoVendidoDisplay>;

                if (sortableProductos.Any())
                {
                    ProductoDataGrid.DataSource = sortableProductos;
                    panel2.Dispose();
                    loadingForm.Close();
                }
                else
                {
                    MessageBox.Show("No hay productos vendidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel2.Dispose();
                    loadingForm.Close();
                }
            }
            else
            {
                panel2.Dispose();
                loadingForm.Close();
                MessageBox.Show("Error al traer productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowLoading()
        {
            loadingForm.FormBorderStyle = FormBorderStyle.None;
            loadingForm.Size = this.Size / 2;
            loadingForm.Dock = DockStyle.Fill;
            loadingForm.StartPosition = FormStartPosition.CenterParent;
            panel2.Tag = loadingForm;
            panel2.BringToFront();
            panel2.Visible = true;
            loadingForm.ShowDialog();
        }
    }
}

