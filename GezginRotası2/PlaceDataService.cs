using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace GezginRotası2;

public class PlaceDataService
{
    private readonly DatabaseService _databaseService = new();
    private readonly HttpClient _httpClient = new();

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        NumberHandling = JsonNumberHandling.AllowReadingFromString
    };

    private const string ApiKey = "AQ.Ab8RN6LV_CkNuRZfhiCQLQ1f54N0rn4Affj9O8KgNOPwfhhNDw";

    public async Task<(List<Place> Places, string? ErrorMessage)> GetPlacesWithCacheAsync(string city, string category)
    {
        var cachedPlaces = await _databaseService.GetFilteredPlacesAsync(city, category);

        if (cachedPlaces.Count > 0)
        {
            return (cachedPlaces, null);
        }

        try
        {
            var (places, error) = await FetchPlacesFromGeminiAsync(city, category);

            if (places != null && places.Count > 0)
            {
                await _databaseService.SavePlacesAsync(places);
                var updatedList = await _databaseService.GetFilteredPlacesAsync(city, category);
                return (updatedList, null);
            }

            return (new List<Place>(), error ?? "Yapay zekadan mekan verisi alınamadı.");
        }
        catch (Exception ex)
        {
            return (new List<Place>(), $"Bağlantı Hatası: {ex.Message}");
        }
    }

    private async Task<(List<Place>? Places, string? Error)> FetchPlacesFromGeminiAsync(string city, string category)
    {
        if (string.IsNullOrWhiteSpace(ApiKey))
        {
            return (null, "API Anahtarı (ApiKey) girilmemiş!");
        }

        var endpoint = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-3.6-flash:generateContent?key={ApiKey}";

        var prompt = $@"Sen bir seyahat rehberisin. Türkiye'nin {city} şehri için '{category}' kategorisinde en popüler 4 mekanı listele.
Sadece geçerli bir JSON dizisi formatında yanıt ver:
[
  {{
    ""Name"": ""Mekan Adı"",
    ""Location"": ""{city}"",
    ""Category"": ""{category}"",
    ""ImageUrl"": ""https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=1000"",
    ""Description"": ""Mekan hakkında 2 cümlelik çekici bilgi."",
    ""Rating"": 4.8
  }}
]";

        var requestBody = new
        {
            contents = new[]
            {
                new { parts = new[] { new { text = prompt } } }
            },
            generationConfig = new
            {
                responseMimeType = "application/json"
            }
        };

        var content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

        HttpResponseMessage? response = null;
        string rawResponse = string.Empty;

        for (int attempt = 1; attempt <= 3; attempt++)
        {
            response = await _httpClient.PostAsync(endpoint, content);
            rawResponse = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
                break;

            if ((int)response.StatusCode == 503 && attempt < 3)
            {
                await Task.Delay(1500);
                continue;
            }

            return (null, $"Google API Hatası ({response.StatusCode}): {rawResponse}");
        }

        if (response == null || !response.IsSuccessStatusCode)
        {
            return (null, "API yanıtı alınamadı.");
        }

        var jsonNode = JsonNode.Parse(rawResponse);
        var textResult = jsonNode?["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString();

        if (string.IsNullOrEmpty(textResult))
        {
            return (null, "API boş yanıt döndürdü.");
        }

        var cleanJson = textResult.Trim();
        if (cleanJson.StartsWith("```json")) cleanJson = cleanJson[7..];
        if (cleanJson.StartsWith("```")) cleanJson = cleanJson[3..];
        if (cleanJson.EndsWith("```")) cleanJson = cleanJson[..^3];
        cleanJson = cleanJson.Trim();

        var places = JsonSerializer.Deserialize<List<Place>>(cleanJson, JsonOptions);
        return (places, null);
    }
}