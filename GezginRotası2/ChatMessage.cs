namespace GezginRotası2;

public class ChatMessage
{
    public string Text { get; set; } = string.Empty;
    public bool IsUser { get; set; } // true = Kullanıcı, false = Gemini AI
    public string TimeText { get; set; } = DateTime.Now.ToString("HH:mm");

    // UI Tasarım Özellikleri
    public LayoutOptions HorizontalAlignment => IsUser ? LayoutOptions.End : LayoutOptions.Start;
    public Color BubbleColor => IsUser ? Color.FromArgb("#FF7F00") : Color.FromArgb("#252525");
}