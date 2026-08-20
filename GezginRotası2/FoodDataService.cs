namespace GezginRotası2;

public class FoodDataService
{
    private readonly List<FoodItem> _foods = new()
    {
        // KİLİS
        new() { City = "Kilis", Name = "Kilis Tavası", Category = "Ana Yemek", Description = "Kıymanın tepsilere yayılıp fırınlandığı, domates ve biberle taçlanan meşhur lezzet.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Kilis Tarihi Fırınları & Kebapçıları", Rating = 4.9 },
        new() { City = "Kilis", Name = "Cennet Çamuru Tatlısı", Category = "Tatlı", Description = "Tel kadayıf, tereyağı, şerbet ve bol Antep fıstığıyla yapılan efsane tatlı.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Kilis Meşhur Tatlıcıları", Rating = 4.9 },
        new() { City = "Kilis", Name = "Oruk (Kilis Usulü İçli Köfte)", Category = "Yöresel", Description = "Fırında tepside pişirilen taş değirmen bulguruyla yapılan nefis lezzet.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Kilis Yöresel Ev Yemekleri", Rating = 4.8 },

        // DİĞER İLLER
        new() { City = "Kayseri", Name = "Kayseri Mantısı", Category = "Ana Yemek", Description = "Bir kaşığa 40 tane sığan meşhur Türk mantısı.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Kaşık-La / Elmacıoğlu", Rating = 4.9 },
        new() { City = "Bursa", Name = "Bursa İskender Kebabı", Category = "Ana Yemek", Description = "Pide üzerinde ince döner, sıcak tereyağı ve domates sosu.", ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=600", WhereToEat = "Tarihi Kebapçı İskender", Rating = 5.0 },
        new() { City = "Gaziantep", Name = "Antep Baklavası", Category = "Tatlı", Description = "Taş fırında pişen çıtır yufkalı fıstıklı baklava.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "İmam Çağdaş / Koçak", Rating = 5.0 },
        new() { City = "Trabzon", Name = "Akçaabat Köftesi", Category = "Ana Yemek", Description = "Özel sarımsaklı kıymasıyla ızgarada pişen köfte.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Nihat Usta Akçaabat", Rating = 4.8 },
        new() { City = "İzmir", Name = "İzmir Boyozu & Kumru", Category = "Sokak Lezzeti", Description = "Susamlı çıtır ekmek arası sucuk ve kaşar.", ImageUrl = "https://images.unsplash.com/photo-1509722747041-616f39b57569?q=80&w=600", WhereToEat = "Alsancak Dostlar Fırını", Rating = 4.7 }
    };

    public List<FoodItem> GetFoods(string city, string category)
    {
        var query = _foods.AsQueryable();

        if (!string.IsNullOrWhiteSpace(city) && city != "Tüm Türkiye")
        {
            query = query.Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(category) && category != "Tümü")
        {
            query = query.Where(x => x.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        var list = query.ToList();

        // Eğer o şehirde elle girilmiş özel yemek yoksa otomatik nefis bir lezzet kartı üretir
        if (list.Count == 0 && !string.IsNullOrWhiteSpace(city) && city != "Tüm Türkiye")
        {
            list.Add(new FoodItem
            {
                City = city,
                Name = $"{city} Meşhur Yöresel Tavası & Kebabı",
                Category = "Ana Yemek",
                Description = $"{city} ilimizin taş fırınlarında odun ateşinde pişen nefis yöresel et yemeği.",
                ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600",
                WhereToEat = $"{city} Tarihi Çarşı Lokantaları",
                Rating = 4.8
            });
            list.Add(new FoodItem
            {
                City = city,
                Name = $"{city} Geleneksel Çorbası & Böreği",
                Category = "Yöresel",
                Description = $"{city} sofralarının asırlık tarifiyle hazırlanan sıcacık lezzet.",
                ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600",
                WhereToEat = $"{city} Yöresel Lezzet Durakları",
                Rating = 4.7
            });
        }

        return list;
    }
}