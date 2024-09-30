using Auction.Core.Business.Interfaces;
using Auction.Core.Data.Interfaces;
using Krypton.Toolkit;

namespace AuctionDesktopProgram
{
    public partial class FormHome : KryptonForm
    {
        // private readonly ISubastaBusiness _subastaBusiness;
        private readonly IProductoBusiness _productoBusiness;

        public FormHome(IProductoBusiness productoBusiness)
        {
            _productoBusiness = productoBusiness;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SubastaDataGrid.DataSource = _productoBusiness.GetProductos();
        }
    }
}
