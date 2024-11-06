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
        private int? selectedSubastaId;

        private readonly ISubastaBusiness _SubastaBusiness;

        private readonly IProductoBusiness _productoBusiness;
        public bool MostrarSoloGanancias { get; set; }


        public FormProductos(ISubastaBusiness SubastaBusiness, IProductoBusiness productoBusiness)
        {
            _SubastaBusiness = SubastaBusiness;
            _productoBusiness = productoBusiness;
            InitializeComponent();
        }

        private void ProductosDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void SetSubastaId(int idSubasta)
        {
            selectedSubastaId = idSubasta;
        }

        public void Productos_Load(object sender, EventArgs e)
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

    }    
}
