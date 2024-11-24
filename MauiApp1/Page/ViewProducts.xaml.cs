using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
using System.IO;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using AuctionMobileApp.Service;

namespace AuctionMobileApp.Page;

public partial class ViewProducts : ContentPage
{
    public string PageTitle { get; set; }

    private readonly IAPIMaui _apicaller;
    private readonly int _IdSubasta;
    public ObservableCollection<ProductoAPI> ProductoList { get; set; }

    public ViewProducts(IAPIMaui apicaller, int subastaId)
    {
        PageTitle = $"Productos de la subasta N° {subastaId}";

        _apicaller = apicaller;
        _IdSubasta = subastaId;
        InitializeComponent();
        ProductoList = new ObservableCollection<ProductoAPI>();
        BindingContext = this; // Establecer el BindingContext para que funcione el binding

        LoadProductos(); // Cargar los productos al inicializar la vista
    }

    private async void LoadProductos()
    {
        // Intentar cargar productos desde la caché
        var cacheKey = $"ProductsAuction_{_IdSubasta}";
        var cachedProducts = CacheService.Get<List<ProductoAPI>>(cacheKey);

        if (cachedProducts != null && cachedProducts.Count > 0)
        {
            // Usar los datos de la caché
            ProductoList.Clear();
            foreach (var producto in cachedProducts)
            {
                ProductoList.Add(producto);
            }
        }
        else
        {
            // Llamar a la API si no hay datos en la caché
            var productos = await _apicaller.GetProductsOfAuctionWithOferta(_IdSubasta);
            if (productos != null)
            {
                foreach (var producto in productos)
                {
                    producto.Image = ConvertByteArrayToImageSource(producto.Imagen);
                    ProductoList.Add(producto); // Agregar a la ObservableCollection
                }

                // Guardar los productos obtenidos en la caché
                CacheService.AddOrUpdate(cacheKey, productos);
            }
        }
    }

    public ImageSource ConvertByteArrayToImageSource(byte[] imageBytes)
    {
        if (imageBytes == null || imageBytes.Length == 0)
            return null;

        return ImageSource.FromStream(() => new MemoryStream(imageBytes));
    }

    private static async void OnBackButtonPressed()
    {
        await Shell.Current.GoToAsync(".."); // Navegar a la página anterior
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        // No limpiar la lista para permitir reutilizar la caché
    }
}
