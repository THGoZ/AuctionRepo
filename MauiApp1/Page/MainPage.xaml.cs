using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
using AuctionMobileApp.Page;
using System.Globalization;

namespace AuctionMobileApp
{
    public partial class MainPage : ContentPage
    {
        private readonly IAPIMaui _apicaller;

        public MainPage(IAPIMaui apicaller)
        {
            _apicaller = apicaller;

            InitializeComponent();
            LoadSubastas();
        }

        private void btnShowProducts_Clicked(object sender, EventArgs e)
        {
            LoadSubastas();
        }

        private async void productListView_ItemSelected(object sender, ItemTappedEventArgs e)
        {
            var subasta = (SubastaAPI)e.Item;


            await Navigation.PushAsync(new ViewProducts(_apicaller, subasta.IdSubasta));

        }

        private async void LoadSubastas()
        {
            var subastas = await _apicaller.GetAuctions();

            foreach (var subasta in subastas)
            {
                subasta.Estado = subasta.FechaCierre >= DateTime.Now ? "Abierto" : "Cerrado";

            }

            productListView.ItemsSource = subastas;

        }


    }
}

