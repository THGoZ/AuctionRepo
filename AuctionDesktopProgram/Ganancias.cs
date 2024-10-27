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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionDesktopProgram
{
    public partial class Ganancias : KryptonForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ISubastaBusiness _subastaBusiness;
        private Subasta Subasta;
        public Ganancias(IServiceProvider serviceProvider, ISubastaBusiness subastaBusiness)
        {
            _serviceProvider = serviceProvider;
            _subastaBusiness = subastaBusiness;
            InitializeComponent();
            PopulateComboBox();

        }

        private void PopulateComboBox()
        {
            AutoCompleteStringCollection subastas = [];
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            try
            {
                var allsubastas = _subastaBusiness.GetSuccessful();
                if (allsubastas is null || allsubastas.Count == 0) {
                    return;
                }

                subastas.AddRange(allsubastas.Select(s => ($"Subasta N°{s.IdSubasta}")).ToArray());
                comboBox1.AutoCompleteCustomSource = subastas;
                comboBox1.DataSource = subastas;
                comboBox1.SelectedItem = comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (subasta?.Productos == null)
                return 0;

            return subasta.Productos
                .Where(p => p.Ofertas != null)
                .SelectMany(p => p.Ofertas)
                .Sum(o => o.Monto);
        }
    }
}
