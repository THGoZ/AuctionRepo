using AuctionMobileApp.Caller;
using AuctionMobileApp.Caller.Interfases;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
namespace AuctionMobileApp.Page;
public partial class ViewAllProductsPage : ContentPage, INotifyPropertyChanged
{
    private readonly IAPIMaui _apicaller;
    private bool _isBusy;
    private bool _isLoading;
    private ICommand _refreshCommand;
    public ICommand RefreshCommand => _refreshCommand ??= new Command(async () => await RefreshProductos());
    private bool _isRefreshing;
    private int _currentPage = 1;
    private const int PageSize = 50;
    private bool _hasMoreItems;
    private bool _productsLoaded;
    private ICommand _loadMoreCommand;
    public ICommand LoadMoreCommand => _loadMoreCommand ??= new Command(async () => await LoadMoreItems());
    public bool IsBusy
    {
        get => _isBusy;
        set
        {
            _isBusy = value;
            OnPropertyChanged(); // Notificar cambios para que el binding funcione
        }
    }

    public bool IsRefreshing
    {
        get => _isRefreshing;
        set
        {
            _isRefreshing = value;
            OnPropertyChanged();
        }
    }

    public bool HasMoreItems
    {
        get => _hasMoreItems;
        set
        {
            _hasMoreItems = value;
            OnPropertyChanged();
        }
    }

    private readonly IMemoryCache _cache = new MemoryCache(new MemoryCacheOptions());
    public ObservableCollection<ProductoAPI> ProductoList { get; set; }
    public ViewAllProductsPage(IAPIMaui apicaller)
    {
        _apicaller = apicaller;
        InitializeComponent();
        ProductoList = new ObservableCollection<ProductoAPI>();
        BindingContext = this;
    }

    private async void OnRemainingItemsThresholdReached(object sender, EventArgs e)
    {
        await LoadMoreItems();
    }

    private async Task LoadMoreItems()
    {
        Debug.WriteLine("LoadMoreItems called");
        if (IsBusy || !HasMoreItems) return;
        _currentPage++;
        await LoadProductos(false);
    }

    private async Task LoadProductos(bool refresh = true)
    {
        if (_productsLoaded) return;
        IsBusy = true;
        _isLoading = true;
        ProductoList.Clear();

        var result = await _apicaller.GetPaginatedProducts(_currentPage, PageSize);

        if (refresh)
        {
            _currentPage = 1;
            ProductoList.Clear();
        }


        if (result != null)
        {

            if (result.Items != null)
            {
                foreach (var producto in result.Items)
                {
                    producto.Image = await ConvertByteArrayToImageSourceAsync(producto.Imagen);
                    ProductoList.Add(producto);
                }
            }
            if (result.HasNext)
            {
                HasMoreItems = true;
            }
            _productsLoaded = true;
            _isLoading = false;
            IsBusy = false;
            IsRefreshing = false;
        }
    }
    private async Task RefreshProductos()
    {
        IsRefreshing = true;
        _productsLoaded = false;
        await LoadProductos(true);
    }

    private async Task<ImageSource> ConvertByteArrayToImageSourceAsync(byte[] imageBytes)
    {
        if (imageBytes == null || imageBytes.Length == 0)
            return null;

        string cacheKey = Convert.ToBase64String(imageBytes);

        if (_cache.TryGetValue(cacheKey, out ImageSource cachedImage))
            return cachedImage;

        var imageSource = await Task.Run(() =>
        {
            using var stream = new MemoryStream(imageBytes);
            var source = ImageSource.FromStream(() => new MemoryStream(imageBytes));
            _cache.Set(cacheKey, source, TimeSpan.FromMinutes(30));
            return source;
        });

        return imageSource;
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        // Lógica adicional para manejar la limpieza o navegación si es necesario
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        // Volver a cargar los productos de la API cuando la página aparezca
        AwaitLoad();
    }

    public async void AwaitLoad()
    {
        await LoadProductos();
    }
    // Implementación del INotifyPropertyChanged para actualizar la UI
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}