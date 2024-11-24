using AuctionMobileApp.Caller.Interfases;
using AuctionMobileApp.Service;
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

    public ViewWinnerPage(IAPIMaui apicaller)
    {
        _apicaller = apicaller;
        InitializeComponent();
        GanadoresList = new ObservableCollection<ProductoWinner>();
        BindingContext = this;
    }

    private async void LoadWinners()
    {
        IsBusy = true; // Iniciar el indicador de carga

        // Intentar obtener los datos desde la caché
        var cachedWinners = CacheService.Get<List<ProductoWinner>>("WinnersCache");

        if (cachedWinners != null && cachedWinners.Count > 0)
        {
            // Usar los datos de la caché
            GanadoresList.Clear();
            foreach (var winner in cachedWinners)
            {
                GanadoresList.Add(winner);
            }
        }
        else
        {
            // Llamar a la API para obtener los datos
            var closedSubastas = await _apicaller.GetClosedSubastas();

            if (closedSubastas != null)
            {
                var allWinners = new List<ProductoWinner>();

                foreach (var subasta in closedSubastas)
                {
                    var winners = await _apicaller.GetWinners(subasta.IdSubasta);
                    if (winners != null)
                    {
                        foreach (var winner in winners)
                        {
                            if (winner.NombreGanador != null)
                            {
                                winner.Image = ConvertByteArrayToImageSource(winner.Imagen);
                                allWinners.Add(winner);
                            }
                        }
                    }
                }

                // Guardar los resultados en la caché
                CacheService.AddOrUpdate("WinnersCache", allWinners);

                // Actualizar la lista con los ganadores
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
        }

        IsBusy = false; // Finalizar el indicador de carga
    }

    public ImageSource ConvertByteArrayToImageSource(byte[] imageBytes)
    {
        if (imageBytes == null || imageBytes.Length == 0)
            return null;

        return ImageSource.FromStream(() => new MemoryStream(imageBytes));
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        // No limpiar la lista para permitir el uso de la caché
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadWinners(); // Cargar ganadores desde la caché o API
    }

    // Implementación del INotifyPropertyChanged para actualizar la UI
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
