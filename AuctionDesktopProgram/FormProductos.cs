using Auction.Core.Business;
using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Borders;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionDesktopProgram
{
    public partial class FormProductos : Form

    {
        private int? selectedSubastaId;

        private readonly ISubastaBusiness _SubastaBusiness;

        private readonly IProductoBusiness _productoBusiness;
        public bool MostrarSoloGanancias { get; set; }
        private readonly Loading loadingForm = new();


        public FormProductos(ISubastaBusiness SubastaBusiness, IProductoBusiness productoBusiness)
        {
            _SubastaBusiness = SubastaBusiness;
            _productoBusiness = productoBusiness;
            InitializeComponent();
            kryptonButton1.Enabled = true;
        }

        private AutoCompleteStringCollection PopulateComboBox()
        {
            AutoCompleteStringCollection subastas = [];
            subastas.Add("Todas");
            try
            {
                var allsubastas = _SubastaBusiness.GetAll();
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

        public void SetSubastaId(int idSubasta)
        {
            selectedSubastaId = idSubasta;
        }

        public void Productos_Load(object sender, EventArgs e)
        {
            this.LoadingProcess.RunWorkerAsync();
            ShowLoading();
            LoadStuff();
        }

        private void LoadStuff()
        {
            if (selectedSubastaId.HasValue)
            {
                // Obtener los productos de la subasta seleccionada
                var productosDeSubasta = _productoBusiness.GetProductos()
                    .Where(p => p.IdSubasta == selectedSubastaId.Value)
                    .ToList();

                // Obtener solo las ofertas de los productos de la subasta seleccionada
                var ofertas = _SubastaBusiness.GetOfertas()
                    .Where(o => productosDeSubasta.Select(p => p.IdProducto).Contains(o.Producto.IdProducto))
                    .Select(o => new
                    {
                        NombreProducto = o.Producto?.Nombre ?? "Sin Nombre",
                        NombreOferente = o.Usuario?.Nombre ?? "Anónimo",
                        MontoOferta = o.Monto
                    }).ToList();

                ProductosDatagrid.DataSource = ofertas;

                // Obtener los ganadores que coinciden con los productos de la subasta seleccionada
                var ganadores = _SubastaBusiness.GetProductoWinners()
                    .Where(g => productosDeSubasta.Select(p => p.Nombre).Contains(g.Nombre)) // Filtrar por nombre de producto
                    .Select(g => new
                    {
                        NombreProducto = g.Nombre ?? "-",
                        NombreGanador = g.NombreGanador ?? "-",
                        PrecioBase = g.PrecioBase,
                        Monto = g.Monto,
                        GananciaVendedor = g.Monto - (g.Monto * 0.10m),
                        GananciaEmpresa = g.Monto * 0.10m,
                    }).ToList();

                GanadoresdataGrid.DataSource = ganadores;

                // Obtener los productos sin ofertas de la subasta seleccionada
                var productosSinOfertas = productosDeSubasta
                    .Where(p => p.Ofertas == null || !p.Ofertas.Any()) // Verificar que la colección de ofertas sea nula o esté vacía
                    .Select(o => new
                    {
                        NombreProducto = o.Nombre,
                        Descripcion = o.Descripcion,
                        Monto = o.PrecioBase
                    }).ToList();

                if (productosSinOfertas.Any())
                {
                    ProductosSOdatagrid.DataSource = productosSinOfertas;
                }
                else
                {
                    // Aquí puedes manejar el caso en que no haya productos sin ofertas
                    ProductosSOdatagrid.DataSource = null; // Limpiar el DataGridView si no hay productos sin ofertas
                }
            }
            else
            {
                // Código para cargar ofertas y ganadores cuando no hay subasta seleccionada
                var ofertas = _SubastaBusiness.GetOfertas();

                var listaOferentes = ofertas.Select(o => new
                {
                    NombreProducto = o.Producto?.Nombre ?? "Sin Nombre",
                    NombreOferente = o.Usuario?.Nombre ?? "Anónimo",
                    MontoOferta = o.Monto
                }).ToList();

                ProductosDatagrid.DataSource = listaOferentes;

                var ganadores = _SubastaBusiness.GetProductoWinners();

                var listaGanadores = ganadores.Select(o => new
                {
                    NombreProducto = o.Nombre ?? "-",
                    NombreGanador = o.NombreGanador ?? "-",
                    PrecioBase = o.PrecioBase,
                    Monto = o.Monto,
                    GananciaVendedor = o.Monto - (o.Monto * 0.10m),
                    GananciaEmpresa = o.Monto * 0.10m,
                }).ToList();

                GanadoresdataGrid.DataSource = listaGanadores;

                // Obtener productos sin ofertas en general
                var productosSinOfertas = _productoBusiness.GetProductos()
                    .Where(p => p.Ofertas == null || !p.Ofertas.Any())
                    .Select(o => new
                    {
                        NombreProducto = o.Nombre,
                        Descripcion = o.Descripcion,
                        Monto = o.PrecioBase
                    }).ToList();

                if (productosSinOfertas.Any())
                {
                    ProductosSOdatagrid.DataSource = productosSinOfertas;
                }
                else
                {
                    MessageBox.Show("No hay productos sin ofertas.");
                }
            }
        }

        public void GenerateReportPdf(string filePath)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    // Encabezado general del reporte
                    document.Add(new Paragraph("Reporte de Subasta")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginBottom(20));

                    // Sección de Ofertas
                    document.Add(new Paragraph("Ofertas")
                        .SetFontSize(16)
                        .SetBold()
                        .SetMarginTop(20)
                        .SetMarginBottom(10));

                    Table ofertasTable = new Table(3);
                    ofertasTable.AddHeaderCell(new Cell().Add(new Paragraph("Producto").SetBold()));
                    ofertasTable.AddHeaderCell(new Cell().Add(new Paragraph("Oferente").SetBold()));
                    ofertasTable.AddHeaderCell(new Cell().Add(new Paragraph("Monto Oferta").SetBold()));

                    foreach (DataGridViewRow row in ProductosDatagrid.Rows)
                    {
                        ofertasTable.AddCell(new Cell().Add(new Paragraph(row.Cells["NombreProducto"].Value?.ToString() ?? "-")));
                        ofertasTable.AddCell(new Cell().Add(new Paragraph(row.Cells["NombreOferente"].Value?.ToString() ?? "-")));
                        ofertasTable.AddCell(new Cell().Add(new Paragraph($"${Convert.ToDecimal(row.Cells["MontoOferta"].Value):N2}")));
                    }

                    document.Add(ofertasTable.SetMarginBottom(20));

                    // Sección de Ganadores
                    document.Add(new Paragraph("Ganadores")
                        .SetFontSize(16)
                        .SetBold()
                        .SetMarginTop(20)
                        .SetMarginBottom(10));

                    Table ganadoresTable = new Table(5);
                    ganadoresTable.AddHeaderCell(new Cell().Add(new Paragraph("Producto").SetBold()));
                    ganadoresTable.AddHeaderCell(new Cell().Add(new Paragraph("Ganador").SetBold()));
                    ganadoresTable.AddHeaderCell(new Cell().Add(new Paragraph("Precio Base").SetBold()));
                    ganadoresTable.AddHeaderCell(new Cell().Add(new Paragraph("Monto Final").SetBold()));
                    ganadoresTable.AddHeaderCell(new Cell().Add(new Paragraph("Ganancia Empresa").SetBold()));

                    foreach (DataGridViewRow row in GanadoresdataGrid.Rows)
                    {
                        ganadoresTable.AddCell(new Cell().Add(new Paragraph(row.Cells["NombreProducto"].Value?.ToString() ?? "-")));
                        ganadoresTable.AddCell(new Cell().Add(new Paragraph(row.Cells["NombreGanador"].Value?.ToString() ?? "-")));
                        ganadoresTable.AddCell(new Cell().Add(new Paragraph($"${Convert.ToDecimal(row.Cells["PrecioBase"].Value):N2}")));
                        ganadoresTable.AddCell(new Cell().Add(new Paragraph($"${Convert.ToDecimal(row.Cells["Monto"].Value):N2}")));
                        ganadoresTable.AddCell(new Cell().Add(new Paragraph($"${Convert.ToDecimal(row.Cells["GananciaEmpresa"].Value):N2}")));
                    }

                    document.Add(ganadoresTable.SetMarginBottom(20));

                    // Sección de Productos sin Ofertas
                    document.Add(new Paragraph("Productos sin Ofertas")
                        .SetFontSize(16)
                        .SetBold()
                        .SetMarginTop(20)
                        .SetMarginBottom(10));

                    Table sinOfertasTable = new Table(3);
                    sinOfertasTable.AddHeaderCell(new Cell().Add(new Paragraph("Producto").SetBold()));
                    sinOfertasTable.AddHeaderCell(new Cell().Add(new Paragraph("Descripción").SetBold()));
                    sinOfertasTable.AddHeaderCell(new Cell().Add(new Paragraph("Precio Base").SetBold()));

                    foreach (DataGridViewRow row in ProductosSOdatagrid.Rows)
                    {
                        sinOfertasTable.AddCell(new Cell().Add(new Paragraph(row.Cells["NombreProducto"].Value?.ToString() ?? "-")));
                        sinOfertasTable.AddCell(new Cell().Add(new Paragraph(row.Cells["Descripcion"].Value?.ToString() ?? "-")));
                        sinOfertasTable.AddCell(new Cell().Add(new Paragraph($"${Convert.ToDecimal(row.Cells["Monto"].Value):N2}")));
                    }

                    document.Add(sinOfertasTable.SetMarginBottom(20));

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo para guardar el archivo PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "ReporteSubasta.pdf" // Nombre sugerido para el archivo PDF
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
                    GenerateReportPdf(filePath);
                }
                catch (Exception ex)
                {
                    // Mostrar el error si ocurre algún problema al generar el PDF
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadingProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            var subastasAutocomplete = PopulateComboBox();

            var results = new Dictionary<string, object>
            {
                {"ComboboxItems", subastasAutocomplete },
            };

            e.Result = results;
        }

        private void LoadingProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Dictionary<string, object> results)
            {
                var subastas = (AutoCompleteStringCollection)results["ComboboxItems"];
                comboBox1.AutoCompleteCustomSource = subastas;
                comboBox1.DataSource = subastas;
                comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                LoadingPanel.Dispose();
                loadingForm.Close();
            }
        }

        private void ShowLoading()
        {
            loadingForm.FormBorderStyle = FormBorderStyle.None;
            loadingForm.Size = this.Size / 2;
            loadingForm.Dock = DockStyle.Fill;
            loadingForm.StartPosition = FormStartPosition.CenterParent;
            LoadingPanel.Tag = loadingForm;
            LoadingPanel.BringToFront();
            LoadingPanel.Visible = true;
            loadingForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex < 1)
            {

                selectedSubastaId = null;
                LoadStuff();
                label5.Text = "Viendo resumen de todas las subastas";
            }
            else
            {
                if (!int.TryParse(comboBox1.SelectedItem.ToString().Replace("Subasta N°", ""), out int subastaId))
                {
                    MessageBox.Show("Por favor ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                selectedSubastaId = subastaId;
                LoadStuff();
                label5.Text = $"Viendo resumen de la subasta N°{subastaId}";
            }
        }
    }
}
