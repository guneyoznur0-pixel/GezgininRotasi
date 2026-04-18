namespace GezginRotası2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private async void OnGezilecekYerlerTapped(object sender, EventArgs e)
    {
        // Picker'dan seçilen şehri al, eğer seçilmemişse "Tüm Türkiye" de
        string selectedCity = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";

        // Yeni sayfaya bu şehri gönder
        await Navigation.PushAsync(new PlacesPage(selectedCity));
    }
}