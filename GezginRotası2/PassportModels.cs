namespace GezginRotası2;

// Şehir Modeli
public class CityPassportItem
{
    public int PlateNumber { get; set; }                      // Plaka Kodu (Örn: 34, 06)
    public string Name { get; set; } = string.Empty;           // Şehir Adı (Örn: İstanbul)
    public string Region { get; set; } = string.Empty;         // Bölge (Marmara, Ege vb.)
    public bool IsVisited { get; set; }                        // Gezildi mi?

    // Tasarım Renkleri
    public Color CardBorderColor => IsVisited ? Color.FromArgb("#4CAF50") : Color.FromArgb("#262C3A");
    public Color PlateBgColor => IsVisited ? Color.FromArgb("#4CAF50") : Color.FromArgb("#222734");
    public string StatusText => IsVisited ? LocalizationService.T("VisitedStatus") : LocalizationService.T("ToVisitStatus");
    public Color StatusColor => IsVisited ? Color.FromArgb("#4CAF50") : Color.FromArgb("#8E95A5");

    public string DisplayRegion
    {
        get
        {
            if (!LocalizationService.IsEnglish) return Region;
            return Region switch
            {
                "Marmara" => "Marmara Region",
                "Ege" => "Aegean Region",
                "Akdeniz" => "Mediterranean",
                "İç Anadolu" => "Central Anatolia",
                "Karadeniz" => "Black Sea",
                "Doğu Anadolu" => "Eastern Anatolia",
                "Güneydoğu" => "Southeastern",
                _ => Region
            };
        }
    }
}

// Başarı Rozeti Modeli
public class BadgeItem
{
    public string Title { get; set; } = string.Empty;          // Örn: "Ege Aşığı" / "Aegean Lover"
    public string Description { get; set; } = string.Empty;    // Örn: "Ege'den 4 il gezdin"
    public string Icon { get; set; } = string.Empty;           // Emoji (🏖️, 🏔️)
    public bool IsUnlocked { get; set; }                       // Açıldı mı?
    public Color BadgeBgColor => IsUnlocked ? Color.FromArgb("#1E2330") : Color.FromArgb("#151821");
    public Color BorderColor => IsUnlocked ? Color.FromArgb("#FFD700") : Color.FromArgb("#2A3040");
    public double Opacity => IsUnlocked ? 1.0 : 0.35;
}