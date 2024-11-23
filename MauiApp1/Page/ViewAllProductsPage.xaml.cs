using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
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
            OnPropertyChanged(); // Notificar cambios para que el binding funcione
        }
    }

    public ObservableCollection<ProductoAPI> ProductoList { get; set; }

    public ViewAllProductsPage(IAPIMaui apicaller)
    {
        _apicaller = apicaller;
        InitializeComponent();
        ProductoList = new ObservableCollection<ProductoAPI>();
        BindingContext = this; // Make sure to set BindingContext
        //LoadProductos(); // Load the products when the page is initialized
    }

    private async void LoadProductos()
    {
        IsBusy = true; // Iniciar el indicador de carga
        ProductoList.Clear();
        var productos = await _apicaller.GetProductsWithOfertas();

        if (productos != null)
        {
            foreach (var producto in productos)
            {
                producto.Image = ConvertByteArrayToImageSource(producto.Imagen);
                ProductoList.Add(producto);
                await Task.Delay(50); 
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
        // Lógica adicional para manejar la limpieza o navegación si es necesario

        ProductoList.Clear();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Volver a cargar los productos de la API cuando la página aparezca
        LoadProductos();
    }

    // Implementación del INotifyPropertyChanged para actualizar la UI
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}