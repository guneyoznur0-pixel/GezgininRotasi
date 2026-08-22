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

        ApplyLocalization();
        LoadPlaces();
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;

        BtnFilterAll.Text = isEn ? "All" : "Tümü";
        BtnFilterSights.Text = isEn ? "Attractions" : "Gezilecek";
        BtnFilterMuseums.Text = isEn ? "Museums" : "Müzeler";

        if (_city == "Tüm Türkiye" || _city == "All Turkey")
        {
            PageTitleLabel.Text = isEn ? "📍 All Turkey Sights & Museums" : "📍 Tüm Türkiye Gezilecek Yerler & Müzeler";
            PageSubtitleLabel.Text = isEn 
                ? "Historical monuments, ancient ruins, canyons & museums" 
                : "Tarihi yapılar, açık hava müzeleri ve eşsiz doğal güzellikler";
        }
        else
        {
            PageTitleLabel.Text = isEn ? $"📍 {_city} Attractions & Museums" : $"📍 {_city} Gezilecek Yerler & Müzeler";
            PageSubtitleLabel.Text = isEn 
                ? $"Top curated sights, nature parks & ruins in {_city}" 
                : $"{_city} ilimizin en popüler tarihi ve doğal güzellikleri";
        }
    }

    private void LoadPlaces()
    {
        // Normalize category if English was chosen
        string searchCategory = _currentCategory;
        if (_currentCategory == "All" || _currentCategory == "Tümü") searchCategory = "Tümü";
        else if (_currentCategory == "Attractions" || _currentCategory == "Sights") searchCategory = "Gezilecek";
        else if (_currentCategory == "Museums") searchCategory = "Müzeler";

        var places = _placesService.GetPlaces(_city, searchCategory);
        PlacesCollection.ItemsSource = places;
    }

    private void OnCategoryFilterClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            _currentCategory = btn.Text;

            // Reset styles
            BtnFilterAll.BackgroundColor = Color.FromArgb("#1E2330");
            BtnFilterSights.BackgroundColor = Color.FromArgb("#1E2330");
            BtnFilterMuseums.BackgroundColor = Color.FromArgb("#1E2330");

            btn.BackgroundColor = Color.FromArgb("#FF7F00");

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
                await DisplayAlert(
                    LocalizationService.IsEnglish ? "Info" : "Bilgi", 
                    LocalizationService.IsEnglish ? $"Could not open map: {ex.Message}" : $"Harita açılamadı: {ex.Message}", 
                    LocalizationService.IsEnglish ? "OK" : "Tamam");
            }
        }
    }
}