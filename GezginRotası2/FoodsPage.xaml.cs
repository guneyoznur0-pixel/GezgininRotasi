namespace GezginRotası2;

public partial class FoodsPage : ContentPage
{
    private readonly FoodDataService _foodService = new();
    private readonly string _city;
    private string _currentCategory = "Tümü";

    public FoodsPage() : this("Tüm Türkiye")
    {
    }

    public FoodsPage(string selectedCity)
    {
        InitializeComponent();
        _city = string.IsNullOrWhiteSpace(selectedCity) ? "Tüm Türkiye" : selectedCity;

        ApplyLocalization();
        LoadFoods();
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;

        BtnFoodAll.Text = isEn ? "All" : "Tümü";
        BtnFoodMain.Text = isEn ? "Main Course" : "Ana Yemek";
        BtnFoodDessert.Text = isEn ? "Desserts" : "Tatlı";
        BtnFoodStreet.Text = isEn ? "Street Food" : "Sokak Lezzeti";
        BtnFoodBreakfast.Text = isEn ? "Breakfast" : "Kahvaltılık";

        if (_city == "Tüm Türkiye" || _city == "All Turkey")
        {
            CityTitleLabel.Text = isEn ? "📍 All Turkey Gastronomy & Delicacies" : "📍 Tüm Türkiye Meşhur Lezzetleri";
            CitySubtitleLabel.Text = isEn 
                ? "Authentic regional dishes, famous sweets & where to eat" 
                : "O yöreye ait en meşhur imza lezzetler ve restoran tavsiyeleri";
        }
        else
        {
            CityTitleLabel.Text = isEn ? $"📍 {_city} Culinary Guide & Famous Foods" : $"📍 {_city} Meşhur Lezzetleri";
            CitySubtitleLabel.Text = isEn 
                ? $"Signature regional dishes and restaurant recommendations in {_city}" 
                : $"{_city} ilimizin en meşhur yöresel yemekleri ve mekan tavsiyeleri";
        }
    }

    private void LoadFoods()
    {
        // Normalize category if English was chosen
        string searchCategory = _currentCategory;
        if (_currentCategory == "All" || _currentCategory == "Tümü") searchCategory = "Tümü";
        else if (_currentCategory == "Main Course" || _currentCategory == "Ana Yemek") searchCategory = "Ana Yemek";
        else if (_currentCategory == "Desserts" || _currentCategory == "Tatlı") searchCategory = "Tatlı";
        else if (_currentCategory == "Street Food" || _currentCategory == "Sokak Lezzeti") searchCategory = "Sokak Lezzeti";
        else if (_currentCategory == "Breakfast" || _currentCategory == "Kahvaltılık") searchCategory = "Kahvaltılık";

        var foods = _foodService.GetFoods(_city, searchCategory);
        FoodsCollection.ItemsSource = foods;
    }

    private void OnCategoryFilterClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            _currentCategory = btn.Text;

            // Reset styles
            BtnFoodAll.BackgroundColor = Color.FromArgb("#1E2330");
            BtnFoodMain.BackgroundColor = Color.FromArgb("#1E2330");
            BtnFoodDessert.BackgroundColor = Color.FromArgb("#1E2330");
            BtnFoodStreet.BackgroundColor = Color.FromArgb("#1E2330");
            BtnFoodBreakfast.BackgroundColor = Color.FromArgb("#1E2330");

            btn.BackgroundColor = Color.FromArgb("#FF7F00");

            LoadFoods();
        }
    }

    private async void OnOpenMapClicked(object sender, EventArgs e)
    {
        if (sender is Button { BindingContext: FoodItem food })
        {
            try
            {
                // WhereToEat'teki ilk mekanı veya yemek adını haritada arat
                string query = !string.IsNullOrWhiteSpace(food.WhereToEat)
                    ? $"{food.WhereToEat.Split('/')[0].Trim()} {food.City}"
                    : $"{food.Name} {food.City}";

                string uri = $"https://www.google.com/maps/search/?api=1&query={Uri.EscapeDataString(query)}";
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