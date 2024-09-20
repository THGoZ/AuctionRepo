using AuctionMobileApp.Caller.Interfases;

namespace AuctionMobileApp.Page;

public partial class ViewWinnerPage : ContentPage
{
    private readonly IAPIMaui _apicaller;

    // Constructor recibe el apicaller y el Id de la subasta
    public ViewWinnerPage(IAPIMaui apicaller)
    {
        InitializeComponent();
        _apicaller = apicaller;

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
                    // Agregar los ganadores a la lista
                    allWinners.AddRange(winners);
                }
            }

            // Enlazar la lista de ganadores al BindingContext para que el CollectionView funcione
            BindingContext = new { GanadoresList = allWinners };
        }
        else
        {
            await DisplayAlert("Error", "No se pudieron cargar las subastas cerradas.", "OK");
        }
    }
}
