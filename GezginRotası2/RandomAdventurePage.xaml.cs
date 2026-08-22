namespace GezginRotası2;

public partial class RandomAdventurePage : ContentPage
{
    private readonly List<(string City, string Region, string Place, string Food, string Song)> _destinations = new()
    {
        ("Kayseri", "İç Anadolu", "Erciyes Dağı & Tarihi Kazancılar Çarşısı", "Kayseri Yağlaması & Mantı", "Gesi Bağları"),
        ("Mardin", "Güneydoğu", "Deyrulzafaran Manastırı & Eski Mardin Evleri", "Mardin Kebabı & Süryani Çöreği", "Mardin Kapı Şen Olur"),
        ("Trabzon", "Karadeniz", "Sümela Manastırı & Uzungöl", "Akçaabat Köftesi & Kuymak", "Gelevera Deresi"),
        ("Bursa", "Marmara", "Uludağ & Tarihi Kozahan", "İskender Kebap & Kestane Şekeri", "Bursa'nın Ufak Tefek Taşları"),
        ("İzmir", "Ege", "Tarihi Asansör & Şirince Köyü", "İzmir Kumrusu & Boyoz", "İzmir'in Kavakları"),
        ("Nevşehir", "İç Anadolu", "Göreme Açık Hava Müzesi & Peri Bacaları", "Testi Kebabı", "Kapadokya Rüzgarı"),
        ("Gaziantep", "Güneydoğu", "Zeugma Mozaik Müzesi & Bakırcılar Çarşısı", "Küşleme & Antep Fıstıklı Baklava", "Antep'in Hamamları"),
        ("Çanakkale", "Marmara", "Truva Antik Kenti & Aynalı Çarşı", "Peynir Helvası & Sardalya", "Çanakkale Türküsü"),
        ("Rize", "Karadeniz", "Ayder Yaylası & Zilkale", "Rize Kavurması & Muhlama", "Koyverdun Gittun Beni"),
        ("Antalya", "Akdeniz", "Kaleiçi & Düden Şelalesi", "Antalya Usulü Piyaz & Yanık Dondurma", "Akdeniz Akşamları"),
        ("Sivas", "İç Anadolu", "Divriği Ulu Camii & Çifte Minareli Medrese", "Sivas Köftesi & Katmer", "Uzun İnce Bir Yoldayım"),
        ("Şanlıurfa", "Güneydoğu", "Göbeklitepe & Balıklıgöl", "Urfa Kebabı & Çiğ Köfte", "Urfa'nın Etrafı Dumanlı Dağlar")
    };

    public RandomAdventurePage()
    {
        InitializeComponent();
        LocalizationService.LanguageChanged += (s, e) => ApplyLocalization();
        ApplyLocalization();
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;
        Title = LocalizationService.T("WheelTitle");
        PageHeaderLabel.Text = isEn ? "Where to Go? What to Eat?" : "Nereye Gitsem? Ne Yesem?";
        PageSubtitleLabel.Text = isEn 
            ? "Can't decide? Press the lucky spin and let Turkey plan your surprise adventure!" 
            : "Kararsız kaldıysan butona bas, Türkiye sana bir rota çizsin!";
        SpinButton.Text = isEn ? "✨ Pick a Surprise Route for Me!" : "✨ Bana Sürpriz Bir Rota Seç!";

        ResultCityTitleLabel.Text = isEn ? "🎉 Your Lucky Destination:" : "🎉 Şansına Çıkan Şehir:";
        LblPlaceHeading.Text = isEn ? "🏛️ Secret Spot / Must-See" : "🏛️ Gezilecek Saklı Köşe";
        LblFoodHeading.Text = isEn ? "🍲 Iconic Dish to Taste" : "🍲 Tadılacak Meşhur Lezzet";
        LblSongHeading.Text = isEn ? "🎶 Regional Road Song" : "🎶 Yol Şarkısı / Türküsü";
        BtnMapExplore.Text = isEn ? "🗺️ View City in Google Maps" : "🗺️ Bu Şehri Google Haritalar'da Gör";
    }

    private async void OnSpinClicked(object sender, EventArgs e)
    {
        SpinButton.IsEnabled = false;
        ResultCard.IsVisible = false;

        // Eğlenceli Döndürme & Zıplama Animasyonu
        var rand = new Random();
        for (int i = 0; i < 6; i++)
        {
            DiceLabel.Text = (i % 2 == 0) ? "🎲" : "✨";
            await DiceBorder.RotateTo(i * 60, 80);
            await DiceBorder.ScaleTo(1.15, 80);
            await DiceBorder.ScaleTo(1.0, 80);
        }

        var picked = _destinations[rand.Next(_destinations.Count)];

        ResultCityLabel.Text = picked.City;
        ResultRegionLabel.Text = picked.Region;
        ResultPlaceLabel.Text = picked.Place;
        ResultFoodLabel.Text = picked.Food;
        ResultSongLabel.Text = picked.Song;

        ResultCard.IsVisible = true;
        await ResultCard.FadeTo(1, 300);

        SpinButton.IsEnabled = true;
        DiceLabel.Text = "🎉";
    }

    private async void OnExploreCityClicked(object sender, EventArgs e)
    {
        string city = ResultCityLabel.Text;
        string query = LocalizationService.IsEnglish ? $"{city} Turkey attractions" : $"{city} gezilecek yerler";
        string uri = $"https://www.google.com/maps/search/?api=1&query={Uri.EscapeDataString(query)}";
        await Launcher.OpenAsync(new Uri(uri));
    }
}