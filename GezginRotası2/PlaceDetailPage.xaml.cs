using Microsoft.Maui.ApplicationModel;

namespace GezginRotası2;

public partial class PlaceDetailPage : ContentPage
{
    public PlaceDetailPage(Place selectedPlace)
    {
        InitializeComponent(); 
   
        // 1. Önce gelen veriyi kontrol edelim
        if (selectedPlace != null)
        {
            LblName.Text = selectedPlace.Name;
            LblLocation.Text = $"📍 {selectedPlace.Location}";
            LblRating.Text = $"⭐ {selectedPlace.Rating}";
            LblDescription.Text = selectedPlace.Description;

            // 2. Resim yükleme testi (En kritik yer)
            // Eğer senin verdiğin ImageUrl çalışmazsa, örnek bir manzara resmi yükler.
            if (!string.IsNullOrEmpty(selectedPlace.ImageUrl))
            {
                ImgPlace.Source = selectedPlace.ImageUrl;
            }
            else
            {
                // Eğer URL boşsa bu test resmini gösterir
                ImgPlace.Source = "https://picsum.photos/800/600";
            }
        }
    

    // Verileri bağlıyoruz
    ImgPlace.Source = selectedPlace.ImageUrl;
        LblName.Text = selectedPlace.Name;
        LblLocation.Text = $"📍 {selectedPlace.Location}";
        LblRating.Text = $"⭐ {selectedPlace.Rating}";
        LblDescription.Text = selectedPlace.Description;
        // Constructor'ın en altına ekle
        if (string.IsNullOrEmpty(selectedPlace.ImageUrl))
        {
            ImgPlace.Source = "https://picsum.photos/500/300"; // Eğer link boşsa örnek resim göster
        }
    }

    // HATAYI DÜZELTEN KISIM BURASI:
    private async void OnShowMapClicked(object sender, EventArgs e)
    {
        try
        {
            // 1. ADIM: Şehir ismine göre bir konum oluşturuyoruz (Geocoding)
            // Şimdilik basit olması için sadece şehir ismini kullanıyoruz.
            var address = LblLocation.Text.Replace("📍 ", "");

            // 2. ADIM: Haritayı doğru parametrelerle açıyoruz
            // En az 2 parametre ister: (Konum/İşaretçi ve Seçenekler)
            await Map.Default.OpenAsync(new Placemark
            {
                Locality = address,
                Location = new Location(38.72, 35.48) // Örnek olarak Kayseri koordinatları
            }, new MapLaunchOptions
            {
                Name = LblName.Text,
                NavigationMode = NavigationMode.None
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Hata", "Harita şu an açılamıyor: " + ex.Message, "Tamam");
        }
    }
}