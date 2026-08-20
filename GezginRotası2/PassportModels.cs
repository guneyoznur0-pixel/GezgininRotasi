namespace GezginRotası2;

// Şehir Modeli
public class CityPassportItem
{
    public int PlateNumber { get; set; }                      // Plaka Kodu (Örn: 34, 06)
    public string Name { get; set; } = string.Empty;           // Şehir Adı (Örn: İstanbul)
    public string Region { get; set; } = string.Empty;         // Bölge (Marmara, Ege vb.)
    public bool IsVisited { get; set; }                        // Gezildi mi?

    // Tasarım Renkleri
    public Color CardBorderColor => IsVisited ? Color.FromArgb("#4CAF50") : Color.FromArgb("#2A2A2A");
    public Color PlateBgColor => IsVisited ? Color.FromArgb("#4CAF50") : Color.FromArgb("#333333");
    public string StatusText => IsVisited ? "✅ Gezildi" : "⚪ Gezilecek";
    public Color StatusColor => IsVisited ? Color.FromArgb("#4CAF50") : Color.FromArgb("#888888");
}

// Başarı Rozeti Modeli
public class BadgeItem
{
    public string Title { get; set; } = string.Empty;          // Örn: "Ege Aşığı"
    public string Description { get; set; } = string.Empty;    // Örn: "Ege'den 4 il gezdin"
    public string Icon { get; set; } = string.Empty;           // Emoji (🏖️, 🏔️)
    public bool IsUnlocked { get; set; }                       // Açıldı mı?
    public Color BadgeBgColor => IsUnlocked ? Color.FromArgb("#E61E1E1E") : Color.FromArgb("#181818");
    public Color BorderColor => IsUnlocked ? Color.FromArgb("#FFD700") : Color.FromArgb("#333333");
    public double Opacity => IsUnlocked ? 1.0 : 0.4;
}