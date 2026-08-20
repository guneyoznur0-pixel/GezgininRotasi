namespace GezginRotası2;

public partial class DiaryPage : ContentPage
{
    public DiaryPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadEntriesAsync();
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
            bool answer = await DisplayAlert("Silinsin mi?", "Bu gezi anınızı silmek istediğinize emin misiniz?", "Evet, Sil", "Vazgeç");
            if (answer)
            {
                await DiaryService.DeleteEntryAsync(id);
                await LoadEntriesAsync();
            }
        }
    }
}