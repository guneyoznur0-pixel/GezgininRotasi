using System.Text.Json;

namespace GezginRotası2;

public static class DiaryService
{
    private static readonly string FilePath = Path.Combine(FileSystem.AppDataDirectory, "travel_diary.json");

    // Tüm anıları yükle
    public static async Task<List<DiaryEntry>> LoadDiaryAsync()
    {
        try
        {
            if (!File.Exists(FilePath))
                return new List<DiaryEntry>();

            string json = await File.ReadAllTextAsync(FilePath);
            return JsonSerializer.Deserialize<List<DiaryEntry>>(json) ?? new List<DiaryEntry>();
        }
        catch
        {
            return new List<DiaryEntry>();
        }
    }

    // Yeni anı ekle
    public static async Task SaveEntryAsync(DiaryEntry newEntry)
    {
        try
        {
            var list = await LoadDiaryAsync();
            list.Insert(0, newEntry); // En yeni anı en üstte
            string json = JsonSerializer.Serialize(list);
            await File.WriteAllTextAsync(FilePath, json);
        }
        catch { }
    }

    // Anı sil
    public static async Task DeleteEntryAsync(string id)
    {
        try
        {
            var list = await LoadDiaryAsync();
            list.RemoveAll(x => x.Id == id);
            string json = JsonSerializer.Serialize(list);
            await File.WriteAllTextAsync(FilePath, json);
        }
        catch { }
    }
}
