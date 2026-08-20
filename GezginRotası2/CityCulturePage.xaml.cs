namespace GezginRotası2;

public partial class CityCulturePage : ContentPage
{
    private readonly CultureDataService _cultureService = new();
    private readonly string _city;

    public CityCulturePage() : this("Tüm Türkiye")
    {
    }

    public CityCulturePage(string city)
    {
        InitializeComponent();
        _city = string.IsNullOrWhiteSpace(city) ? "Tüm Türkiye" : city;

        HeaderCityLabel.Text = _city == "Tüm Türkiye"
            ? "📍 Tüm Türkiye Kültürü & Türküleri"
            : $"📍 {_city} Kültürü, Şahsiyetleri & Türküleri";

        LoadCulture();
    }

    private void LoadCulture()
    {
        var (people, songs) = _cultureService.GetCultureData(_city);
        PeopleCollection.ItemsSource = people;
        SongsCollection.ItemsSource = songs;
    }

    // Şarkıyı doğrudan YouTube'da aratıp çalar
    private async void OnPlaySongClicked(object sender, EventArgs e)
    {
        if (sender is Button { BindingContext: FolkSong song })
        {
            try
            {
                string search = $"{song.Title} {song.Artist} dinle";
                string uri = $"https://www.youtube.com/results?search_query={Uri.EscapeDataString(search)}";
                await Launcher.OpenAsync(new Uri(uri));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Bilgi", $"Müzik açılamadı: {ex.Message}", "Tamam");
            }
        }
    }
}