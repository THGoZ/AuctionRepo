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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionDesktopProgram
{
    public partial class FormProductos : KryptonForm

    {
        private readonly ISubastaBusiness _SubastaBusiness;

        private readonly IProductoBusiness _productoBusiness;


        public FormProductos(ISubastaBusiness SubastaBusiness, IProductoBusiness productoBusiness)
        {
            _SubastaBusiness = SubastaBusiness;
            _productoBusiness = productoBusiness;
            InitializeComponent();
        }

        private void ProductosDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            
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

            var productos = _productoBusiness.GetProductos();

            var productosSinOfertas = productos
                .Where(p => p.Ofertas == null || p.Ofertas.Count == 0)
                .Select(o => new
            {
                NombreProducto = o.Nombre,
                Descripcion = o.Descripcion,
                Monto = o.PrecioBase
              
            }).ToList();

            ProductosSOdatagrid.DataSource = productosSinOfertas;
      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
