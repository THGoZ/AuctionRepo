using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Krypton.Toolkit;
using System.Data;

namespace AuctionDesktopProgram
{
    public partial class Ganancias : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ISubastaBusiness _subastaBusiness;
        private Subasta Subasta;
        private readonly Loading loadingForm = new Loading();
        public Ganancias(IServiceProvider serviceProvider, ISubastaBusiness subastaBusiness)
        {
            _serviceProvider = serviceProvider;
            _subastaBusiness = subastaBusiness;
            InitializeComponent();
            //PopulateComboBox();
        }

        private AutoCompleteStringCollection PopulateComboBox()
        {
            AutoCompleteStringCollection subastas = [];
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(comboBox1.SelectedItem.ToString().Replace("Subasta N°", ""), out int subastaId))
                {
                    MessageBox.Show("Por favor ingrese un ID válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Subasta = _subastaBusiness.GetById(subastaId);
                UpdateDescription();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show($"No se encontró la subasta: {ex.Message}", "Subasta no encontrada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDescription()
        {
            if (Subasta is not null)
            {
                var total = CalcularTotalOfertas(Subasta);
                labelTotal.Text = total.ToString("C");
                labelPdeEmpresa.Text = (total * 0.10m).ToString("C");
                labelPdeVendedores.Text = (total * 0.90m).ToString("C");
                labelProdVendidos.Text = Subasta.Productos.Where(p => p.Ofertas.Any()).Count().ToString();
                label2.Text = Subasta.Descripcion;
                kryptonButton1.Enabled = true;
            }
        }

        public decimal CalcularTotalOfertas(Subasta subasta)
        {
            decimal total = 0;
            if (subasta?.Productos == null)
                return total;

            foreach (var producto in subasta.Productos)
            {
                if (producto.Ofertas.Any())
                {
                    var highestbid = producto.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault();
                    total += producto.Ofertas.OrderByDescending(o => o.Monto).Select(o => o.Monto).FirstOrDefault();
                }
            }
            return total;
        }

        public void GenerateAuctionReportPdf(string filePath, Subasta subasta)
        {
            var total = CalcularTotalOfertas(Subasta);
            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    document.Add(new Paragraph($"Reporte de ganancias - Subasta Nº{subasta.IdSubasta}")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER));

                    document.Add(new Paragraph(subasta.Descripcion)
                        .SetFontSize(12)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetMarginBottom(10));

                    Table productTable = new Table(4);
                    productTable.AddHeaderCell(new Cell().Add(new Paragraph("#").SetBold()));
                    productTable.AddHeaderCell(new Cell().Add(new Paragraph("Nombre").SetBold()));
                    productTable.AddHeaderCell(new Cell().Add(new Paragraph("Precio de venta").SetBold()));
                    productTable.AddHeaderCell(new Cell().Add(new Paragraph("Fecha de venta").SetBold()));

                    foreach (var product in subasta.Productos)
                    {
                        if (product.Ofertas.Any())
                        {
                            var highestbid = product.Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault();
                            productTable.AddCell(new Cell().Add(new Paragraph(product.IdProducto.ToString())));
                            productTable.AddCell(new Cell().Add(new Paragraph(product.Nombre)));
                            productTable.AddCell(new Cell().Add(new Paragraph("$" + highestbid.Monto.ToString("N2")).SetFontColor(iText.Kernel.Colors.ColorConstants.GREEN)));
                            productTable.AddCell(new Cell().Add(new Paragraph(highestbid.Fecha.ToString("dd/MM/yyyy"))));
                        }
                    }

                    document.Add(new Paragraph("\nProductos vendidos").SetFontSize(14).SetBold().SetMarginTop(20));
                    document.Add(productTable.SetMarginBottom(10));

                    document.Add(new Paragraph("Recaudacion Total:").SetBold());
                    document.Add(new Paragraph(total.ToString("C")).SetFontSize(16).SetFontColor(iText.Kernel.Colors.ColorConstants.GREEN));

                    document.Add(new Paragraph("Porcentaje de Empresa:").SetBold());
                    document.Add(new Paragraph((total * 0.10m).ToString("C")).SetFontSize(16).SetFontColor(iText.Kernel.Colors.ColorConstants.GREEN));

                    document.Add(new Paragraph("Porcentaje de Vendedores:").SetBold());
                    document.Add(new Paragraph((total * 0.90m).ToString("C")).SetFontSize(16).SetFontColor(iText.Kernel.Colors.ColorConstants.GREEN));

                    document.Add(new Paragraph("Nº de Productos Vendidos:").SetBold());
                    document.Add(new Paragraph(Subasta.Productos.Where(p => p.Ofertas.Any()).Count().ToString()).SetFontSize(16).SetFontColor(iText.Kernel.Colors.ColorConstants.ORANGE));



                    document.Add(new Paragraph($"Fecha de cierre de subasta: {subasta.FechaCierre:dd/MM/yyy HH:mm}")
                        .SetFontSize(10)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetMarginTop(30));

                    document.Add(new Paragraph($"Creado en: {DateTime.Now}")
                        .SetFontSize(10)
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetMarginTop(5));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el archivo\n {ex}");
            }

            MessageBox.Show("Archivo PDF guardado correctamente!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Usage
        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = $"GananciasSubastaN°{Subasta.IdSubasta}.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GenerateAuctionReportPdf(saveFileDialog.FileName, Subasta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Ganancias_Load(object sender, EventArgs e)
        {
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.LoadingProcess.RunWorkerAsync();
            ShowLoading();
        }

        private void LoadingProcess_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            e.Result = PopulateComboBox();
        }

        private void LoadingProcess_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                var subastas = e.Result as AutoCompleteStringCollection;
                comboBox1.AutoCompleteCustomSource = subastas;
                comboBox1.DataSource = subastas;
            }
            ct.Dispose();
            loadingForm.Close();
        }

        private void ShowLoading() 
        {
            loadingForm.FormBorderStyle = FormBorderStyle.None;
            loadingForm.Size = this.Size / 2;
            loadingForm.Dock = DockStyle.Fill;
            loadingForm.StartPosition = FormStartPosition.CenterParent;
            ct.Tag = loadingForm;
            ct.BringToFront();
            ct.Visible = true;
            loadingForm.ShowDialog();
        }
    }
}
