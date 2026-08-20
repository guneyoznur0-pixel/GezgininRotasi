namespace GezginRotası2;

public partial class PlacesPage : ContentPage
{
    private readonly PlaceDataService _dataService = new();
    private readonly string _city;
    private readonly string _category;

    public PlacesPage(string selectedCity, string selectedCategory = "")
    {
        InitializeComponent();

        _city = selectedCity;
        _category = selectedCategory;

        Title = string.IsNullOrEmpty(_category)
            ? $"{_city} - Gezilecek Yerler"
            : $"{_city} - {_category}";
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var (places, errorMessage) = await _dataService.GetPlacesWithCacheAsync(_city, _category);

        if (!string.IsNullOrEmpty(errorMessage))
        {
            await DisplayAlert("Bilgi / Hata", errorMessage, "Tamam");
        }

        PlacesCollection.ItemsSource = places;
    }

    private async void OnPlaceSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count > 0 && e.CurrentSelection[0] is Place selectedPlace)
        {
            await Navigation.PushAsync(new PlaceDetailPage(selectedPlace));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}