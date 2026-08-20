namespace GezginRotası2;

public partial class PlacesPage : ContentPage
{
    private readonly PlacesDataService _placesService = new();
    private readonly string _city;
    private string _currentCategory = "Tümü";

    public PlacesPage() : this("Tüm Türkiye", "Tümü")
    {
    }

    public PlacesPage(string selectedCity, string category = "Tümü")
    {
        InitializeComponent();
        _city = string.IsNullOrWhiteSpace(selectedCity) ? "Tüm Türkiye" : selectedCity;
        _currentCategory = string.IsNullOrWhiteSpace(category) ? "Tümü" : category;

        PageTitleLabel.Text = _city == "Tüm Türkiye"
            ? "📍 Tüm Türkiye Gezilecek Yerler & Müzeler"
            : $"📍 {_city} Gezilecek Yerler & Müzeler";

        LoadPlaces();
    }

    private void LoadPlaces()
    {
        var places = _placesService.GetPlaces(_city, _currentCategory);
        PlacesCollection.ItemsSource = places;
    }

    private void OnCategoryFilterClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            _currentCategory = btn.Text;
            LoadPlaces();
        }
    }

    private async void OnMapDirectionsClicked(object sender, EventArgs e)
    {
        if (sender is Button { BindingContext: PlaceItem place })
        {
            try
            {
                string search = $"{place.Name} {place.City}";
                string uri = $"https://www.google.com/maps/search/?api=1&query={Uri.EscapeDataString(search)}";
                await Launcher.OpenAsync(new Uri(uri));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Bilgi", $"Harita açılamadı: {ex.Message}", "Tamam");
            }
        }
    }
}