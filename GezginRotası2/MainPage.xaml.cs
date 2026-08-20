namespace GezginRotası2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // 81 İlin tamamını ve 'Tüm Türkiye' seçeneğini otomatik yükler
        CityPicker.ItemsSource = CityDatabase.AllCitiesWithAll;
        CityPicker.SelectedIndex = 0;
    }

    // 🤖 Yapay Zeka Asistanı
    private async void OnAiAssistantClicked(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new AiAssistantPage(seciliSehir));
    }

    // 🎲 Şans Çarkı / Kararsızım
    private async void OnSansCarkiClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RandomAdventurePage());
    }

    // 🗣️ Yöresel Şive Sözlüğü
    private async void OnSiveSozluguClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LocalDictionaryPage());
    }

    // 🎒 Akıllı Valiz Listesi
    private async void OnValizClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PackingChecklistPage());
    }

    // 📸 Gezgin Kartpostalı Paylaş
    private async void OnKartpostalClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PostcardSharePage());
    }

    // 🏛️ Gezilecek Yerler
    private async void OnGezilecekYerlerTapped(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new PlacesPage(seciliSehir, "Gezilecek"));
    }

    // 🏺 Müzeler
    private async void OnMuzelerTapped(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new PlacesPage(seciliSehir, "Müzeler"));
    }

    // 🍲 Ne Yenir? (Meşhur Lezzetler)
    private async void OnLezzetlerTapped(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new FoodsPage(seciliSehir));
    }

    // 🎧 Şehrin Şarkıları & Kültür
    private async void OnKulturTapped(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new CityCulturePage(seciliSehir));
    }

    // 📓 Gezgin Günlüğüm
    private async void OnGunlukTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DiaryPage());
    }

    // 🇹🇷 81 İl Pasaportum
    private async void OnPasaportTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PassportPage());
    }
}