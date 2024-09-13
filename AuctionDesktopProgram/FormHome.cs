using Auction.Core.Business.Interfaces;
using Auction.Core.Data.Interfaces;
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
    }
}
