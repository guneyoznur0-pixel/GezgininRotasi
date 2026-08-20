namespace GezginRotası2;

public class DiaryEntry
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string City { get; set; } = string.Empty;              // Örn: "Kayseri"
    public string Title { get; set; } = string.Empty;             // Örn: "Erciyes Zirvesi ve Yağlama Molası"
    public string Content { get; set; } = string.Empty;           // Gezi anısı ve notlar
    public string DateText { get; set; } = DateTime.Now.ToString("dd MMMM yyyy"); // Tarih
    public string MoodEmoji { get; set; } = "🤩";                // Ruh hali (🤩, 🏔️, 🍲, 😎)
    public int Rating { get; set; } = 5;                          // 1-5 Yıldız
}