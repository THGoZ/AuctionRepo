using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
using System.IO;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace AuctionMobileApp.Page;

public partial class ViewProducts : ContentPage
{
    public string PageTitle { get; set; }

    private readonly IAPIMaui _apicaller;
    private int _IdSubasta;
    public ObservableCollection<ProductoAPI> ProductoList { get; set; }
    public ViewProducts(IAPIMaui apicaller, int subastaId)
    {
        PageTitle = $"Productos de la subasta N° {subastaId}";

        _apicaller = apicaller;
        _IdSubasta = subastaId;
        InitializeComponent();
        ProductoList = new ObservableCollection<ProductoAPI>();
        BindingContext = this; // Make sure to set BindingContext
        LoadProductos(); // Load the products when the page is initialized
    }

    //public void ApplyQueryAttributes(IDictionary<string, object> query)
    //{
    //    _IdSubasta = int.Parse(query["subastaId"].ToString());
    //    LoadProductos();
    //}
    private async void LoadProductos()
    {
        ProductoList.Clear();
        var productos = await _apicaller.GetProductsOfAuctionWithOferta(_IdSubasta);
        foreach (var producto in productos)
        {
            producto.Image = ConvertByteArrayToImageSource(producto.Imagen);
            ProductoList.Add(producto);  // Add to ObservableCollection
        }
    }

    public ImageSource ConvertByteArrayToImageSource(byte[] imageBytes)
    {
        if (imageBytes == null || imageBytes.Length == 0)
            return null;

        MemoryStream stream = new MemoryStream(imageBytes);
        return ImageSource.FromStream(() => stream);
    }

    private static async void OnBackButtonPressed()
    {
        //Console.WriteLine("OnBackButtonPressed called");
        //Shell.Current.GoToAsync("///MainPage").ConfigureAwait(false);
        //return true; // Indica que el evento ha sido manejado
        await Shell.Current.GoToAsync("..");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        // Lógica adicional para manejar la limpieza o navegación si es necesario
    }

}

