namespace GezginRotası2;

public partial class PostcardSharePage : ContentPage
{
    private readonly Dictionary<string, (string ImageUrl, string Quote)> _cityPostcards = new()
    {
        { "Nevşehir (Kapadokya)", ("https://images.unsplash.com/photo-1608755728617-aefab37d2edd?q=80&w=1000", "“Peri bacalarının ve gökyüzündeki balonların masalsı diyarı...”") },
        { "İstanbul", ("https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=1000", "“Yedi tepeli şehirde martıların ve tarihin peşinde...”") },
        { "Kayseri", ("https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=1000", "“Erciyes'in heybeti ve Anadolu'nun lezzet durağı!”") },
        { "Trabzon", ("https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=1000", "“Yeşille mavinin kucaklaştığı Karadeniz sevdası...”") },
        { "İzmir", ("https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=1000", "“Kordon boyunda tatlı bir Ege esintisi ve gün batımı...”") },
        { "Gaziantep", ("https://images.unsplash.com/photo-1519869325930-281384150729?q=80&w=1000", "“Tarihin ve UNESCO tescilli lezzetlerin başkenti!”") }
    };

    public PostcardSharePage()
    {
        InitializeComponent();

        CityPicker.ItemsSource = _cityPostcards.Keys.ToList();
        CityPicker.SelectedIndex = 0;
        CardDateLabel.Text = $"📅 {DateTime.Now:dd MMMM yyyy}";
    }

    private void OnCitySelected(object sender, EventArgs e)
    {
        if (CityPicker.SelectedItem is string selectedCity && _cityPostcards.TryGetValue(selectedCity, out var info))
        {
            CardCityLabel.Text = $"📍 {selectedCity.ToUpper()}";
            CardQuoteLabel.Text = info.Quote;
            CardImage.Source = info.ImageUrl;
        }
    }

    private async void OnShareClicked(object sender, EventArgs e)
    {
        string city = CityPicker.SelectedItem?.ToString() ?? "Türkiye";
        await Share.Default.RequestAsync(new ShareTextRequest
        {
            Title = "Gezginin Rotası Kartpostalı",
            Text = $"🇹🇷 {city} şehrini 'Gezginin Rotası' uygulamasıyla keşfettim! Sen de Türkiye'nin 81 ilini keşfetmeye hazır mısın? 🎒✨",
            Uri = "https://github.com/GezgininRotasi"
        });
    }
}