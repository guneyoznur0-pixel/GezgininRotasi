namespace GezginRotası2;

public class PackItem
{
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = "📦";
    public bool IsPacked { get; set; }
    public Color TextColor => IsPacked ? Color.FromArgb("#707688") : Colors.White;
    public TextDecorations TextDecoration => IsPacked ? TextDecorations.Strikethrough : TextDecorations.None;
}

public partial class PackingChecklistPage : ContentPage
{
    private List<PackItem> _currentList = new();
    private string _currentType = "summer";

    public PackingChecklistPage()
    {
        InitializeComponent();
        LocalizationService.LanguageChanged += (s, e) => ApplyLocalization();
        ApplyLocalization();
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;
        Title = LocalizationService.T("PackingTitle");
        ValizHeaderLabel.Text = isEn ? "Packing Progress" : "Valiz Hazırlık Durumu";

        BtnCatSummer.Text = isEn ? "☀️ Summer / Beach" : "☀️ Yaz / Deniz";
        BtnCatCulture.Text = isEn ? "🍂 City & Culture" : "🍂 Şehir & Kültür";
        BtnCatWinter.Text = isEn ? "❄️ Winter & Ski" : "❄️ Kış & Kayak";
        BtnCatCamp.Text = isEn ? "🏕️ Nature & Camp" : "🏕️ Doğa & Kamp";

        LoadCategory(_currentType);
    }

    private void LoadCategory(string type)
    {
        _currentType = type;
        bool isEn = LocalizationService.IsEnglish;

        _currentList = type switch
        {
            "summer" or "☀️ Yaz / Deniz" or "☀️ Summer / Beach" => new List<PackItem>
            {
                new() { Title = isEn ? "Sunscreen & Sunglasses" : "Güneş Kremi & Güneş Gözlüğü", Icon = "🕶️" },
                new() { Title = isEn ? "Swimwear & Beach Towel" : "Mayo / Şort & Plaj Havlusu", Icon = "🩳" },
                new() { Title = isEn ? "Hat & Flip Flops" : "Şapka & Terlik", Icon = "🧢" },
                new() { Title = isEn ? "Powerbank & Charger" : "Powerbank & Şarj Aleti", Icon = "🔋" },
                new() { Title = isEn ? "Passport / ID & Credit Cards" : "Kimlik & Ehliyet & Kartlar", Icon = "💳" },
                new() { Title = isEn ? "Personal Meds & Band-aids" : "Kişisel İlaçlar & Yara Bandı", Icon = "💊" },
                new() { Title = isEn ? "Light Summer Clothes" : "Hafif Yazlık Kıyafetler", Icon = "👕" }
            },
            "winter" or "❄️ Kış & Kayak" or "❄️ Winter & Ski" => new List<PackItem>
            {
                new() { Title = isEn ? "Thermal Underwear & Wool Socks" : "Termal İçlik & Yün Çorap", Icon = "🧦" },
                new() { Title = isEn ? "Snow Jacket & Waterproof Pants" : "Kar Montu & Su Geçirmez Pantolon", Icon = "🧥" },
                new() { Title = isEn ? "Beanie, Scarf & Heavy Gloves" : "Bere, Atkı & Kalın Eldiven", Icon = "🧤" },
                new() { Title = isEn ? "Snow Boots / Trekking Shoes" : "Kar Botu / Trekking Ayakkabısı", Icon = "🥾" },
                new() { Title = isEn ? "Lip Balm & Moisturizer" : "Dudak Koruyucu & Nemlendirici Krem", Icon = "🧴" },
                new() { Title = isEn ? "Thermos Flask & Hot Drink" : "Termos & Sıcak İçecek", Icon = "☕" },
                new() { Title = isEn ? "Powerbank (Drains fast in cold)" : "Powerbank (Soğukta hızlı biter)", Icon = "🔋" }
            },
            "camp" or "🏕️ Doğa & Kamp" or "🏕️ Nature & Camp" => new List<PackItem>
            {
                new() { Title = isEn ? "Tent & Sleeping Bag & Mat" : "Çadır & Uyku Tulumu & Mat", Icon = "⛺" },
                new() { Title = isEn ? "Headlamp / Torch & Spare Batteries" : "Kafa Lambası / Fener & Yedek Pil", Icon = "🔦" },
                new() { Title = isEn ? "Pocket Knife / Multi-tool" : "Çakı / Çok Amaçlı Bıçak", Icon = "🔪" },
                new() { Title = isEn ? "Insect / Mosquito Repellent Spray" : "Sinek / Böcek Kovucu Sprey", Icon = "🦟" },
                new() { Title = isEn ? "First Aid Kit" : "İlk Yardım Çantası", Icon = "🩹" },
                new() { Title = isEn ? "Camp Stove & Water Canteen" : "Kamp Ocağı & Termos & Matara", Icon = "🍳" },
                new() { Title = isEn ? "Waterproof Windbreaker" : "Su Geçirmez Rüzgarlık", Icon = "🧥" }
            },
            _ => new List<PackItem> // City & Culture
            {
                new() { Title = isEn ? "Comfortable Walking / Sports Shoes" : "Rahat Yürüyüş / Spor Ayakkabısı", Icon = "👟" },
                new() { Title = isEn ? "Museum Pass & Booking Documents" : "MüzeKart & Rezervasyon Belgeleri", Icon = "🎟️" },
                new() { Title = isEn ? "Earphones & Camera / Smartphone" : "Kulaklık & Fotoğraf Makinesi / Telefon", Icon = "📸" },
                new() { Title = isEn ? "Lightweight Day Backpack" : "Küçük Sırt Çantası", Icon = "🎒" },
                new() { Title = isEn ? "Light Cardigan / Rain Jacket" : "Hafif Hırka / Yağmurluk", Icon = "🧥" },
                new() { Title = isEn ? "Wet Wipes & Hand Sanitizer" : "Islak Mendil & Dezenfektan", Icon = "🧼" },
                new() { Title = isEn ? "ID, Wallet & Local Cash (TL)" : "Kimlik & Cüzdan & Nakit Para", Icon = "💵" }
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

        ProgressLabel.Text = LocalizationService.IsEnglish 
            ? $"{packed} / {total} Items (%{Math.Round(ratio * 100)})" 
            : $"{packed} / {total} Eşya (%{Math.Round(ratio * 100)})";
            
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
            // Reset styles
            BtnCatSummer.BackgroundColor = Color.FromArgb("#1E2330");
            BtnCatCulture.BackgroundColor = Color.FromArgb("#1E2330");
            BtnCatWinter.BackgroundColor = Color.FromArgb("#1E2330");
            BtnCatCamp.BackgroundColor = Color.FromArgb("#1E2330");

            btn.BackgroundColor = Color.FromArgb("#FF7F00");

            LoadCategory(btn.Text);
        }
    }
}