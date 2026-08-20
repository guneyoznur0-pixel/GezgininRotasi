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

        if (!string.IsNullOrWhiteSpace(_currentCity) && _currentCity != "Tüm Türkiye")
        {
            CityHeaderLabel.Text = $"📍 Seçili Şehir: {_currentCity}";
        }

        _ = LoadSavedMessagesAsync();
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
            Messages.Add(new ChatMessage
            {
                IsUser = false,
                Text = string.IsNullOrWhiteSpace(_currentCity) || _currentCity == "Tüm Türkiye"
                    ? "Merhaba Gezgin! 👋 Ben senin AI Seyahat Asistanınım. Türkiye'deki tüm şehirlerin gezilecek yerlerini ve meşhur lezzetlerini sorabilirsin!"
                    : $"Merhaba! 👋 {_currentCity} hakkında ne öğrenmek istersin? 1 günlük rota planlayabilir, en meşhur lezzetleri ve mekanları önerebilirim!"
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