namespace GezginRotası2;

public static class ApiConfig
{
    // Güvenlik: Canlı ve Public GitHub depolarında API anahtarları açık metin olarak tutulmaz.
    // Uygulama sırasıyla:
    // 1. İşletim sistemi / CI-CD Environment Variable (GEMINI_API_KEY)
    // 2. Uygulama içi Preferences ("GeminiApiKey")
    // 3. Veya geliştirici anahtarını kontrol eder.
    private const string DefaultDevApiKey = "YOUR_GEMINI_API_KEY_HERE";

    public static string GeminiApiKey
    {
        get
        {
            var envKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");
            if (!string.IsNullOrWhiteSpace(envKey))
                return envKey;

            var prefKey = Preferences.Get("GeminiApiKey", string.Empty);
            if (!string.IsNullOrWhiteSpace(prefKey))
                return prefKey;

            return DefaultDevApiKey;
        }
    }

    public static void SaveUserApiKey(string apiKey)
    {
        if (!string.IsNullOrWhiteSpace(apiKey))
        {
            Preferences.Set("GeminiApiKey", apiKey.Trim());
        }
    }
}
