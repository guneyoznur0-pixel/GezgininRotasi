using System.Collections.ObjectModel;

namespace GezginRotası2;

public partial class AiAssistantPage : ContentPage
{
    private readonly GeminiService _geminiService = new();
    private readonly string _currentCity;

    public ObservableCollection<ChatMessage> Messages { get; set; } = new();

    // 1. Alt Menü (TabBar) için boş kurucu
    public AiAssistantPage() : this("Tüm Türkiye")
    {
    }

    // 2. Şehir seçerek açmak için kurucu
    public AiAssistantPage(string selectedCity)
    {
        InitializeComponent();
        _currentCity = selectedCity;
        BindingContext = this;

        LocalizationService.LanguageChanged += (s, e) => ApplyLocalization();
        ApplyLocalization();

        _ = LoadSavedMessagesAsync();
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;
        Title = isEn ? "🤖 AI Travel Assistant" : "🤖 Gezgin AI Asistanı";

        if (string.IsNullOrWhiteSpace(_currentCity) || _currentCity == "Tüm Türkiye" || _currentCity == "All Turkey")
        {
            CityHeaderLabel.Text = isEn ? "📍 Assistant for All Turkey" : "📍 Tüm Türkiye İçin Asistan";
        }
        else
        {
            CityHeaderLabel.Text = isEn ? $"📍 Selected City: {_currentCity}" : $"📍 Seçili Şehir: {_currentCity}";
        }

        BtnPrompt1.Text = isEn ? "🗺️ Plan 1-Day Itinerary" : "🗺️ 1 Günlük Rota Çiz";
        BtnPrompt2.Text = isEn ? "🍲 What to Eat? (Iconic Dishes)" : "🍲 Ne Yenir? (Meşhur Lezzetler)";
        BtnPrompt3.Text = isEn ? "💰 Budget Travel Tips" : "💰 Bütçe Dostu Gezi";
        BtnPrompt4.Text = isEn ? "🏛️ Secret Hidden Gems" : "🏛️ Gizli Kalmış Yerler";

        MessageEntry.Placeholder = isEn ? "Ask anything about cities, foods or routes..." : "Şehir veya lezzet hakkında bir şey sorun...";
    }

    private async Task LoadSavedMessagesAsync()
    {
        var savedMessages = await ChatHistoryService.LoadHistoryAsync();

        if (savedMessages.Count > 0)
        {
            foreach (var msg in savedMessages)
            {
                Messages.Add(msg);
            }
        }
        else
        {
            bool isEn = LocalizationService.IsEnglish;
            string welcomeText;

            if (string.IsNullOrWhiteSpace(_currentCity) || _currentCity == "Tüm Türkiye" || _currentCity == "All Turkey")
            {
                welcomeText = isEn
                    ? "Hello Traveler! 👋 I am your AI Travel Guide. Ask me anything about sightseeing, ancient ruins, canyons, food recommendations, and local travel tips across Turkey!"
                    : "Merhaba Gezgin! 👋 Ben senin AI Seyahat Asistanınım. Türkiye'deki tüm şehirlerin gezilecek yerlerini ve meşhur lezzetlerini sorabilirsin!";
            }
            else
            {
                welcomeText = isEn
                    ? $"Hello! 👋 What would you like to explore in {_currentCity}? I can plan a 1-day itinerary, recommend top authentic restaurants, and share local tips!"
                    : $"Merhaba! 👋 {_currentCity} hakkında ne öğrenmek istersin? 1 günlük rota planlayabilir, en meşhur lezzetleri ve mekanları önerebilirim!";
            }

            Messages.Add(new ChatMessage
            {
                IsUser = false,
                Text = welcomeText
            });
        }
    }

    private async void OnSendClicked(object sender, EventArgs e)
    {
        string text = MessageEntry.Text?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(text)) return;

        MessageEntry.Text = string.Empty;

        var userMsg = new ChatMessage { Text = text, IsUser = true };
        Messages.Add(userMsg);

        LoadingIndicator.IsVisible = true;
        LoadingIndicator.IsRunning = true;

        string aiReply = await _geminiService.AskTravelGuideAsync(text, _currentCity);

        LoadingIndicator.IsRunning = false;
        LoadingIndicator.IsVisible = false;

        var aiMsg = new ChatMessage { Text = aiReply, IsUser = false };
        Messages.Add(aiMsg);

        await ChatHistoryService.SaveHistoryAsync(Messages);
    }

    private void OnQuickPromptClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            MessageEntry.Text = btn.Text;
            OnSendClicked(this, EventArgs.Empty);
        }
    }
}