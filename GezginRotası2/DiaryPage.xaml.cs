namespace GezginRotası2;

public partial class DiaryPage : ContentPage
{
    public DiaryPage()
    {
        InitializeComponent();
        LocalizationService.LanguageChanged += (s, e) => ApplyLocalization();
        ApplyLocalization();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        ApplyLocalization();
        await LoadEntriesAsync();
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;
        Title = LocalizationService.T("DiaryTitle");
        PageHeaderLabel.Text = isEn ? "My Travel Notes & Memories" : "Gezi Notlarım & Anılarım";
        PageSubtitleLabel.Text = isEn 
            ? "Immortalize your travel moments across Turkey" 
            : "Gittiğin yerlerdeki hatıralarını ölümsüzleştir";
        BtnNewEntry.Text = isEn ? "✍️ Write New Memory" : "✍️ Yeni Anı Yaz";

        EmptyTitleLabel.Text = isEn ? "No travel memories added yet." : "Henüz bir gezi anısı eklemediniz.";
        EmptySubtitleLabel.Text = isEn 
            ? "Tap 'Write New Memory' to record your first adventure!" 
            : "'Yeni Anı Yaz' butonuna basarak ilk hatıranızı kaydedin!";
    }

    private async Task LoadEntriesAsync()
    {
        var entries = await DiaryService.LoadDiaryAsync();
        DiaryCollection.ItemsSource = entries;
    }

    private async void OnAddEntryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddDiaryPage());
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (sender is Button btn && btn.CommandParameter is string id)
        {
            bool isEn = LocalizationService.IsEnglish;
            bool answer = await DisplayAlert(
                isEn ? "Delete Memory?" : "Silinsin mi?", 
                isEn ? "Are you sure you want to delete this travel memory?" : "Bu gezi anınızı silmek istediğinize emin misiniz?", 
                isEn ? "Yes, Delete" : "Evet, Sil", 
                isEn ? "Cancel" : "Vazgeç");

            if (answer)
            {
                await DiaryService.DeleteEntryAsync(id);
                await LoadEntriesAsync();
            }
        }
    }
}