using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
using AuctionMobileApp.Service;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AuctionMobileApp.Page;

public partial class ViewAllProductsPage : ContentPage, INotifyPropertyChanged
{
    private readonly IAPIMaui _apicaller;

    private bool _isBusy;
    public bool IsBusy
    {
        get => _isBusy;
        set
        {
            _isBusy = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<ProductoAPI> ProductoList { get; set; }

    public ViewAllProductsPage(IAPIMaui apicaller)
    {
        _apicaller = apicaller;
        InitializeComponent();
        ProductoList = new ObservableCollection<ProductoAPI>();
        BindingContext = this;
    }

    private async void LoadProductos()
    {
        IsBusy = true;

        var cachedProductos = CacheService.Get<List<ProductoAPI>>("ProductosCache");

        if (cachedProductos != null && cachedProductos.Count > 0)
        {
            ProductoList.Clear();
            foreach (var producto in cachedProductos)
            {
                producto.Image = await Task.Run(() => ConvertByteArrayToImageSource(producto.Imagen));
                ProductoList.Add(producto);
            }
        }
        else
        {
            var productos = await _apicaller.GetOpenAuctionsProducts();
            if (productos != null)
            {
                ProductoList.Clear();
                foreach (var producto in productos)
                {
                    producto.Image = await Task.Run(() => ConvertByteArrayToImageSource(producto.Imagen));
                    ProductoList.Add(producto);
                }
                CacheService.AddOrUpdate("ProductosCache", productos);
            }
        }

        IsBusy = false;
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
        LoadProductos(); // Cargar productos desde la caché o API
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
