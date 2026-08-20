using SQLite;

namespace GezginRotası2;

public class DatabaseService
{
    private SQLiteAsyncConnection? _database;

    private async Task Init()
    {
        if (_database is not null) return;

        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "GezginYedek.db3");
        _database = new SQLiteAsyncConnection(dbPath);
        await _database.CreateTableAsync<Place>();
    }

    public async Task SavePlacesAsync(List<Place> places)
    {
        await Init();
        // Tüm şehri silmek yerine yeni gelen mekanları veritabanına ekle
        await _database!.InsertAllAsync(places);
    }

    public async Task<List<Place>> GetLocalPlacesAsync()
    {
        await Init();
        return await _database!.Table<Place>().ToListAsync();
    }

    public async Task<List<Place>> GetFilteredPlacesAsync(string city, string category)
    {
        await Init();

        var query = _database!.Table<Place>();

        if (city != "Tüm Türkiye")
            query = query.Where(x => x.Location == city);

        if (!string.IsNullOrEmpty(category))
            query = query.Where(x => x.Category == category);

        return await query.ToListAsync();
    }
}