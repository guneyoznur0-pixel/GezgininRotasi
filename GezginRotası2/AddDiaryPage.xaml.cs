namespace GezginRotası2;

public partial class AddDiaryPage : ContentPage
{
    public AddDiaryPage()
    {
        InitializeComponent();

        CityPicker.ItemsSource = new List<string>
        {
            "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya", "Kayseri",
            "Nevşehir (Kapadokya)", "Gaziantep", "Trabzon", "Muğla",
            "Şanlıurfa", "Konya", "Sivas", "Kırşehir", "Çanakkale", "Mardin"
        };
        CityPicker.SelectedIndex = 0;
        MoodPicker.SelectedIndex = 0;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        string title = TitleEntry.Text?.Trim() ?? string.Empty;
        string content = ContentEditor.Text?.Trim() ?? string.Empty;
        string city = CityPicker.SelectedItem?.ToString() ?? "Bilinmeyen Şehir";
        string mood = MoodPicker.SelectedItem?.ToString()?.Split(' ')[0] ?? "🤩";

        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
        {
            await DisplayAlert("Uyarı", "Lütfen en azından bir başlık ve kısa bir anı yazın!", "Tamam");
            return;
        }

        var newEntry = new DiaryEntry
        {
            City = city,
            Title = title,
            Content = content,
            MoodEmoji = mood,
            DateText = DateTime.Now.ToString("dd MMMM yyyy")
        };

        await DiaryService.SaveEntryAsync(newEntry);
        await DisplayAlert("Başarılı 🎉", "Gezi anınız günlüğünüze kaydedildi!", "Harika");
        await Navigation.PopAsync();
    }
}