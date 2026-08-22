namespace GezginRotası2;

public partial class MainPage : ContentPage
{
    private List<string> _allCities = new();

    public MainPage()
    {
        InitializeComponent();

        _allCities = CityDatabase.AllCitiesWithAll;
        CityPicker.ItemsSource = _allCities;
        CityPicker.SelectedIndex = 0;

        // Dil Değişikliği Dinleyicisi
        LocalizationService.LanguageChanged += OnLanguageChanged;
        ApplyLocalization();
    }

    private void OnLanguageToggleTapped(object sender, EventArgs e)
    {
        LocalizationService.ToggleLanguage();
    }

    private void OnLanguageChanged(object? sender, EventArgs e)
    {
        ApplyLocalization();
    }

    private void ApplyLocalization()
    {
        LblAppTitle.Text = LocalizationService.T("AppTitle");
        LblAppSubtitle.Text = LocalizationService.T("AppSubtitle");
        LblLanguageBadge.Text = LocalizationService.T("LanguageBadge");
        CitySearchBar.Placeholder = LocalizationService.T("SearchPlaceholder");
        CityPicker.Title = LocalizationService.T("SelectCity");

        LblAiTitle.Text = LocalizationService.T("AiTitle");
        LblAiSubtitle.Text = LocalizationService.T("AiSubtitle");

        BtnWheel.Text = LocalizationService.T("ToolWheel");
        BtnDialect.Text = LocalizationService.T("ToolDialect");
        BtnPacking.Text = LocalizationService.T("ToolPacking");
        BtnPostcard.Text = LocalizationService.T("ToolPostcard");

        LblMenuSights.Text = LocalizationService.T("MenuSights");
        LblMenuMuseums.Text = LocalizationService.T("MenuMuseums");
        LblMenuFoods.Text = LocalizationService.T("MenuFoods");
        LblMenuCulture.Text = LocalizationService.T("MenuCulture");
        LblMenuDiary.Text = LocalizationService.T("MenuDiary");
        LblMenuPassport.Text = LocalizationService.T("MenuPassport");
    }

    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        string filter = e.NewTextValue?.Trim() ?? "";
        if (string.IsNullOrWhiteSpace(filter))
        {
            CityPicker.ItemsSource = _allCities;
            CityPicker.SelectedIndex = 0;
        }
        else
        {
            var filtered = _allCities.Where(c => c.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();
            if (filtered.Count > 0)
            {
                CityPicker.ItemsSource = filtered;
                CityPicker.SelectedIndex = 0;
            }
        }
    }

    private void OnCityPickerChanged(object sender, EventArgs e)
    {
        // Şehir seçildiğinde işlem yapılabilir
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