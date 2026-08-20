namespace GezginRotası2;

// Tarihi / Önemli Şahsiyet Modeli
public class HistoricPerson
{
    public string Name { get; set; } = string.Empty;          // Örn: "Mevlana Celaleddin-i Rumi"
    public string Title { get; set; } = string.Empty;         // Örn: "Büyük Mutasavvıf & Düşünür"
    public string Bio { get; set; } = string.Empty;           // Kısa bilgi
    public string City { get; set; } = string.Empty;          // "Konya"
}

// Yöresel Şarkı / Türkü Modeli
public class FolkSong
{
    public string Title { get; set; } = string.Empty;         // Örn: "Gesi Bağları"
    public string Artist { get; set; } = string.Empty;        // Örn: "Selda Bağcan / Barış Manço"
    public string Story { get; set; } = string.Empty;         // Türkünün hikayesi
    public string City { get; set; } = string.Empty;          // "Kayseri"
}