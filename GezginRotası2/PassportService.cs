namespace GezginRotası2;

public class PassportService
{
    private const string VisitedCitiesKey = "VisitedCities_List";

    // Türkiye'nin 81 İli ve Bölgeleri
    private readonly List<CityPassportItem> _allCities = new()
    {
        // MARMARA (11 İl)
        new() { PlateNumber = 34, Name = "İstanbul", Region = "Marmara" },
        new() { PlateNumber = 16, Name = "Bursa", Region = "Marmara" },
        new() { PlateNumber = 41, Name = "Kocaeli", Region = "Marmara" },
        new() { PlateNumber = 59, Name = "Tekirdağ", Region = "Marmara" },
        new() { PlateNumber = 22, Name = "Edirne", Region = "Marmara" },
        new() { PlateNumber = 39, Name = "Kırklareli", Region = "Marmara" },
        new() { PlateNumber = 10, Name = "Balıkesir", Region = "Marmara" },
        new() { PlateNumber = 17, Name = "Çanakkale", Region = "Marmara" },
        new() { PlateNumber = 54, Name = "Sakarya", Region = "Marmara" },
        new() { PlateNumber = 77, Name = "Yalova", Region = "Marmara" },
        new() { PlateNumber = 11, Name = "Bilecik", Region = "Marmara" },

        // EGE (8 İl)
        new() { PlateNumber = 35, Name = "İzmir", Region = "Ege" },
        new() { PlateNumber = 48, Name = "Muğla", Region = "Ege" },
        new() { PlateNumber = 9, Name = "Aydın", Region = "Ege" },
        new() { PlateNumber = 20, Name = "Denizli", Region = "Ege" },
        new() { PlateNumber = 45, Name = "Manisa", Region = "Ege" },
        new() { PlateNumber = 3, Name = "Afyonkarahisar", Region = "Ege" },
        new() { PlateNumber = 43, Name = "Kütahya", Region = "Ege" },
        new() { PlateNumber = 64, Name = "Uşak", Region = "Ege" },

        // AKDENİZ (8 İl)
        new() { PlateNumber = 7, Name = "Antalya", Region = "Akdeniz" },
        new() { PlateNumber = 1, Name = "Adana", Region = "Akdeniz" },
        new() { PlateNumber = 33, Name = "Mersin", Region = "Akdeniz" },
        new() { PlateNumber = 31, Name = "Hatay", Region = "Akdeniz" },
        new() { PlateNumber = 46, Name = "Kahramanmaraş", Region = "Akdeniz" },
        new() { PlateNumber = 32, Name = "Isparta", Region = "Akdeniz" },
        new() { PlateNumber = 15, Name = "Burdur", Region = "Akdeniz" },
        new() { PlateNumber = 80, Name = "Osmaniye", Region = "Akdeniz" },

        // İÇ ANADOLU (13 İl)
        new() { PlateNumber = 6, Name = "Ankara", Region = "İç Anadolu" },
        new() { PlateNumber = 38, Name = "Kayseri", Region = "İç Anadolu" },
        new() { PlateNumber = 42, Name = "Konya", Region = "İç Anadolu" },
        new() { PlateNumber = 26, Name = "Eskişehir", Region = "İç Anadolu" },
        new() { PlateNumber = 50, Name = "Nevşehir", Region = "İç Anadolu" },
        new() { PlateNumber = 58, Name = "Sivas", Region = "İç Anadolu" },
        new() { PlateNumber = 68, Name = "Aksaray", Region = "İç Anadolu" },
        new() { PlateNumber = 70, Name = "Karaman", Region = "İç Anadolu" },
        new() { PlateNumber = 71, Name = "Kırıkkale", Region = "İç Anadolu" },
        new() { PlateNumber = 40, Name = "Kırşehir", Region = "İç Anadolu" },
        new() { PlateNumber = 51, Name = "Niğde", Region = "İç Anadolu" },
        new() { PlateNumber = 66, Name = "Yozgat", Region = "İç Anadolu" },
        new() { PlateNumber = 18, Name = "Çankırı", Region = "İç Anadolu" },

        // KARADENİZ (18 İl)
        new() { PlateNumber = 61, Name = "Trabzon", Region = "Karadeniz" },
        new() { PlateNumber = 55, Name = "Samsun", Region = "Karadeniz" },
        new() { PlateNumber = 52, Name = "Ordu", Region = "Karadeniz" },
        new() { PlateNumber = 53, Name = "Rize", Region = "Karadeniz" },
        new() { PlateNumber = 8, Name = "Artvin", Region = "Karadeniz" },
        new() { PlateNumber = 28, Name = "Giresun", Region = "Karadeniz" },
        new() { PlateNumber = 57, Name = "Sinop", Region = "Karadeniz" },
        new() { PlateNumber = 37, Name = "Kastamonu", Region = "Karadeniz" },
        new() { PlateNumber = 67, Name = "Zonguldak", Region = "Karadeniz" },
        new() { PlateNumber = 74, Name = "Bartın", Region = "Karadeniz" },
        new() { PlateNumber = 78, Name = "Karabük", Region = "Karadeniz" },
        new() { PlateNumber = 14, Name = "Bolu", Region = "Karadeniz" },
        new() { PlateNumber = 81, Name = "Düzce", Region = "Karadeniz" },
        new() { PlateNumber = 5, Name = "Amasya", Region = "Karadeniz" },
        new() { PlateNumber = 19, Name = "Çorum", Region = "Karadeniz" },
        new() { PlateNumber = 60, Name = "Tokat", Region = "Karadeniz" },
        new() { PlateNumber = 29, Name = "Gümüşhane", Region = "Karadeniz" },
        new() { PlateNumber = 69, Name = "Bayburt", Region = "Karadeniz" },

        // DOĞU ANADOLU (14 İl)
        new() { PlateNumber = 25, Name = "Erzurum", Region = "Doğu Anadolu" },
        new() { PlateNumber = 65, Name = "Van", Region = "Doğu Anadolu" },
        new() { PlateNumber = 44, Name = "Malatya", Region = "Doğu Anadolu" },
        new() { PlateNumber = 23, Name = "Elazığ", Region = "Doğu Anadolu" },
        new() { PlateNumber = 36, Name = "Kars", Region = "Doğu Anadolu" },
        new() { PlateNumber = 4, Name = "Ağrı", Region = "Doğu Anadolu" },
        new() { PlateNumber = 13, Name = "Bitlis", Region = "Doğu Anadolu" },
        new() { PlateNumber = 24, Name = "Erzincan", Region = "Doğu Anadolu" },
        new() { PlateNumber = 30, Name = "Hakkari", Region = "Doğu Anadolu" },
        new() { PlateNumber = 76, Name = "Iğdır", Region = "Doğu Anadolu" },
        new() { PlateNumber = 49, Name = "Muş", Region = "Doğu Anadolu" },
        new() { PlateNumber = 62, Name = "Tunceli", Region = "Doğu Anadolu" },
        new() { PlateNumber = 75, Name = "Ardahan", Region = "Doğu Anadolu" },
        new() { PlateNumber = 12, Name = "Bingöl", Region = "Doğu Anadolu" },

        // GÜNEYDOĞU ANADOLU (9 İl)
        new() { PlateNumber = 27, Name = "Gaziantep", Region = "Güneydoğu" },
        new() { PlateNumber = 63, Name = "Şanlıurfa", Region = "Güneydoğu" },
        new() { PlateNumber = 21, Name = "Diyarbakır", Region = "Güneydoğu" },
        new() { PlateNumber = 47, Name = "Mardin", Region = "Güneydoğu" },
        new() { PlateNumber = 72, Name = "Batman", Region = "Güneydoğu" },
        new() { PlateNumber = 73, Name = "Şırnak", Region = "Güneydoğu" },
        new() { PlateNumber = 56, Name = "Siirt", Region = "Güneydoğu" },
        new() { PlateNumber = 2, Name = "Adıyaman", Region = "Güneydoğu" },
        new() { PlateNumber = 79, Name = "Kilis", Region = "Güneydoğu" }
    };

