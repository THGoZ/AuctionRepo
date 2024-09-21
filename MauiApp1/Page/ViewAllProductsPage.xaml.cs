using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
using System.Collections.ObjectModel;

namespace AuctionMobileApp.Page;

public partial class ViewAllProductsPage : ContentPage
{
    private readonly IAPIMaui _apicaller;

    public ObservableCollection<ProductoAPI> ProductoList { get; set; }
    public ViewAllProductsPage(IAPIMaui apicaller)
    {
        _apicaller = apicaller;
        InitializeComponent();
        ProductoList = new ObservableCollection<ProductoAPI>();
        BindingContext = this; // Make sure to set BindingContext
        LoadProductos(); // Load the products when the page is initialized
    }

    private async void LoadProductos()
    {
        ProductoList.Clear();
        var productos = await _apicaller.GetProductsWithOfertas();

        if (productos != null)
        {
            foreach (var producto in productos)
            {
                producto.Image = ConvertByteArrayToImageSource(producto.Imagen);
                ProductoList.Add(producto);
            }
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