using AuctionMobileApp.Caller.Interfases;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AuctionMobileApp.Page;

public partial class ViewWinnerPage : ContentPage, INotifyPropertyChanged
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

    public ObservableCollection<ProductoWinner> GanadoresList { get; set; }
    // Constructor recibe el apicaller y el Id de la subasta
    public ViewWinnerPage(IAPIMaui apicaller)
    {
        InitializeComponent();
        _apicaller = apicaller;
        GanadoresList = new ObservableCollection<ProductoWinner>();
        BindingContext = this;
        // Llama al método para cargar los ganadores
        LoadWinners();
    }

    private async void LoadWinners()
    {
        IsBusy = true; // Iniciar el indicador de carga
        // Obtener las subastas cerradas
        var closedSubastas = await _apicaller.GetClosedSubastas();

        if (closedSubastas != null)
        {
            var allWinners = new List<ProductoWinner>();

            // Por cada subasta cerrada, obtener los ganadores
            foreach (var subasta in closedSubastas)
            {
                var winners = await _apicaller.GetWinners(subasta.IdSubasta);
                if (winners != null)
                {
                    // Convertir imagen de byte[] a ImageSource
                    foreach (var winner in winners)
                    {
                        winner.Image = ConvertByteArrayToImageSource(winner.Imagen);
                        allWinners.Add(winner);
                    }
                }
            }

            // Actualizar la colección de ganadores
            GanadoresList.Clear();
            foreach (var winner in allWinners)
            {
                GanadoresList.Add(winner);
            }
        }
        else
        {
            await DisplayAlert("Error", "No se pudieron cargar las subastas cerradas.", "OK");
        }
        IsBusy = false; // Finalizar el indicador de carga
    }

    public ImageSource ConvertByteArrayToImageSource(byte[] imageBytes)
    {
        if (imageBytes == null || imageBytes.Length == 0)
            return null;

        MemoryStream stream = new MemoryStream(imageBytes);
        return ImageSource.FromStream(() => stream);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        // Lógica adicional para manejar la limpieza o navegación si es necesario

        GanadoresList.Clear();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Volver a cargar los productos de la API cuando la página aparezca
        LoadWinners();
    }

    // Implementación del INotifyPropertyChanged para actualizar la UI
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