    public List<CityPassportItem> LoadCities(string regionFilter = "Tümü")
    {
        string saved = Preferences.Get(VisitedCitiesKey, string.Empty);
        var visitedPlates = saved.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToHashSet();

        foreach (var city in _allCities)
        {
            city.IsVisited = visitedPlates.Contains(city.PlateNumber);
        }

        // Region filter normalization
        if (!string.IsNullOrWhiteSpace(regionFilter) && regionFilter != "Tümü" && regionFilter != "All")
        {
            string mappedRegion = regionFilter switch
            {
                "Aegean" => "Ege",
                "Mediterranean" => "Akdeniz",
                "Central Anatolia" => "İç Anadolu",
                "Black Sea" => "Karadeniz",
                "Eastern Anatolia" => "Doğu Anadolu",
                "Southeastern" => "Güneydoğu",
                _ => regionFilter
            };
            return _allCities.Where(c => c.Region == mappedRegion).ToList();
        }

        return _allCities.OrderBy(c => c.PlateNumber).ToList();
    }

    public void ToggleCityVisited(int plateNumber)
    {
        var city = _allCities.FirstOrDefault(c => c.PlateNumber == plateNumber);
        if (city != null)
        {
            city.IsVisited = !city.IsVisited;

            var visitedPlates = _allCities.Where(c => c.IsVisited).Select(c => c.PlateNumber);
            Preferences.Set(VisitedCitiesKey, string.Join(",", visitedPlates));
        }
    }

