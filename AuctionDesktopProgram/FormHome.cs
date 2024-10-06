using Auction.Core.Business.Interfaces;
using Auction.Core.Data.Interfaces;
using Auction.Core.Entities;
using Krypton.Toolkit;

namespace AuctionDesktopProgram
{
    public partial class FormHome : KryptonForm
    {
        private readonly ISubastaBusiness _subastaBusiness;

        public FormHome(ISubastaBusiness subastaBusiness)
        {
            _subastaBusiness = subastaBusiness;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SubastaDataGrid.DataSource = _subastaBusiness.GetAll();
        }

        private void SubastaDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            Console.WriteLine(e);
            Subasta subasta = SubastaDataGrid.CurrentRow.DataBoundItem as Subasta;
            bigLabel1.Text = subasta.Descripcion.ToString();
        }
    }
}
