using AuctionMobileApp.Caller.Interfases;
using System.Collections.ObjectModel;

namespace AuctionMobileApp.Page;

public partial class ViewWinnerPage : ContentPage
{
    private readonly IAPIMaui _apicaller;
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
    }

    public ImageSource ConvertByteArrayToImageSource(byte[] imageBytes)
    {
        if (imageBytes == null || imageBytes.Length == 0)
            return null;

        MemoryStream stream = new MemoryStream(imageBytes);
        return ImageSource.FromStream(() => stream);
    }
}
