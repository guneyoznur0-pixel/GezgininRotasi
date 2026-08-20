namespace GezginRotası2;

public class FoodDataService
{
    private readonly List<FoodItem> _foods = new()
    {
        // KAYSERİ
        new FoodItem
        {
            Name = "Kayseri Mantısı",
            City = "Kayseri",
            Category = "Ana Yemek",
            Description = "Bir kaşığa 40 tane sığacak kadar küçük açılan, sumaklı ve yoğurtlu sosla servis edilen efsanevi lezzet.",
            ImageUrl = "https://images.unsplash.com/photo-1625938144755-652e08e359b7?q=80&w=1000&auto=format&fit=crop",
            WhereToEat = "Kaşık-La Mantı Evi & Elmacıoğlu",
            Rating = 4.9
        },
        new FoodItem
        {
            Name = "Kayseri Yağlaması (Şebit)",
            City = "Kayseri",
            Category = "Ana Yemek",
            Description = "İncecik açılan lavaşların arasına kıymalı, domatesli harç sürülerek kat kat dizilen ve sarımsaklı yoğurtla yenen şaheser.",
            ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=1000&auto=format&fit=crop",
            WhereToEat = "Gültepe Yağlama & Sultan Sofrası",
            Rating = 4.8
        },

        // BURSA
        new FoodItem
        {
            Name = "Bursa İskender Kebabı",
            City = "Bursa",
            Category = "Ana Yemek",
            Description = "Pide üzerine ince döner dilimleri, domates sosu, kızgın tereyağı ve yanında manda yoğurduyla 1867'den beri süregelen gelenek.",
            ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=1000&auto=format&fit=crop",
            WhereToEat = "Kebapçı İskender (Mavi Dükkan) & Kebapçı Hüseyin",
            Rating = 5.0
        },
        new FoodItem
        {
            Name = "Kestane Şekeri",
            City = "Bursa",
            Category = "Tatlı",
            Description = "Uludağ eteklerinde yetişen kestanelerin şerbetle kaynatılarak yumuşacık şekerlemeye dönüştürülmüş hali.",
            ImageUrl = "https://images.unsplash.com/photo-1587314168485-3236d6710814?q=80&w=1000&auto=format&fit=crop",
            WhereToEat = "Kafkas Kestane Şekeri",
            Rating = 4.7
        },

        // GAZİANTEP
        new FoodItem
        {
            Name = "Antep Fıstıklı Baklava",
            City = "Gaziantep",
            Category = "Tatlı",
            Description = "40 kat tül inceliğinde yufka, boz iç Antep fıstığı ve sade yağın odun fırınında pişmesiyle ortaya çıkan UNESCO tescilli tat.",
            ImageUrl = "https://images.unsplash.com/photo-1519869325930-281384150729?q=80&w=1000&auto=format&fit=crop",
            WhereToEat = "İmam Çağdaş & Koçak Baklava",
            Rating = 5.0
        },
        new FoodItem
        {
            Name = "Beyran Çorbası",
            City = "Gaziantep",
            Category = "Çorba / Kahvaltı",
            Description = "Kuzu gerdan eti, pirinç, bol sarımsak ve pul biberin bakır sahanda harlı ateşte hazırlanmasıyla yapılan şifa deposu.",
            ImageUrl = "https://images.unsplash.com/photo-1541832676-9b763b0239ab?q=80&w=1000&auto=format&fit=crop",
            WhereToEat = "Metanet Lokantası & Keleş Konağı",
            Rating = 4.9
        },

        // İSTANBUL
        new FoodItem
        {
            Name = "Eminönü Balık Ekmek",
            City = "İstanbul",
            Category = "Sokak Lezzeti",
            Description = "Haliç kıyısındaki teknelerde ızgarada pişen taze uskumrunun soğan, yeşillik ve limonla çıtır ekmek arasına girmesi.",
            ImageUrl = "https://images.unsplash.com/photo-1565299585323-38d6b0865b47?q=80&w=1000&auto=format&fit=crop",
            WhereToEat = "Eminönü Tarihi Balıkçı Tekneleri & Tarihi Balıkçı Emin Usta",
            Rating = 4.8
        },

        // TRABZON
        new FoodItem
        {
            Name = "Trabzon Kuymağı / Mıhlama",
            City = "Trabzon",
            Category = "Kahvaltılık",
            Description = "Mısır unu, yayık tereyağı ve uzayan kolot peynirinin tavada mükemmel uyumuyla yapılan Karadeniz kahvaltısının yıldızı.",
            ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=1000&auto=format&fit=crop",
            WhereToEat = "Bozoğlu Sürmene & Akçaabat Körfez",
            Rating = 4.9
        }
    };

    public List<FoodItem> GetFoods(string city = "", string category = "")
    {
        var result = _foods.AsEnumerable();

        if (!string.IsNullOrWhiteSpace(city) && city != "Tüm Türkiye")
        {
            result = result.Where(f => f.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(category) && category != "Tümü")
        {
            result = result.Where(f => f.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        return result.ToList();
    }
}