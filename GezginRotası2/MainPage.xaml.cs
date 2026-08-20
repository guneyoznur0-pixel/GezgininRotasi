namespace GezginRotası2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Şehirler listesini güvenli şekilde koddan yüklüyoruz
        CityPicker.ItemsSource = new List<string>
        {
            "Tüm Türkiye",
            "İstanbul",
            "Ankara",
            "İzmir",
            "Bursa",
            "Antalya",
            "Kayseri",
            "Nevşehir (Kapadokya)",
            "Gaziantep",
            "Trabzon",
            "Muğla",
            "Şanlıurfa",
            "Konya",
            "Eskişehir",
            "Çanakkale"
        };

        CityPicker.SelectedIndex = 0; // Varsayılan olarak "Tüm Türkiye" seçili gelsin
    }

    // 🤖 Yapay Zeka Asistanı Butonu
    private async void OnAiAssistantClicked(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new AiAssistantPage(seciliSehir));
    }

    // 🏛️ Gezilecek Yerler Butonu
    private async void OnGezilecekYerlerTapped(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new PlacesPage(seciliSehir, "Gezilecek"));
    }

    // 🏺 Müzeler Butonu
    private async void OnMuzelerTapped(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new PlacesPage(seciliSehir, "Müzeler"));
    }

    // 🏔️ Doğa Butonu
    private async void OnDogaTapped(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new PlacesPage(seciliSehir, "Doğa"));
    }

    // 🚌 Ulaşım Butonu
    private async void OnUlasimTapped(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new PlacesPage(seciliSehir, "Ulaşım"));
    } // 🍲 Meşhur Lezzetler Butonu
    private async void OnLezzetlerTapped(object sender, EventArgs e)
    {
        string seciliSehir = CityPicker.SelectedItem?.ToString() ?? "Tüm Türkiye";
        await Navigation.PushAsync(new FoodsPage(seciliSehir));
    }
    // 🇹🇷 Gezgin Pasaportu Butonu
    private async void OnPasaportTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PassportPage());
    }
}