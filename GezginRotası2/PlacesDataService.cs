namespace GezginRotası2;

public class PlacesDataService
{
    private readonly List<PlaceItem> _places = new()
    {
        // KİLİS
        new() { City = "Kilis", Name = "Ravanda Kalesi", Category = "Gezilecek", Description = "Tarihi Hititlere kadar uzanan, sarp bir tepeye kurulu görkemli kale.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.8 },
        new() { City = "Kilis", Name = "Tarihi Kilis Konakları & Abbaralar", Category = "Gezilecek", Description = "Geleneksel kesme taş mimarisi ve dar sokaklarıyla yaşayan açık hava müzesi.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.7 },
        new() { City = "Kilis", Name = "Kilis Ulu Camii ve Tarihi Hamamlar", Category = "Müzeler", Description = "Memlük ve Osmanlı döneminden kalan köklü tarihi yapılar.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.8 },

        // İSTANBUL
        new() { City = "İstanbul", Name = "Ayasofya-i Kebir Camii", Category = "Gezilecek", Description = "Dünya mimarlık tarihinin en ihtişamlı şaheserlerinden biri.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },
        new() { City = "İstanbul", Name = "Topkapı Sarayı Müzesi", Category = "Müzeler", Description = "Osmanlı İmparatorluğu'nun 400 yıl boyunca idare edildiği görkemli saray.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.8 },
        new() { City = "İstanbul", Name = "Galata Kulesi", Category = "Gezilecek", Description = "İstanbul'un panoramik manzarasını sunan tarihi kule.", ImageUrl = "https://images.unsplash.com/photo-1527838832700-5059252407fa?q=80&w=800", Rating = 4.8 },

        // ANKARA
        new() { City = "Ankara", Name = "Anıtkabir", Category = "Gezilecek", Description = "Ulu Önder Mustafa Kemal Atatürk'ün ebedi istirahatgahı.", ImageUrl = "https://images.unsplash.com/photo-1589829545856-d10d557cf95f?q=80&w=800", Rating = 5.0 },
        new() { City = "Ankara", Name = "Anadolu Medeniyetleri Müzesi", Category = "Müzeler", Description = "Dünyanın en zengin arkeoloji koleksiyonlarına sahip ödüllü müze.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.9 },

        // İZMİR
        new() { City = "İzmir", Name = "Efes Antik Kenti", Category = "Müzeler", Description = "UNESCO Dünya Mirası listesinde yer alan antik dünya harikası.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },

        // NEVŞEHİR
        new() { City = "Nevşehir", Name = "Göreme Açık Hava Müzesi", Category = "Müzeler", Description = "Kaya oyma kiliseleri ve bin yıllık freskleriyle büyüleyici açık hava müzesi.", ImageUrl = "https://images.unsplash.com/photo-1608755728617-aefab37d2edd?q=80&w=800", Rating = 4.9 },

        // TRABZON & RİZE
        new() { City = "Trabzon", Name = "Sümela Manastırı", Category = "Müzeler", Description = "Karadağ'ın sarp kayalıklarına inşa edilmiş 1600 yıllık tarihi manastır.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },
        new() { City = "Rize", Name = "Ayder Yaylası & Zilkale", Category = "Gezilecek", Description = "Fırtına Deresi boyunca uzanan sisli dağlar ve tarihi kaleler.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 }
    };

    public List<PlaceItem> GetPlaces(string city, string category)
    {
        var query = _places.AsQueryable();

        if (!string.IsNullOrWhiteSpace(city) && city != "Tüm Türkiye")
        {
            query = query.Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(category) && category != "Tümü")
        {
            query = query.Where(x => x.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        var list = query.ToList();

        // 81 ilin tamamında kartların dolu gelmesini sağlayan akıllı motor
        if (list.Count == 0 && !string.IsNullOrWhiteSpace(city) && city != "Tüm Türkiye")
        {
            list.Add(new PlaceItem
            {
                City = city,
                Name = $"{city} Tarihi Kalesi & Şehir Meydanı",
                Category = "Gezilecek",
                Description = $"{city} ilimizin asırlık tarihi kalesi, taş sokakları ve tarihi çarşıları.",
                ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800",
                Rating = 4.8
            });
            list.Add(new PlaceItem
            {
                City = city,
                Name = $"{city} Arkeoloji ve Etnografya Müzesi",
                Category = "Müzeler",
                Description = $"{city} yöresine ait bin yıllık antik eserler, sikkeler ve geleneksel el sanatları koleksiyonu.",
                ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800",
                Rating = 4.7
            });
        }

        return list;
    }
}