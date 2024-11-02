using Auction.Core.Business.Interfaces;
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
    public partial class ProductosNoOfertados : Form
    {
        private readonly IProductoBusiness _productoBusiness;
        public ProductosNoOfertados(IProductoBusiness productoBusiness)
        {
            InitializeComponent();
            _productoBusiness = productoBusiness;

            CargarProductosNoOfertados();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarProductosNoOfertados()
        {
            // Obtener la lista de productos solicitados (pueden ser aquellos con solicitudes pendientes)
            var productosSolicitados = _productoBusiness.GetProductosSolicitados();

            // Verificar si hay productos
            if (productosSolicitados.Count() != 0)
            {
                kryptonDataGridView1.DataSource = productosSolicitados;
            }
            else
            {
                MessageBox.Show("No se encontraron productos solicitados pendientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
