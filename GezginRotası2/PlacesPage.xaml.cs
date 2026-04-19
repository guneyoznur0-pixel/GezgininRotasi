namespace GezginRotası2;

// Gezilecek yerlerin özelliklerini tanımlayan sınıf
public class Place
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }
}

public partial class PlacesPage : ContentPage
{
    public PlacesPage(string selectedCity)
    {
        InitializeComponent();
        Title = $"{selectedCity} - Gezilecek Yerler";
        var allItems = new List<Place>
{
    new Place
    {
        Name = "Erciyes Kayak Merkezi",
        Location = "Kayseri",
       ImageUrl = "erciyes.jpg",
        Rating = 4.9,
        Description = "Erciyes Dağı, 3917 metre yüksekliği ile İç Anadolu'nun en yüksek zirvesidir. Modern kayak tesisleri, yüksek kar kalitesi ve uzun pistleri ile Türkiye'nin en önemli kış sporları merkezlerinden biridir."
    },
    new Place
    {
        Name = "Ayasofya Camii",
        Location = "İstanbul",
        ImageUrl = "https://muze.gov.tr/resimler/muze-ayasofya.jpg",
        Rating = 5.0,
        Description = "Dünya mimarlık tarihinin en görkemli yapılarından biri olan Ayasofya, sanat ve mimari dünyasının başyapıtları arasında yer alır. Hem Bizans hem Osmanlı döneminin izlerini taşımaktadır."
    },
    new Place
    {
        Name = "Peri Bacaları",
        Location = "Nevşehir",
        ImageUrl = "https://kapadokya.gov.tr/resimler/peribacalari.jpg",
        Rating = 4.8,
        Description = "Kapadokya'nın simgesi olan Peri Bacaları, doğanın milyonlarca yıl süren rüzgar ve yağmur aşındırması sonucu oluşmuş eşsiz yeryüzü şekilleridir. Bölge, UNESCO Dünya Miras Listesi'nde yer almaktadır."
    }
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
    private async void OnPlaceSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Place selectedPlace)
        {
            // Detay sayfasına giderken seçilen nesneyi gönderiyoruz
            await Navigation.PushAsync(new PlaceDetailPage(selectedPlace));

            // Tıklamayı temizle (Geri dönünce seçili kalmasın)
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}