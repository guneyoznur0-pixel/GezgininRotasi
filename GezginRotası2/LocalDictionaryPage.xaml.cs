namespace GezginRotası2;

public partial class LocalDictionaryPage : ContentPage
{
    private readonly List<DialectWord> _allWords = new()
    {
        // İZMİR
        new() { City = "İzmir", Word = "Gevrek", Meaning = "Simit", Example = "— Sabah iki gevrek bir tulum peyniri al gel." },
        new() { City = "İzmir", Word = "Çiğdem", Meaning = "Ayçekirdeği", Example = "— Kordon'da çiğdem çitleyip gün batımını izledik." },
        new() { City = "İzmir", Word = "Domat", Meaning = "Domates", Example = "— Pazardan taze domat aldım." },

        // KARADENİZ
        new() { City = "Karadeniz", Word = "Haçan", Meaning = "Mademki, ne zaman ki", Example = "— Haçan yaylaya çıktık, bir horon vuralım!" },
        new() { City = "Karadeniz", Word = "Uy aha!", Meaning = "Şaşkınlık ve hayret ünlemi", Example = "— Uy aha! Şu dağın güzelliğine bak!" },
        new() { City = "Karadeniz", Word = "Ula", Meaning = "Hey, baksana (seslenme)", Example = "— Ula uşağım nereye kayboldun?" },

        // KAYSERİ
        new() { City = "Kayseri", Word = "Nöörüyon?", Meaning = "Ne yapıyorsun? Nasılsın?", Example = "— Nöörüyon hemşerim? — İyidir nörüyüm, sen nörüyorsun?" },
        new() { City = "Kayseri", Word = "Bıldır", Meaning = "Geçen sene", Example = "— Bıldır Erciyes'te çok fena kar vardı." },
        new() { City = "Kayseri", Word = "Cıbıl", Meaning = "Çıplak / Üstü başı ince", Example = "— Bu soğukta cıbıl gezme, hasta olursun." },

        // ADANA
        new() { City = "Adana", Word = "Gadasını aldığım", Meaning = "Kurban olduğum, canını sevdiğim (Sevgi sözü)", Example = "— Gel otur gadasını aldığım, bir acılı şalgam içelim." },
        new() { City = "Adana", Word = "Kele", Meaning = "Yahu, baksana (seslenme)", Example = "— Kele kız nereye gidiyorsun öyle?" },

        // GAZİANTEP
        new() { City = "Gaziantep", Word = "Sahre", Meaning = "Piknik / Mesire gezisi", Example = "— Pazar günü ailecek sahreye gidiyoruz." },
        new() { City = "Gaziantep", Word = "Hayfene", Meaning = "İmece usulü ortak eğlence/ziyafet", Example = "— Gençler toplanıp hayfene yapmışlar." },

        // ERZURUM
        new() { City = "Erzurum", Word = "Ola", Meaning = "Arkadaş, birader (seslenme)", Example = "— Ola bura ne kadar soğukmuş böyle!" },
        new() { City = "Erzurum", Word = "Tuman", Meaning = "Kalın alt giysi / Şalvar", Example = "— Palandöken'e çıkarken tumanını giymeyi unutma." }
    };

    public LocalDictionaryPage()
    {
        InitializeComponent();
        WordsCollection.ItemsSource = _allWords;
    }

    private void OnFilterClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            string city = btn.Text;
            WordsCollection.ItemsSource = (city == "Tümü")
                ? _allWords
                : _allWords.Where(w => w.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}