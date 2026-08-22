namespace GezginRotası2;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Alt sayfaların yönlendirmelerini kaydediyoruz
        Routing.RegisterRoute(nameof(PlacesPage), typeof(PlacesPage));
        Routing.RegisterRoute(nameof(PlaceDetailPage), typeof(PlaceDetailPage));
        Routing.RegisterRoute(nameof(FoodsPage), typeof(FoodsPage));
        Routing.RegisterRoute(nameof(AiAssistantPage), typeof(AiAssistantPage));
        Routing.RegisterRoute(nameof(PassportPage), typeof(PassportPage));

        LocalizationService.LanguageChanged += (s, e) => ApplyLocalization();
        ApplyLocalization();
    }

    private void ApplyLocalization()
    {
        TabExplore.Title = LocalizationService.T("TabExplore");
        TabFoods.Title = LocalizationService.T("TabFoods");
        TabAi.Title = LocalizationService.T("TabAiGuide");
        TabPassport.Title = LocalizationService.T("TabPassport");
    }
}