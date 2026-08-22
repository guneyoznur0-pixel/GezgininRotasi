namespace GezginRotası2;

public static class LocalizationService
{
    public static string CurrentLanguage { get; private set; } = "TR"; // "TR" veya "EN"

    public static event EventHandler? LanguageChanged;

    public static bool IsEnglish => CurrentLanguage == "EN";

    public static void SetLanguage(string lang)
    {
        if (CurrentLanguage != lang)
        {
            CurrentLanguage = lang.ToUpperInvariant();
            LanguageChanged?.Invoke(null, EventArgs.Empty);
        }
    }

    public static void ToggleLanguage()
    {
        SetLanguage(CurrentLanguage == "TR" ? "EN" : "TR");
    }

    private static readonly Dictionary<string, (string TR, string EN)> Translations = new()
    {
        // Genel & Başlıklar
        { "AppTitle", ("🧭 Gezginin Rotası", "🧭 Traveler's Route") },
        { "AppSubtitle", ("81 İlin Kültür, Doğa & Lezzet Rehberi", "81 Provinces Culture, Nature & Cuisine Guide") },
        { "SearchPlaceholder", ("Nereye gitmek istersiniz?", "Where would you like to travel?") },
        { "SelectCity", ("📍 Gezeceğiniz Şehri Seçin", "📍 Select a City to Explore") },
        { "AllCities", ("Tüm Türkiye", "All Turkey") },

        // Gemini AI Kartı
        { "AiTitle", ("Yapay Zeka Gezgin Asistanı", "AI Travel Guide Assistant") },
        { "AiSubtitle", ("Rota çiz, ne yenir sor veya bütçe planla!", "Create itineraries, ask for dishes & budget tips!") },

        // 6'lı Ana Menü
        { "MenuSights", ("Gezilecek", "Attractions") },
        { "MenuMuseums", ("Müzeler", "Museums") },
        { "MenuFoods", ("Ne Yenir?", "Gastronomy") },
        { "MenuCulture", ("Şarkılar & Kültür", "Songs & Culture") },
        { "MenuDiary", ("Günlüğüm", "Travel Diary") },
        { "MenuPassport", ("Pasaportum", "Passport") },

        // Özel Araçlar (Hızlı Butonlar)
        { "ToolWheel", ("🎲 Şans Çarkı", "🎲 Lucky Spin") },
        { "ToolDialect", ("🗣️ Şive Sözlüğü", "🗣️ Dialect Guide") },
        { "ToolPacking", ("🎒 Akıllı Valiz", "🎒 Smart Packing") },
        { "ToolPostcard", ("📸 Kartpostal", "📸 Postcard") },

        // Sayfa İçleri
        { "FilterAll", ("Tümü", "All") },
        { "FilterSights", ("Gezilecek", "Sights") },
        { "FilterMuseums", ("Müzeler", "Museums") },
        { "MapButton", ("📍 Haritada Gör / Yol Tarifi", "📍 View on Google Maps / Route") },
        { "WhereToEat", ("Nerede Yenir?", "Where to Eat?") },
        { "Rating", ("Puan", "Rating") },
        { "LanguageBadge", ("🇹🇷 TR", "🇬🇧 EN") }
    };

    public static string T(string key)
    {
        if (Translations.TryGetValue(key, out var val))
        {
            return CurrentLanguage == "EN" ? val.EN : val.TR;
        }
        return key;
    }
}
