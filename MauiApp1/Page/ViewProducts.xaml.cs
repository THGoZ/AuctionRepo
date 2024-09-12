using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
using System.IO;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace AuctionMobileApp.Page;

public partial class ViewProducts : ContentPage
{
    private readonly IAPIMaui _apicaller;
    private int _IdSubasta;
    public ObservableCollection<ProductoAPI> ProductoList { get; set; }
    public ViewProducts(IAPIMaui apicaller, int idsubasta)
    {
        _apicaller = apicaller;
        _IdSubasta = idsubasta;
        InitializeComponent();
        ProductoList = new ObservableCollection<ProductoAPI>();
        BindingContext = this; // Make sure to set BindingContext
        LoadProductos(); // Load the products when the page is initialized
    }

    private async void LoadProductos()
    {
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
}
