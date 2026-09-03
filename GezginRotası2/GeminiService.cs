using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace GezginRotası2;

public class GeminiService
{
    private readonly HttpClient _httpClient = new();

    private static string GetSystemPrompt()
    {
        if (LocalizationService.IsEnglish)
        {
            return "You are 'Traveler's Route (Gezginin Rotası)', an expert, friendly, and knowledgeable Turkey Travel & Gastronomy AI Guide for international tourists. " +
                   "Your mission is to provide foreign visitors with rich itineraries, hidden gems, top attractions, ancient ruins, regional dishes, street foods, " +
                   "authentic dining recommendations, local bus/dolmuş/metro routes, and practical travel safety tips across all 81 provinces of Turkey. " +
                   "Always respond in fluent, engaging English using clear bullet points, headings, emojis, and helpful travel tips.";
        }
        else
        {
            return "Sen 'Gezginin Rotası' uygulamasının uzman, samimi ve bilgili Türkiye seyahat & gastronomi rehberisin. " +
                   "Görevin kullanıcılara Türkiye'nin 81 ili hakkında gezilecek yerler, tarihi mekanlar, 1 günlük seyahat rotaları, " +
                   "o şehrin en meşhur yöresel yemekleri, tatlıları ve nerede yenileceği konusunda net, maddeli, emojili tavsiyeler vermektir. " +
                   "Cevaplarını Türkçe olarak, başlıklar ve maddeler halinde ver.";
        }
    }

    public async Task<string> AskTravelGuideAsync(string userMessage, string selectedCity = "")
    {
        string apiKey = ApiConfig.GeminiApiKey;

        if (string.IsNullOrWhiteSpace(apiKey) || apiKey.Contains("YOUR_GEMINI_API_KEY"))
        {
            return LocalizationService.IsEnglish
                ? "⚠️ Gemini API key is not configured. Please set the GEMINI_API_KEY environment variable or save your key in app preferences."
                : "⚠️ Gemini API anahtarı tanımlanmamış. Lütfen GEMINI_API_KEY ortam değişkenini veya uygulama ayarlarını kontrol edin.";
        }

        string promptPrefix = LocalizationService.IsEnglish ? "[City: " : "[Şehir: ";
        string promptSuffix = LocalizationService.IsEnglish ? "] Query: " : "] Soru: ";

        string contextMessage = string.IsNullOrWhiteSpace(selectedCity) || selectedCity == "Tüm Türkiye" || selectedCity == "All Turkey"
            ? userMessage
            : $"{promptPrefix}{selectedCity}{promptSuffix}{userMessage}";

        var requestBody = new
        {
            contents = new[]
            {
                new
                {
                    parts = new[]
                    {
                        new { text = $"{GetSystemPrompt()}\n\nUser Request / Kullanıcı Talebi: {contextMessage}" }
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
            string apiUrl = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-3.6-flash:generateContent?key={apiKey}";

            var response = await _httpClient.PostAsync(apiUrl, jsonContent);
            var responseJson = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return $"Google API Error ({response.StatusCode}):\n{responseJson}";
            }

            var jsonNode = JsonNode.Parse(responseJson);

            // Google'ın döndürdüğü metni güvenli şekilde alıyoruz
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

            return LocalizationService.IsEnglish 
                ? "Could not parse response from guide." 
                : "Cevap metni ayrıştırılamadı.";
        }
        catch (Exception ex)
        {
            return LocalizationService.IsEnglish 
                ? $"Connection Error: {ex.Message}" 
                : $"Bağlantı Hatası: {ex.Message}";
        }
    }
}