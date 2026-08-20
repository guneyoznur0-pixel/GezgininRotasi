namespace GezginRotası2;

public class PlaceItem
{
    public string Name { get; set; } = string.Empty;          // Örn: "Ayasofya Camii"
    public string City { get; set; } = string.Empty;          // "İstanbul"
    public string Category { get; set; } = "Gezilecek";       // "Gezilecek", "Müzeler", "Doğa"
    public string Description { get; set; } = string.Empty;   // Açıklama
    public string ImageUrl { get; set; } = string.Empty;      // Fotoğraf
    public double Rating { get; set; } = 4.9;                 // Puan
    public string BestTimeToVisit { get; set; } = "Her Mevsim";
}