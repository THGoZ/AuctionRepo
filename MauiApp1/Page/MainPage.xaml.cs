using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
using AuctionMobileApp.Page;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace AuctionMobileApp
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private readonly IAPIMaui _apicaller;

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged(); // Notificar cambios para que el binding funcione
            }
        }

        public MainPage(IAPIMaui apicaller)
        {
            _apicaller = apicaller;

            BindingContext = this;

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
            IsBusy = true; // Iniciar el indicador de carga
            var subastas = await _apicaller.GetAuctions();

            foreach (var subasta in subastas)
            {
                subasta.Estado = subasta.FechaCierre >= DateTime.Now ? "Abierto" : "Cerrado";

            }

            productListView.ItemsSource = subastas;

            IsBusy = false; // Finalizar el indicador de carga
        }

        // Implementación del INotifyPropertyChanged para actualizar la UI
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

