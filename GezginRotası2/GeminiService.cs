using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace GezginRotası2;

public class GeminiService
{
    private const string ApiKey = "AQ.Ab8RN6LV_CkNuRZfhiCQLQ1f54N0rn4Affj9O8KgNOPwfhhNDw";
    private readonly HttpClient _httpClient = new();

    private const string SystemPrompt =
        "Sen 'Gezginin Rotası' uygulamasının uzman, samimi ve bilgili Türkiye seyahat & gastronomi rehberisin. " +
        "Görevin kullanıcılara Türkiye'nin 81 ili hakkında gezilecek yerler, tarihi mekanlar, 1 günlük seyahat rotaları, " +
        "o şehrin en meşhur yöresel yemekleri, tatlıları ve nerede yenileceği konusunda net, maddeli, emojili tavsiyeler vermektir. " +
        "Cevaplarını Türkçe olarak, başlıklar ve maddeler halinde ver.";

    public async Task<string> AskTravelGuideAsync(string userMessage, string selectedCity = "")
    {
        string contextMessage = string.IsNullOrWhiteSpace(selectedCity) || selectedCity == "Tüm Türkiye"
            ? userMessage
            : $"[Şehir: {selectedCity}] Soru: {userMessage}";

        var requestBody = new
        {
            contents = new[]
            {
                new
                {
                    parts = new[]
                    {
                        new { text = $"{SystemPrompt}\n\nKullanıcı Talebi: {contextMessage}" }
                    }
                }
            }
        };

        var jsonContent = new StringContent(
            JsonSerializer.Serialize(requestBody),
            Encoding.UTF8,
            "application/json");

        try
        {
            string apiUrl = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-3.6-flash:generateContent?key={ApiKey}";

            var response = await _httpClient.PostAsync(apiUrl, jsonContent);
            var responseJson = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return $"Google Hata Döndürdü ({response.StatusCode}):\n{responseJson}";
            }

            var jsonNode = JsonNode.Parse(responseJson);

            // Google'ın döndürdüğü metni güvenli şekilde alıyoruz (candidates -> content -> parts -> text)
            var parts = jsonNode?["candidates"]?[0]?["content"]?["parts"]?.AsArray();
            if (parts != null && parts.Count > 0)
            {
                var sb = new StringBuilder();
                foreach (var part in parts)
                {
                    string? text = part?["text"]?.ToString();
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        sb.Append(text);
                    }
                }
                return sb.ToString();
            }

            return "Cevap metni ayrıştırılamadı.";
        }
        catch (Exception ex)
        {
            return $"Bağlantı Hatası: {ex.Message}";
        }
    }
}