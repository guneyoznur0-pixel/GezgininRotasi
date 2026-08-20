namespace GezginRotası2;

public partial class PassportPage : ContentPage
{
    private readonly PassportService _passportService = new();
    private string _currentRegion = "Tümü";

    public PassportPage()
    {
        InitializeComponent();
        RefreshUI();
    }

    private void RefreshUI()
    {
        // 1. Şehirleri Yükle
        var cities = _passportService.LoadCities(_currentRegion);
        CitiesCollection.ItemsSource = cities;

        // 2. İstatistikleri Güncelle
        var (count, percentage, rank) = _passportService.GetStats();
        StatsLabel.Text = $"{count} / 81 İl Gezildi (%{Math.Round(percentage * 100)})";
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
            textStack.Children.Add(new Label { Text = b.Description, TextColor = Color.FromArgb("#AAAAAA"), FontSize = 9 });

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
            RefreshUI();
        }
    }
}