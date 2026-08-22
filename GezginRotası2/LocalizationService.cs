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
        // App & Header
        { "AppTitle", ("🧭 Gezginin Rotası", "🧭 Traveler's Route") },
        { "AppSubtitle", ("81 İlin Kültür, Doğa & Lezzet Rehberi", "81 Provinces Culture, Nature & Cuisine Guide") },
        { "SearchPlaceholder", ("Nereye gitmek istersiniz?", "Where would you like to travel?") },
        { "SelectCity", ("📍 Gezeceğiniz Şehri Seçin", "📍 Select a City to Explore") },
        { "AllCities", ("Tüm Türkiye", "All Turkey") },
        { "LanguageBadge", ("🇹🇷 TR", "🇬🇧 EN") },

        // Tabs
        { "TabExplore", ("Keşfet", "Explore") },
        { "TabFoods", ("Lezzetler", "Foods") },
        { "TabAiGuide", ("Gezgin AI", "AI Guide") },
        { "TabPassport", ("Pasaportum", "Passport") },

        // Gemini AI Card
        { "AiTitle", ("Yapay Zeka Gezgin Asistanı", "AI Travel Guide Assistant") },
        { "AiSubtitle", ("Rota çiz, ne yenir sor veya bütçe planla!", "Create itineraries, ask for dishes & budget tips!") },

        // 6-Grid Menu
        { "MenuSights", ("Gezilecek", "Attractions") },
        { "MenuMuseums", ("Müzeler", "Museums") },
        { "MenuFoods", ("Ne Yenir?", "Gastronomy") },
        { "MenuCulture", ("Şarkılar & Kültür", "Songs & Culture") },
        { "MenuDiary", ("Günlüğüm", "Travel Diary") },
        { "MenuPassport", ("Pasaportum", "Passport") },

        // Quick Travel Tools
        { "ToolWheel", ("🎲 Şans Çarkı", "🎲 Lucky Spin") },
        { "ToolDialect", ("🗣️ Şive Sözlüğü", "🗣️ Dialect Guide") },
        { "ToolPacking", ("🎒 Akıllı Valiz", "🎒 Smart Packing") },
        { "ToolPostcard", ("📸 Kartpostal", "📸 Postcard") },

        // Filters & Actions
        { "FilterAll", ("Tümü", "All") },
        { "FilterSights", ("Gezilecek", "Sights") },
        { "FilterMuseums", ("Müzeler", "Museums") },
        { "MapButton", ("📍 Haritada Gör / Yol Tarifi", "📍 Open in Google Maps") },
        { "WhereToEat", ("Nerede Yenir?", "Where to Eat?") },
        { "Rating", ("Puan", "Rating") },
        { "Listen", ("▶️ Dinle", "▶️ Listen") },

        // Pasaport Sayfası
        { "PassportTitle", ("🇹🇷 Gezgin Pasaportu", "🇹🇷 Traveler Passport") },
        { "BadgesTitle", ("🏆 Başarı Rozetleri", "🏆 Achievement Badges") },
        { "VisitedStatus", ("✅ Gezildi", "✅ Visited") },
        { "ToVisitStatus", ("⚪ Gezilecek", "⚪ To Visit") },
        { "VisitedCitiesFormat", ("{0} / 81 İl Gezildi (%{1})", "{0} / 81 Cities Visited (%{1})") },
        { "Passport81Count", ("🇹🇷 81 İl", "🇹🇷 81 Cities") },

        // Bölgeler
        { "RegionAll", ("Tümü", "All") },
        { "RegionMarmara", ("Marmara", "Marmara") },
        { "RegionEge", ("Ege", "Aegean") },
        { "RegionAkdeniz", ("Akdeniz", "Mediterranean") },
        { "RegionIcanadolu", ("İç Anadolu", "Central Anatolia") },
        { "RegionKaradeniz", ("Karadeniz", "Black Sea") },
        { "RegionDogu", ("Doğu Anadolu", "Eastern Anatolia") },
        { "RegionGuneydogu", ("Güneydoğu", "Southeastern") },

        // Kültür & Şarkılar
        { "CultureTitle", ("🎧 Şehrin Ruhu & Türküleri", "🎧 Soul of the City & Folk Songs") },
        { "CultureSubtitle", ("O topraklarda doğmuş büyük insanlar ve dinlenecek türküler", "Prominent figures born in these lands and regional folk songs") },
        { "SongsSection", ("🎵 Dinlenecek Yöresel Türküler", "🎵 Regional Folk Songs") },
        { "PeopleSection", ("👑 Önemli Şahsiyetler & Ozanlar", "👑 Prominent Figures & Bards") },

        // Şive Sözlüğü
        { "DialectTitle", ("🗣️ Yöresel Şive Atlası", "🗣️ Regional Dialect Atlas") },
        { "DialectSubtitle", ("81 İlin ağızları, yöresel deyimleri ve sokak konuşmaları", "Dialects, regional idioms and local slang of all 81 provinces") },

        // Valiz & Şans Çarkı
        { "PackingTitle", ("🎒 Akıllı Gezgin Valiz Listesi", "🎒 Smart Travel Packing Checklist") },
        { "WheelTitle", ("🎲 Nereye Gitsem? / Şans Çarkı", "🎲 Where Should I Go? / Lucky Spin") },
        { "DiaryTitle", ("📓 Gezgin Günlüğüm", "📓 My Travel Diary") },
        { "PostcardTitle", ("📸 Gezgin Kartpostalı", "📸 Travel Postcard") }
    };

    public static string T(string key)
    {
        if (Translations.TryGetValue(key, out var val))
        {
            return CurrentLanguage == "EN" ? val.EN : val.TR;
        }
        return key;
    }

    public static string Format(string key, params object[] args)
    {
        string template = T(key);
        try
        {
            return string.Format(template, args);
        }
        catch
        {
            return template;
        }
    }
}
