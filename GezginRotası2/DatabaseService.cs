using SQLite;

namespace GezginRotası2;

public class DatabaseService
{
    private SQLiteAsyncConnection _database;

    async Task Init()
    {
        if (_database is not null) return;

        // Telefonun içinde güvenli bir dosya yolu oluşturur
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "GezginYedek.db3");
        _database = new SQLiteAsyncConnection(dbPath);

        // 'Place' tablosunu (şemasını) oluşturur
        await _database.CreateTableAsync<Place>();
    }

    // Firebase'den gelen verileri telefona "yedeklemek" için
    public async Task SavePlacesAsync(List<Place> places)
    {
        await Init();
        await _database.DeleteAllAsync<Place>(); // Eskileri temizle
        await _database.InsertAllAsync(places);  // Yenileri kaydet
    }

    // İnternet yoksa devreye giren kahraman metod
    public async Task<List<Place>> GetLocalPlacesAsync()
    {
        await Init();
        return await _database.Table<Place>().ToListAsync();
    }
}