using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using AuctionDesktopProgram.Helper;
using BlazorBootstrap;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.IdentityModel.Tokens;
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
    public partial class FormOferta : KryptonForm
    {
        private readonly ProductoWinner _producto;
        private readonly IProductoBusiness _productoBusiness;
        private readonly Loading loadingForm = new Loading();
        public FormOferta(IProductoBusiness productoBusiness, ProductoWinner producto)
        {
            _productoBusiness = productoBusiness;
            _producto = producto;
            InitializeComponent();
            if (producto == null || producto.Id == null)
            {
                MessageBox.Show("Como llegaste aca??", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private SortableBindingList<OfertasDisplay> GridDataGet()
        {
            try
            {
                var ofertas = _productoBusiness.GetOfertasOfProducto((int)_producto.Id)
                                               .Select(o => new OfertasDisplay()
                                               {
                                                   Monto = o.Monto,
                                                   Fecha = o.Fecha,
                                                   Nombre = o.Usuario.Nombre,
                                                   Apellido = o.Usuario.Apellido
                                               })
                                               .ToList();

                var sortableOfertas = new SortableBindingList<OfertasDisplay>(ofertas);
                return sortableOfertas;
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al cargar los datos.{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new SortableBindingList<OfertasDisplay>(new List<OfertasDisplay>());
                this.Close();
            }
        }

        private void Ofertas_Load(object sender, EventArgs e)
        {
            ShowLoading();
            this.LoadingProcess.RunWorkerAsync();
        }

        private void LoadingProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            lblTitle.Text = $"Ofertas del producto N°{_producto.Id}";
            lblDescription.Text = $"Viendo ofertas del producto N° con precio base de {_producto.PrecioBase.ToString("C")}";
            e.Result = GridDataGet();
        }

        private void LoadingProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                var ofertas = e.Result as SortableBindingList<OfertasDisplay>;
                ofertasDataGrid.DataSource = ofertas;
                LoadingPanel.Dispose();
                loadingForm.Close();
            }
            else
            {
                MessageBox.Show($"Error al cargar los datos.{e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ShowLoading()
        {
            loadingForm.TopLevel = false;
            loadingForm.FormBorderStyle = FormBorderStyle.None;
            loadingForm.Dock = DockStyle.Fill;
            LoadingPanel.Controls.Add(loadingForm);
            LoadingPanel.Tag = loadingForm;
            LoadingPanel.BringToFront();
            LoadingPanel.Visible = true;
            loadingForm.Show();
        }
    }
}
