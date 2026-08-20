namespace GezginRotası2;

public class FoodItem
{
    public string Name { get; set; } = string.Empty;           // Örn: "Kayseri Mantısı"
    public string City { get; set; } = string.Empty;           // Örn: "Kayseri"
    public string Category { get; set; } = string.Empty;       // Örn: "Ana Yemek", "Tatlı", "Sokak Lezzeti"
    public string Description { get; set; } = string.Empty;    // Yemeğin hikayesi ve özellikleri
    public string ImageUrl { get; set; } = string.Empty;       // Fotoğraf
    public string WhereToEat { get; set; } = string.Empty;      // Örn: "Kaşık-La & Elmacıoğlu İskender"
    public double Rating { get; set; } = 4.9;                  // Puan
}