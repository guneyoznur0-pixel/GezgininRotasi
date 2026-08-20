namespace GezginRotası2;

public class PackItem
{
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = "📦";
    public bool IsPacked { get; set; }
    public Color TextColor => IsPacked ? Color.FromArgb("#777777") : Colors.White;
    public TextDecorations TextDecoration => IsPacked ? TextDecorations.Strikethrough : TextDecorations.None;
}

public partial class PackingChecklistPage : ContentPage
{
    private List<PackItem> _currentList = new();

    public PackingChecklistPage()
    {
        InitializeComponent();
        LoadCategory("☀️ Yaz / Deniz Tatili");
    }

    private void LoadCategory(string type)
    {
        _currentList = type switch
        {
            "☀️ Yaz / Deniz Tatili" => new List<PackItem>
            {
                new() { Title = "Güneş Kremi & Güneş Gözlüğü", Icon = "🕶️" },
                new() { Title = "Mayo / Şort & Plaj Havlusu", Icon = "🩳" },
                new() { Title = "Şapka & Terlik", Icon = "🧢" },
                new() { Title = "Powerbank & Şarj Aleti", Icon = "🔋" },
                new() { Title = "Kimlik & Ehliyet & Kartlar", Icon = "💳" },
                new() { Title = "Kişisel İlaçlar & Yara Bandı", Icon = "💊" },
                new() { Title = "Hafif Yazlık Kıyafetler", Icon = "👕" }
            },
            "❄️ Kış & Kayak Tatili" => new List<PackItem>
            {
                new() { Title = "Termal İçlik & Yün Çorap", Icon = "🧦" },
                new() { Title = "Kar Montu & Su Geçirmez Pantolon", Icon = "🧥" },
                new() { Title = "Bere, Atkı & Kalın Eldiven", Icon = "🧤" },
                new() { Title = "Kar Botu / Trekking Ayakkabısı", Icon = "🥾" },
                new() { Title = "Dudak Koruyucu & Nemlendirici Krem", Icon = "🧴" },
                new() { Title = "Termos & Sıcak İçecek", Icon = "☕" },
                new() { Title = "Powerbank (Soğukta hızlı biter)", Icon = "🔋" }
            },
            "🏕️ Doğa & Kamp" => new List<PackItem>
            {
                new() { Title = "Çadır & Uyku Tulumu & Mat", Icon = "⛺" },
                new() { Title = "Kafa Lambası / Fener & Yedek Pil", Icon = "🔦" },
                new() { Title = "Çakı / Çok Amaçlı Bıçak", Icon = "🔪" },
                new() { Title = "Sinek / Böcek Kovucu Sprey", Icon = "🦟" },
                new() { Title = "İlk Yardım Çantası", Icon = "🩹" },
                new() { Title = "Kamp Ocağı & Termos & Matara", Icon = "🍳" },
                new() { Title = "Su Geçirmez Rüzgarlık", Icon = "🧥" }
            },
            _ => new List<PackItem> // Şehir & Kültür
            {
                new() { Title = "Rahat Yürüyüş / Spor Ayakkabısı", Icon = "👟" },
                new() { Title = "MüzeKart & Rezervasyon Belgeleri", Icon = "🎟️" },
                new() { Title = "Kulaklık & Fotoğraf Makinesi / Telefon", Icon = "📸" },
                new() { Title = "Küçük Sırt Çantası", Icon = "🎒" },
                new() { Title = "Hafif Hırka / Yağmurluk", Icon = "🧥" },
                new() { Title = "Islak Mendil & Dezenfektan", Icon = "🧼" },
                new() { Title = "Kimlik & Cüzdan & Nakit Para", Icon = "💵" }
            }
        };

        UpdateUI();
    }

    private void UpdateUI()
    {
        ItemsCollection.ItemsSource = null;
        ItemsCollection.ItemsSource = _currentList;

        int packed = _currentList.Count(x => x.IsPacked);
        int total = _currentList.Count;
        double ratio = total > 0 ? (double)packed / total : 0;

        ProgressLabel.Text = $"{packed} / {total} Eşya (%{Math.Round(ratio * 100)})";
        ValizProgressBar.Progress = ratio;
    }

    private void OnItemTapped(object sender, EventArgs e)
    {
        if (sender is BindableObject b && b.BindingContext is PackItem item)
        {
            item.IsPacked = !item.IsPacked;
            UpdateUI();
        }
    }

    private void OnTypeClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            LoadCategory(btn.Text);
        }
    }
}