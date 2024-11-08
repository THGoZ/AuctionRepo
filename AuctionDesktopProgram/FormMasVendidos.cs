using Auction.Core.Business;
using Auction.Core.Business.Interfaces;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;

namespace AuctionDesktopProgram
{
    public partial class FormMasVendidos : KryptonForm
    {
        private readonly ISubastaBusiness _subastaBusiness;
        private readonly IProductoBusiness _productoBusiness;

        public FormMasVendidos(ISubastaBusiness subastaBusiness, IProductoBusiness productoBusiness)
        {
            _subastaBusiness = subastaBusiness;
            _productoBusiness = productoBusiness;
            InitializeComponent();
            kryptonButton1.Enabled = true;
        }

        private void labelProdNoVendidos_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormMasVendidos_Load(object sender, EventArgs e)
        {
            // Obtener productos vendidos, calcular las ganancias, y ordenarlos por ganancia
            var productosVendidos = _subastaBusiness.GetProductoWinners()
                .Select(winner => new
                {
                    NombreProducto = winner.Nombre ?? "-",
                    NombreGanador = winner.NombreGanador ?? "-",
                    PrecioBase = winner.PrecioBase,
                    MontoFinal = winner.Monto,
                    GananciaVendedor = winner.Monto - (winner.Monto * 0.10m),
                    GananciaEmpresa = winner.Monto * 0.10m
                })
                .OrderByDescending(p => p.GananciaVendedor) // Ordenar por ganancia del vendedor
                .Take(10) // Seleccionar solo los 10 primeros
                .ToList();

            // Verificar si hay productos vendidos y mostrarlos en el DataGridView
            if (productosVendidos.Any())
            {
                kryptonDataGridView1.DataSource = productosVendidos;

                // Obtener el primer producto (el de mayor ganancia)
                var productoMasVendido = productosVendidos.First();

                // Actualizar los labels con el ID del producto y el ID del vendedor
                labelIdProductoMasVendido.Text = productoMasVendido.NombreProducto.ToString();
                labelIdVendedorProducto.Text = productoMasVendido.NombreGanador.ToString();
            }
            else
            {
                MessageBox.Show("No hay productos vendidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    document.Add(new Paragraph("Reporte de Productos Mas Rentables")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));

                    // Obtener productos vendidos y calcular ganancias
                    var productosVendidos = _subastaBusiness.GetProductoWinners()
                        .Select(winner => new
                        {
                            NombreProducto = winner.Nombre ?? "-",
                            NombreGanador = winner.NombreGanador ?? "-",
                            PrecioBase = winner.PrecioBase,
                            MontoFinal = winner.Monto,
                            GananciaVendedor = winner.Monto - (winner.Monto * 0.10m),
                            GananciaEmpresa = winner.Monto * 0.10m
                        })
                        .OrderByDescending(p => p.GananciaVendedor) // Ordenar por ganancia
                        .Take(10) // Solo los 10 primeros
                        .ToList();

                    if (productosVendidos.Any())
                    {
                        // Crear tabla de resumen
                        Table productTable = new Table(5);
                        productTable.SetWidth(UnitValue.CreatePercentValue(100)); // Ancho de tabla
                        productTable.SetBorder(Border.NO_BORDER);

                        // Encabezados de la tabla
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Producto").SetBold()));
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Ganador").SetBold()));
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Precio Base").SetBold()));
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Monto Final").SetBold()));
                        productTable.AddHeaderCell(new Cell().Add(new Paragraph("Ganancia Empresa").SetBold()));

                        // Agregar filas con los datos
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
    }
}
