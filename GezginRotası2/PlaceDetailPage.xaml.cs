namespace GezginRotası2;

public partial class PlaceDetailPage : ContentPage
{
    public PlaceDetailPage(Place place)
    {
        InitializeComponent();
        BindingContext = place;
    }

    private async void OnOpenMapClicked(object sender, EventArgs e)
    {
        if (BindingContext is Place place)
        {
            try
            {
                string query = Uri.EscapeDataString($"{place.Name} {place.Location}");
                string uri = $"https://www.google.com/maps/search/?api=1&query={query}";
                await Launcher.OpenAsync(new Uri(uri));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Hata", $"Harita açılamadı: {ex.Message}", "Tamam");
            }
        }
    }
}