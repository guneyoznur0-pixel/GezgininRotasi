namespace GezginRotası2;

// Gezilecek yerlerin özelliklerini tanımlayan sınıf
public class Place
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string ImageUrl { get; set; }
}

public partial class PlacesPage : ContentPage
{
    public PlacesPage(string selectedCity)
    {
        InitializeComponent();
        Title = $"{selectedCity} - Gezilecek Yerler";

        var allItems = new List<Place>
        {
            new Place { Name = "Erciyes Kayak Merkezi", Location = "Kayseri", ImageUrl = "https://visitkayseri.com/resimler/erciyes-kayak-merkezi.jpg" },
            new Place { Name = "Ayasofya Camii", Location = "İstanbul", ImageUrl = "https://muze.gov.tr/resimler/muze-ayasofya.jpg" },
            new Place { Name = "Peri Bacaları", Location = "Nevşehir", ImageUrl = "https://kapadokya.gov.tr/resimler/peribacalari.jpg" }
        };

        // Eğer "Tüm Türkiye" seçilmediyse listeyi filtrele
        if (selectedCity != "Tüm Türkiye")
        {
            PlacesCollection.ItemsSource = allItems.Where(x => x.Location == selectedCity).ToList();
        }
        else
        {
            PlacesCollection.ItemsSource = allItems;
        }
    }
}