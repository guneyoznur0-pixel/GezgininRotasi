namespace GezginRotası2;

public partial class PassportPage : ContentPage
{
    private readonly PassportService _passportService = new();
    private string _currentRegion = "Tümü";

    public PassportPage()
    {
        InitializeComponent();
        LocalizationService.LanguageChanged += (s, e) => ApplyLocalization();
        ApplyLocalization();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ApplyLocalization();
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;

        Title = LocalizationService.T("PassportTitle");
        BadgesTitleLabel.Text = LocalizationService.T("BadgesTitle");
        Badge81Label.Text = LocalizationService.T("Passport81Count");

        BtnRegAll.Text = LocalizationService.T("RegionAll");
        BtnRegMarmara.Text = LocalizationService.T("RegionMarmara");
        BtnRegEge.Text = LocalizationService.T("RegionEge");
        BtnRegAkdeniz.Text = LocalizationService.T("RegionAkdeniz");
        BtnRegIcanadolu.Text = LocalizationService.T("RegionIcanadolu");
        BtnRegKaradeniz.Text = LocalizationService.T("RegionKaradeniz");
        BtnRegDogu.Text = LocalizationService.T("RegionDogu");
        BtnRegGuneydogu.Text = LocalizationService.T("RegionGuneydogu");

        RefreshUI();
    }

    private void RefreshUI()
    {
        // 1. Şehirleri Yükle
        var cities = _passportService.LoadCities(_currentRegion);
        CitiesCollection.ItemsSource = null;
        CitiesCollection.ItemsSource = cities;

        // 2. İstatistikleri Güncelle
        var (count, percentage, rank) = _passportService.GetStats();
        StatsLabel.Text = LocalizationService.Format("VisitedCitiesFormat", count, Math.Round(percentage * 100));
        RankLabel.Text = rank;
        PassportProgressBar.Progress = percentage;

        // 3. Rozetleri Çiz
        RenderBadges();
    }

    private void RenderBadges()
    {
        BadgesLayout.Children.Clear();
        var badges = _passportService.GetBadges();

        foreach (var b in badges)
        {
            var border = new Border
            {
                BackgroundColor = b.BadgeBgColor,
                Stroke = b.BorderColor,
                StrokeThickness = 1,
                StrokeShape = new Microsoft.Maui.Controls.Shapes.RoundRectangle { CornerRadius = 12 },
                Padding = new Thickness(12, 8),
                Opacity = b.Opacity
            };

            var stack = new HorizontalStackLayout { Spacing = 6, VerticalOptions = LayoutOptions.Center };
            stack.Children.Add(new Label { Text = b.Icon, FontSize = 18, VerticalOptions = LayoutOptions.Center });

            var textStack = new VerticalStackLayout { Spacing = 1 };
            textStack.Children.Add(new Label { Text = b.Title, TextColor = Colors.White, FontSize = 12, FontAttributes = FontAttributes.Bold });
            textStack.Children.Add(new Label { Text = b.Description, TextColor = Color.FromArgb("#A0A5B5"), FontSize = 9 });

            stack.Children.Add(textStack);
            border.Content = stack;

            BadgesLayout.Children.Add(border);
        }
    }

    // Şehre tıklandığında Gezildi / Gezilmedi durumunu değiştirir
    private void OnCityTapped(object sender, EventArgs e)
    {
        if (sender is BindableObject bindable && bindable.BindingContext is CityPassportItem city)
        {
            _passportService.ToggleCityVisited(city.PlateNumber);
            RefreshUI();
        }
    }

    // Bölge filtreleme (Marmara, Ege vb.)
    private void OnRegionFilterClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            _currentRegion = btn.Text;

            // Reset styles
            BtnRegAll.BackgroundColor = Color.FromArgb("#1E2330");
            BtnRegMarmara.BackgroundColor = Color.FromArgb("#1E2330");
            BtnRegEge.BackgroundColor = Color.FromArgb("#1E2330");
            BtnRegAkdeniz.BackgroundColor = Color.FromArgb("#1E2330");
            BtnRegIcanadolu.BackgroundColor = Color.FromArgb("#1E2330");
            BtnRegKaradeniz.BackgroundColor = Color.FromArgb("#1E2330");
            BtnRegDogu.BackgroundColor = Color.FromArgb("#1E2330");
            BtnRegGuneydogu.BackgroundColor = Color.FromArgb("#1E2330");

            btn.BackgroundColor = Color.FromArgb("#FF7F00");

            RefreshUI();
        }
    }
}