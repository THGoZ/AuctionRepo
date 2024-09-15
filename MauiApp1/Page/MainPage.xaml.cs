using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
using AuctionMobileApp.Page;

namespace AuctionMobileApp
{
    public partial class MainPage : ContentPage
    {
        private readonly IAPIMaui _apicaller;
        public MainPage(IAPIMaui apicaller, MAUIClientOptions config)
        {
            _apicaller = apicaller;

            InitializeComponent();
            LoadSubastas();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
        }

        private async void btnShowProducts_Clicked(object sender, EventArgs e)
        {
            LoadSubastas();
        }

        private async void productListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var subasta = (SubastaAPI)e.Item;
            //await Navigation.PushModalAsync(new ViewProducts(_apicaller, subasta.IdSubasta));
            //await Shell.Current.GoToAsync($"///ViewProducts?subastaId={subasta.IdSubasta}");

            await Navigation.PushAsync(new ViewProducts(_apicaller, subasta.IdSubasta));

        }

        private async void LoadSubastas()
        {
            var subastas = await _apicaller.GetAuctions();
            productListView.ItemsSource = subastas;
        }
    }
}
