using AuctionMobileApp.Page;

namespace AuctionMobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(ViewProducts), typeof(ViewProducts));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(ViewWinnerPage), typeof(ViewWinnerPage));
            Routing.RegisterRoute(nameof(ViewAllProductsPage), typeof(ViewAllProductsPage));
        }

    }
}
