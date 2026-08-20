using System.Text.Json;

namespace GezginRotası2;

public static class ChatHistoryService
{
    private static readonly string FilePath = Path.Combine(FileSystem.AppDataDirectory, "chat_history.json");

    // Geçmiş mesajları yerel hafızadan yükler (İnternet gerekmez)
    public static async Task<List<ChatMessage>> LoadHistoryAsync()
    {
        try
        {
            if (!File.Exists(FilePath))
                return new List<ChatMessage>();

            string json = await File.ReadAllTextAsync(FilePath);
            return JsonSerializer.Deserialize<List<ChatMessage>>(json) ?? new List<ChatMessage>();
        }
        catch
        {
            return new List<ChatMessage>();
        }
    }

    // Yeni mesajları yerel hafızaya kaydeder
    public static async Task SaveHistoryAsync(IEnumerable<ChatMessage> messages)
    {
        try
        {
            string json = JsonSerializer.Serialize(messages);
            await File.WriteAllTextAsync(FilePath, json);
        }
        catch
        {
            // Hata durumunda sessizce geç
        }
    }

    // Geçmişi temizler
    public static void ClearHistory()
    {
        try
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
        }
        catch { }
    }
}