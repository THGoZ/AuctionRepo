using Auction.Core.Business;
using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;

namespace AuctionDesktopProgram
{
    public partial class Resumen : KryptonForm
    {
        private readonly ISubastaBusiness _SubastaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private ProductoWinner productoSeleccionado;
        private readonly int idSubasta;
        private readonly Loading loadingForm = new Loading();
        private SortableBindingList<ProductoWinner> productoWinnerBindingList;
        public Resumen(ISubastaBusiness subastaBusiness, IProductoBusiness productoBusiness, int idSubasta)
        {
            _productoBusiness = productoBusiness;
            _SubastaBusiness = subastaBusiness;
            this.idSubasta = idSubasta;
            InitializeComponent();
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            this.LoadingProcess.RunWorkerAsync();
            loadingForm.StartPosition = this.StartPosition;
            loadingForm.Size = this.Size;
            loadingForm.TopMost = true;
            loadingForm.ShowDialog();
        }

        private void kryptonDataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.CurrentCell != null)
            {
                productoSeleccionado = (ProductoWinner)kryptonDataGridView1.CurrentRow.DataBoundItem;
            }

            if (productoSeleccionado != null)
            {
                btnOfertas.Enabled = productoSeleccionado.TotalDeOfertas != 0;
                lblDescripcion.Text = productoSeleccionado.Descripcion;
                lblNombre.Text = productoSeleccionado.Nombre;
                lblPrecio.Text = productoSeleccionado.PrecioBase.ToString("C");


                if (productoSeleccionado.Imagen != null)
                {
                    using var ms = new MemoryStream(productoSeleccionado.Imagen);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var productosDeSubasta = _productoBusiness.GetProductoWinnersOfSubasta(idSubasta);
                var sortedProductos = new SortableBindingList<ProductoWinner>(productosDeSubasta);
                productoWinnerBindingList = sortedProductos;
                e.Result = sortedProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                var sortedProductos = e.Result as SortableBindingList<ProductoWinner>;
                kryptonDataGridView1.DataSource = sortedProductos;
                label3.Text = $"Productos de la subasta N°{idSubasta}";
                loadingForm.Close();
                if (sortedProductos.Count() == 0)
                {
                    MessageBox.Show("Esta subasta no tiene ningun producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Error al cargar los datos.{e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private SortableBindingList<ProductoWinner> SearchProductos(string searchTerm = "")
        {
            if (searchTerm.IsNullOrEmpty())
            {
                return productoWinnerBindingList;
            }
            else
            {
                var source = productoWinnerBindingList.Where(p => p.Nombre.ToLower().Contains(searchTerm.Trim().ToLower()) || p.Descripcion.ToLower().Contains(searchTerm.Trim().ToLower())).ToList();
                var sortablelist = new SortableBindingList<ProductoWinner>(source);
                return sortablelist;
            }
        }

        private void btnOfertas_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado != null)
            {
                FormOferta ofertaform = new FormOferta(_productoBusiness, productoSeleccionado);
                ofertaform.ShowDialog();
                this.LoadingProcess.RunWorkerAsync();
                loadingForm.StartPosition = this.StartPosition;
                loadingForm.Size = this.Size;
                loadingForm.TopMost = true;
                loadingForm.ShowDialog();
            }
        }

        private void txtFiltroDescipcion_TextChanged(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = SearchProductos(txtFiltroDescipcion.Text);
        }
    }
}