    public (int visitedCount, double percentage, string rankTitle) GetStats()
    {
        int count = _allCities.Count(c => c.IsVisited);
        double percentage = (double)count / 81.0;

        bool isEn = LocalizationService.IsEnglish;

        string rank = count switch
        {
            0 => isEn ? "Starting the Journey 🚶" : "Yolun Başında 🚶",
            < 5 => isEn ? "Curious Explorer 🎒" : "Meraklı Gezgin 🎒",
            < 15 => isEn ? "Route Navigator 🗺️" : "Yol Kaşifi 🗺️",
            < 30 => isEn ? "Master Traveler 🧭" : "Usta Seyyah 🧭",
            < 50 => isEn ? "Regional Conqueror 🌟" : "Bölge Fatihi 🌟",
            < 81 => isEn ? "Grand Explorer 👑" : "Büyük Seyyah 👑",
            _ => isEn ? "TURKEY CONQUEROR 🏆" : "TÜRKİYE FATİHİ 🏆"
        };

        return (count, percentage, rank);
    }

    public List<BadgeItem> GetBadges()
    {
        int totalVisited = _allCities.Count(c => c.IsVisited);
        int egeVisited = _allCities.Count(c => c.Region == "Ege" && c.IsVisited);
        int karadenizVisited = _allCities.Count(c => c.Region == "Karadeniz" && c.IsVisited);
        int marmaraVisited = _allCities.Count(c => c.Region == "Marmara" && c.IsVisited);
        int guneydoguVisited = _allCities.Count(c => c.Region == "Güneydoğu" && c.IsVisited);

        bool isEn = LocalizationService.IsEnglish;

        return new List<BadgeItem>
        {
            new() 
            { 
                Title = isEn ? "First Step" : "İlk Adım", 
                Description = isEn ? "Discovered your 1st city!" : "İlk şehrini keşfettin!", 
                Icon = "🎒", 
                IsUnlocked = totalVisited >= 1 
            },
            new() 
            { 
                Title = isEn ? "Aegean Lover" : "Ege Aşığı", 
                Description = isEn ? "Visited 4+ Aegean cities" : "Ege'den en az 4 il gezdin", 
                Icon = "🏖️", 
                IsUnlocked = egeVisited >= 4 
            },
            new() 
            { 
                Title = isEn ? "Black Sea Explorer" : "Karadeniz Kaşifi", 
                Description = isEn ? "Visited 5 Black Sea cities" : "Karadeniz'den 5 il gezdin", 
                Icon = "🏔️", 
                IsUnlocked = karadenizVisited >= 5 
            },
            new() 
            { 
                Title = isEn ? "Metropolis Traveler" : "Metropol Seyyahı", 
                Description = isEn ? "Completed 5 Marmara cities" : "Marmara'dan 5 il tamamlandı", 
                Icon = "🏰", 
                IsUnlocked = marmaraVisited >= 5 
            },
            new() 
            { 
                Title = isEn ? "Southeast Gourmet" : "Güneydoğu Gurmesi", 
                Description = isEn ? "Tasted 3 SE Anatolia cities" : "Güneydoğu'dan 3 il gezdin", 
                Icon = "🍖", 
                IsUnlocked = guneydoguVisited >= 3 
            },
            new() 
            { 
                Title = isEn ? "Half Century" : "Yarım Yüzyıl", 
                Description = isEn ? "Explored 40+ provinces!" : "40'tan fazla il keşfettin!", 
                Icon = "🌟", 
                IsUnlocked = totalVisited >= 40 
            },
            new() 
            { 
                Title = isEn ? "Turkey Conqueror" : "Türkiye Fatihi", 
                Description = isEn ? "Visited all 81 provinces!" : "81 ilin tamamını gezdin!", 
                Icon = "👑", 
                IsUnlocked = totalVisited == 81 
            }
        };
    }
}