namespace GezginRotası2;

public partial class PostcardSharePage : ContentPage
{
    private readonly Dictionary<string, (string ImageUrl, string Quote, string QuoteEn)> _cityPostcards = new()
    {
        { "Nevşehir (Kapadokya)", ("https://images.unsplash.com/photo-1608755728617-aefab37d2edd?q=80&w=1000", "“Peri bacalarının ve gökyüzündeki balonların masalsı diyarı...”", "“Fairytale land of fairy chimneys and hot air balloons in the sky...”") },
        { "İstanbul", ("https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=1000", "“Yedi tepeli şehirde martıların ve tarihin peşinde...”", "“Chasing history and seagulls across the city on seven hills...”") },
        { "Kayseri", ("https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=1000", "“Erciyes'in heybeti ve Anadolu'nun lezzet durağı!”", "“Majesty of Mount Erciyes and culinary capital of Anatolia!”") },
        { "Trabzon", ("https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=1000", "“Yeşille mavinin kucaklaştığı Karadeniz sevdası...”", "“Black Sea passion where lush green mountains embrace the blue sea...”") },
        { "İzmir", ("https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=1000", "“Kordon boyunda tatlı bir Ege esintisi ve gün batımı...”", "“Sweet Aegean breeze and magical sunset along Kordon promenade...”") },
        { "Gaziantep", ("https://images.unsplash.com/photo-1519869325930-281384150729?q=80&w=1000", "“Tarihin ve UNESCO tescilli lezzetlerin başkenti!”", "“Capital of ancient history and UNESCO-certified gastronomy!”") }
    };

    public PostcardSharePage()
    {
        InitializeComponent();

        CityPicker.ItemsSource = _cityPostcards.Keys.ToList();
        CityPicker.SelectedIndex = 0;
        CardDateLabel.Text = $"📅 {DateTime.Now:dd MMMM yyyy}";

        LocalizationService.LanguageChanged += (s, e) => ApplyLocalization();
        ApplyLocalization();
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;
        Title = LocalizationService.T("PostcardTitle");
        PageHeaderLabel.Text = isEn ? "Social Media Travel Postcard" : "Sosyal Medya Kartpostalı";
        PageSubtitleLabel.Text = isEn 
            ? "Share your travel postcard on Instagram Story or WhatsApp!" 
            : "Gezdiğin şehri Story'de veya WhatsApp'ta paylaş!";
        CityPicker.Title = isEn ? "Select Postcard City" : "Kartpostal Şehrini Seç";
        StampLabel.Text = isEn ? "✔ TRAVELER VERIFIED" : "✔ GEZGİN ONAYLI";
        CardBrandLabel.Text = isEn ? "🧭 Traveler's Route" : "🇹🇷 Gezginin Rotası";
        BtnShare.Text = isEn ? "📲 Share on Story & WhatsApp" : "📲 Story & WhatsApp'ta Paylaş";

        UpdateCardContent();
    }

    private void OnCitySelected(object sender, EventArgs e)
    {
        UpdateCardContent();
    }

    private void UpdateCardContent()
    {
        if (CityPicker.SelectedItem is string selectedCity && _cityPostcards.TryGetValue(selectedCity, out var info))
        {
            CardCityLabel.Text = $"📍 {selectedCity.ToUpper()}";
            CardQuoteLabel.Text = LocalizationService.IsEnglish ? info.QuoteEn : info.Quote;
            CardImage.Source = info.ImageUrl;
        }
    }

    private async void OnShareClicked(object sender, EventArgs e)
    {
        string city = CityPicker.SelectedItem?.ToString() ?? "Türkiye";
        bool isEn = LocalizationService.IsEnglish;

        await Share.Default.RequestAsync(new ShareTextRequest
        {
            Title = isEn ? "Traveler's Route Postcard" : "Gezginin Rotası Kartpostalı",
            Text = isEn 
                ? $"🇹🇷 Just explored {city} with 'Traveler's Route'! Are you ready to explore all 81 provinces of Turkey? 🎒✨" 
                : $"🇹🇷 {city} şehrini 'Gezginin Rotası' uygulamasıyla keşfettim! Sen de Türkiye'nin 81 ilini keşfetmeye hazır mısın? 🎒✨",
            Uri = "https://github.com/GezgininRotasi"
        });
    }
}