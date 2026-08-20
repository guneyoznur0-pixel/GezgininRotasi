namespace GezginRotası2;

public partial class FoodsPage : ContentPage
{
    private readonly FoodDataService _foodService = new();
    private readonly string _city;
    private string _currentCategory = "Tümü";

    // 1. Alt Menü (TabBar) için boş kurucu
    public FoodsPage() : this("Tüm Türkiye")
    {
    }

    // 2. Şehir seçerek açmak için kurucu
    public FoodsPage(string selectedCity)
    {
        InitializeComponent();
        _city = string.IsNullOrWhiteSpace(selectedCity) ? "Tüm Türkiye" : selectedCity;

        CityTitleLabel.Text = _city == "Tüm Türkiye"
            ? "📍 Tüm Türkiye'nin Meşhur Lezzetleri"
            : $"📍 {_city} Meşhur Lezzetleri";

        LoadFoods();
    }

    private void LoadFoods()
    {
        var foods = _foodService.GetFoods(_city, _currentCategory);
        FoodsCollection.ItemsSource = foods;
    }

    private void OnCategoryFilterClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            _currentCategory = btn.Text;
            LoadFoods();
        }
    }

    private async void OnOpenMapClicked(object sender, EventArgs e)
    {
        if (sender is Button { BindingContext: FoodItem food })
        {
            try
            {
                string searchAddress = $"{food.Name} {food.City} {food.WhereToEat}";
                string uri = $"https://www.google.com/maps/search/?api=1&query={Uri.EscapeDataString(searchAddress)}";
                await Launcher.OpenAsync(new Uri(uri));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Bilgi", $"Harita açılamadı: {ex.Message}", "Tamam");
            }
        }
    }
}