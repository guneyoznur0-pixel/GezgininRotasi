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

        ApplyLocalization();
        LoadCulture();
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;

        Title = LocalizationService.T("CultureTitle");
        SongsSectionLabel.Text = LocalizationService.T("SongsSection");
        PeopleSectionLabel.Text = LocalizationService.T("PeopleSection");

        if (_city == "Tüm Türkiye" || _city == "All Turkey")
        {
            HeaderCityLabel.Text = isEn ? "📍 All Turkey Culture & Folk Songs" : "📍 Tüm Türkiye Kültürü & Türküleri";
            HeaderSubtitleLabel.Text = isEn 
                ? "Prominent figures born across Turkey & regional folk melodies" 
                : "O topraklarda doğmuş büyük insanlar ve dinlenecek türküler";
        }
        else
        {
            HeaderCityLabel.Text = isEn ? $"📍 {_city} Culture, Figures & Songs" : $"📍 {_city} Kültürü, Şahsiyetleri & Türküleri";
            HeaderSubtitleLabel.Text = isEn 
                ? $"Prominent historical figures & traditional folk songs of {_city}" 
                : $"{_city} ilimizin yetiştirdiği büyük şahsiyetler ve yöresel ezgiler";
        }
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
                string search = $"{song.Title} {song.Artist}";
                string uri = $"https://www.youtube.com/results?search_query={Uri.EscapeDataString(search)}";
                await Launcher.OpenAsync(new Uri(uri));
            }
            catch (Exception ex)
            {
                await DisplayAlert(
                    LocalizationService.IsEnglish ? "Info" : "Bilgi", 
                    LocalizationService.IsEnglish ? $"Could not play song: {ex.Message}" : $"Müzik açılamadı: {ex.Message}", 
                    LocalizationService.IsEnglish ? "OK" : "Tamam");
            }
        }
    }
}