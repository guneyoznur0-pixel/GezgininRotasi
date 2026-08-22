namespace GezginRotası2;

public partial class LocalDictionaryPage : ContentPage
{
    private readonly List<DialectWord> _allWords = new()
    {
        // 01 ADANA
        new() { City = "Adana", Word = "Dinelmek & Gadasını aldığım", Meaning = "Ayakta dikilmek / Derdini aldığım, canım", Example = "Aboov! Güneşin alnında ne dineliyon la orada, içeri girsene gadasını aldığım!" },
        // 02 ADIYAMAN
        new() { City = "Adıyaman", Word = "Kurban & Hele bax", Meaning = "Kıymetli hitap / Bir baksana", Example = "Hele bax kurban, gün doğmadan Nemrut'a yetişek." },
        // 03 AFYONKARAHİSAR
        new() { City = "Afyonkarahisar", Word = "Böyük & Bakıve", Meaning = "Büyük / Hemen bakıver (yöre ağzı)", Example = "Böyük caminin oradaki kaymakçıya bir bakıver hele." },
        // 04 AĞRI
        new() { City = "Ağrı", Word = "Bavo & Dengbêj", Meaning = "Baba, usta / Destan anlatan halk ozanı", Example = "Bavo hele bi otur divana, dengbêj dinleyek." },
        // 05 AMASYA
        new() { City = "Amasya", Word = "Ellâhem & Heri", Meaning = "Herhalde, galiba / Hadi artık", Example = "Ellâhem yağmur yağacak, Yalıboyu'na geçelim heri." },
        // 06 ANKARA
        new() { City = "Ankara", Word = "La bebe & Gardaş", Meaning = "Ankara'nın simge seslenişi ve hitabı", Example = "N'apıyon la bebe, Kızılay'a mı iniyon gardaşım?" },
        // 07 ANTALYA
        new() { City = "Antalya", Word = "Endirek & Bile yazmak", Meaning = "Dosdoğru gitmek / Neredeyse, az kalsın", Example = "Seniñ evin ordan endirek Kaleiçi'ne iniverdik." },
        // 08 ARTVİN
        new() { City = "Artvin", Word = "Habura & Uşağum", Meaning = "Tam burası / Çocuk, genç", Example = "Haburaya baksana ula, yaylaya çıkalım da kuymak yiyelim!" },
        // 09 AYDIN
        new() { City = "Aydın", Word = "Gari & Efeler", Meaning = "Artık, bundan sonra / Yiğit Aydınlılar", Example = "Hadi gari, pazara gidiverip iki kilo domat ile incir alıve gari!" },
        // 10 BALIKESİR
        new() { City = "Balıkesir", Word = "Kızan & Höşmerim", Meaning = "Genç delikanlı / Peynir tatlısı", Example = "Abe kızanım Susurluk'ta bir tost ayran yapıp Cunda'ya geçelim." },
        // 11 BİLECİK
        new() { City = "Bilecik", Word = "Goca usta & Bakıver", Meaning = "Büyük usta / Hızlıca bakmak", Example = "Goca usta Kınık köyünde çömleği ne güzel dönderiverdi." },
        // 12 BİNGÖL
        new() { City = "Bingöl", Word = "Keko & Mastuva", Meaning = "Ağabey, kardeş / Yöresel yoğurt aşı", Example = "Keko hele gel çay içek, Yüzen Adalar'a ne vakit gidek?" },
        // 13 BİTLİS
        new() { City = "Bitlis", Word = "Büryan & Bavo", Meaning = "Kuyu kebabı / Baba, dost", Example = "Büryan kokusu çarşıyı sarmış, hele gel bavo bir ziyafet çekek." },
        // 14 BOLU
        new() { City = "Bolu", Word = "Iccak & Mancar", Meaning = "Sıcak hava / Yenilebilir dağ otu", Example = "Bu ıccakta Abant Gölü kenarında oturup bir çay içek." },
        // 15 BURDUR
        new() { City = "Burdur", Word = "Gari & Şişçi", Meaning = "Artık / Burdur şiş ustası", Example = "Salda Gölü'ne gidiverelim gari, suyun mavisine baksana." },
        // 16 BURSA
        new() { City = "Bursa", Word = "Cantık & Bursalı", Meaning = "Fırın pidesi / Hemşehri hitabı", Example = "Heykel'e doğru çıkalım da iki cantık yiyip Kozahan'da dinlenelim." },
        // 17 ÇANAKKALE
        new() { City = "Çanakkale", Word = "Mari & Abe", Meaning = "Kadınlara seslenme / Pekiştirme", Example = "Abe mari, Bozcaada feribotuna yetişelim be ya!" },
        // 18 ÇANKIRI
        new() { City = "Çankırı", Word = "Yaren & Gadası", Meaning = "Dost meclisi üyesi / Canım", Example = "Yaren ocağında türküler başlasın hele gadasını aldığım." },
        // 19 ÇORUM
        new() { City = "Çorum", Word = "Herii & Ellâhem", Meaning = "Hadi artık / Galiba, herhalde", Example = "Ne diyon heri, saat kulesinin oradan sıcak leblebi alalım." },
        // 20 DENİZLİ
        new() { City = "Denizli", Word = "Gari & Bakıve", Meaning = "Ege pekiştirmesi / Bakıver", Example = "Denizli'nin sıcağı bastırdı, Pamukkale'ye doğru sürüve gari." },
        // 21 DİYARBAKIR
        new() { City = "Diyarbakır", Word = "Baboş & Ciğerim", Meaning = "Kıymetli dost / Canım ciğerim", Example = "Baboş gel hele On Gözlü Köprü'de bir demli kaçak çay içek." },
        // 22 EDİRNE
        new() { City = "Edirne", Word = "Abe & Be ya", Meaning = "Trakya'nın en meşhur ünlemleri", Example = "Abe kızanım, tava ciğeri yemeden Edirne'den geçilir mi be ya!" },
        // 23 ELAZIĞ
        new() { City = "Elazığ", Word = "Gakgoş & Cıbıl", Meaning = "Yiğit Elazığlı kardeş / Çıplak, yalın", Example = "Gakgoş sen ne diysen, akşama Harput Kalesi'ne çıxax mı?" },
        // 24 ERZİNCAN
        new() { City = "Erzincan", Word = "Babo & Gadası", Meaning = "Dost, ağabey / Derdini aldığım", Example = "Babo Kemaliye Karanlık Kanyon'un suyu buz gibidir, hele bir bak." },
        // 25 ERZURUM
        new() { City = "Erzurum", Word = "Gadasını aldığım & Zoval", Meaning = "Kurban olduğum / Zavallı", Example = "Nereye gedirsen, bi otur cağ kebap yiyek gadasını aldığım." },
        // 26 ESKİŞEHİR
        new() { City = "Eskişehir", Word = "Hafız & Çibörek", Meaning = "Arkadaş hitabı / Kırım böreği", Example = "Hafız Porsuk kenarında bi çibörek yiyip gondola binelim." },
        // 27 GAZİANTEP
        new() { City = "Gaziantep", Word = "Sahre & Hayfene", Meaning = "Pazar pikniği / İmece gençlik ziyafeti", Example = "Pazar günü bütün sülale Dülükbaba'ya sahreye gidiyoruz." },
        // 28 GİRESUN
        new() { City = "Giresun", Word = "Çotanak & Dible", Meaning = "Birleşik fındık dalı / Pirinçli karalahana", Example = "Çotanakları topladuk da akşama dible yapayruk uşağum." },
        // 29 GÜMÜŞHANE
        new() { City = "Gümüşhane", Word = "Pestil & Köme", Meaning = "Dut şıralı cevizli tatlılar", Example = "Harşit Çayı kenarında oturup bir taze köme yiyelim." },
        // 30 HAKKARİ
        new() { City = "Hakkari", Word = "Bavo & Keledoş", Meaning = "Ağabey / Dağ otlu yöre aşı", Example = "Hele bura bax bavo, Cilo buzullarının heybetine bak." },
        // 31 HATAY
        new() { City = "Hatay", Word = "Zahter & Kele", Meaning = "Dağ kekiği / Kadınlar arası hitap", Example = "Kele bacım, fırından yeni çıkmış sıcak biberli ekmek ile künefe ye!" },
        // 32 ISPARTA
        new() { City = "Isparta", Word = "Gari & Gül kokulu", Meaning = "Ege pekiştirmesi", Example = "Kuyucak lavanta tarlalarına gidive gari, mis gibi kokuyor." },
        // 33 MERSİN
        new() { City = "Mersin", Word = "Aboov & Tantuni", Meaning = "Şaşırma ünlemi / Meşhur dürüm", Example = "Aboov bu tantuni ne lezzetliymiş la, yanına bi acılı şalgam ver!" },
        // 34 İSTANBUL
        new() { City = "İstanbul", Word = "Kanka & Aynen", Meaning = "Metropol gençlik hitapları", Example = "Kanka Boğaz vapuruna yetişelim, martılara simit atarız." },
        // 35 İZMİR
        new() { City = "İzmir", Word = "Gevrek, Boyoz & Çiğdem", Meaning = "Simit, milföy böreği ve ayçekirdeği", Example = "Alsancak Kordon çimlerde çiğdem çitlerken gün batımını izleriz gari!" },
        // 36 KARS
        new() { City = "Kars", Word = "Hengel & Ola", Meaning = "Sarımsaklı hamur mantısı / Hey, delikanlı", Example = "Kars'a gelip de hengel yemeden, aşık atışması dinlemeden dönülmez ola." },
        // 37 KASTAMONU
        new() { City = "Kastamonu", Word = "Gediyba & Keleş", Meaning = "Gidiyor / Güzel, hoş", Example = "Nereye gediyba sen bu ıccakta, Horma Kanyonu'na gidelim ya!" },
        // 38 KAYSERİ
        new() { City = "Kayseri", Word = "Nöörüyon? & Bıldır", Meaning = "Ne yapıyorsun? / Geçen sene", Example = "Nöörüyon hemşerim? - İyidir nörüyüm, Erciyes'e mantı yemeye gidiyok." },
        // 39 KIRKLARELİ
        new() { City = "Kırklareli", Word = "Kızan & Kopil", Meaning = "Genç / Yaramaz çocuk", Example = "Kızanlar toplanmış İğneada Longozu'nda kano yapıyor be ya." },
        // 40 KIRŞEHİR
        new() { City = "Kırşehir", Word = "Bozlak & Gönül Dağı", Meaning = "Feryat türkü türü / Neşet Ertaş felsefesi", Example = "Neşet Usta sazı eline alınca bozkırın tozu kalkar gardaşım." },
        // 41 KOCAELİ
        new() { City = "Kocaeli", Word = "Hafız & Pişmaniye", Meaning = "Kocaeli hitabı / İpek tatlısı", Example = "Hafız Kartepe'ye kar yağmış, kayak yapmaya çıkalım mı?" },
        // 42 KONYA
        new() { City = "Konya", Word = "Göynek & Heri", Meaning = "İçlik, gömlek / Çabuk ol", Example = "Sırtına kalın bir göynek giy heri, Konya'nın ayazı çarpar." },
        // 43 KÜTAHYA
        new() { City = "Kütahya", Word = "Cimcik & Gari", Meaning = "Minik hamur yemeği / Artık", Example = "Aizanoi Antik Kenti'ne gidiverelim gari, Zeus Tapınağı'nı gör." },
        // 44 MALATYA
        new() { City = "Malatya", Word = "Mişmiş & Kirvem", Meaning = "Kayısı / Can dost", Example = "Bahçeden taze mişmiş topladık, gel beraber yiyelim kirvem." },
        // 45 MANİSA
        new() { City = "Manisa", Word = "Gidiver & Mesir", Meaning = "Tez gitmek / Şifalı macun", Example = "Spil Dağı'na çıkıverelim de yılkı atlarını izleyelim gari." },
        // 46 KAHRAMANMARAŞ
        new() { City = "Kahramanmaraş", Word = "Edem & Maraşlı", Meaning = "Ağabey, canım kardeşim", Example = "N'apıyon edem, Tarihi Çarşı'da bir satır dondurması keselim mi?" },
        // 47 MARDİN
        new() { City = "Mardin", Word = "Sembusek & Babo", Meaning = "Kapalı lahmacun / Dost, büyük", Example = "Babo taş konakların terasında oturup Süryani çöreği yiyek." },
        // 48 MUĞLA
        new() { City = "Muğla", Word = "Gelive & Bakıve", Meaning = "Ege tezlik kipi seslenişleri", Example = "Akşama Akyaka Azmak Çayı kenarına geliver gari, balık yiyelim." },
        // 49 MUŞ
        new() { City = "Muş", Word = "Çorti & Keko", Meaning = "Ekşili lahana aşı / Ağabey", Example = "Tarihi Murat Köprüsü'nün serinliğine gel hele keko." },
        // 50 NEVŞEHİR
        new() { City = "Nevşehir", Word = "Gadası & Testi", Meaning = "Canım / Çömlek kebabı", Example = "Sıcak hava balonları havalandı gadası, Göreme Vadisi'ne bak." },
        // 51 NİĞDE
        new() { City = "Niğde", Word = "Borlu & Gazoz", Meaning = "Bor ilçesi sakini / Meşhur gazoz", Example = "Geçti Bor'un pazarı, sür eşeği Niğde Kalesi'ne heri!" },
        // 52 ORDU
        new() { City = "Ordu", Word = "Pancar & Uşağum", Meaning = "Karalahana / Delikanlı", Example = "Boztepe'ye teleferikle çıkup Karadeniz'e bakalum uşağum." },
        // 53 RİZE
        new() { City = "Rize", Word = "Haçan & Ander kalsın", Meaning = "Mademki / Batsın, yok olsun", Example = "Haçan yaylaya çıktık, ander kalsın o telefonuni bırak da tulum dinle!" },
        // 54 SAKARYA
        new() { City = "Sakarya", Word = "Islama & Hafız", Meaning = "Soslu ekmekli köfte / Hemşehri", Example = "Hafız Sapanca Gölü kenarında yürüyüşe çıkalım sonra köfte yeriz." },
        // 55 SAMSUN
        new() { City = "Samsun", Word = "Pideci & Çakallı", Meaning = "Bafra pidesi ustası / Menemen durağı", Example = "Çakallı'da menemeni ekmeğe banıp Bandırma Vapuru'na geçelim." },
        // 56 SİİRT
        new() { City = "Siirt", Word = "Büryan & Kurban", Meaning = "Kuyu kebabı / Hitap", Example = "Büryanı sabah ezanında fırından taze yiyeceksin kurban." },
        // 57 SİNOP
        new() { City = "Sinop", Word = "Hamsilos & Mantı", Meaning = "Fiyort koyu / Cevizli mantı", Example = "Hamsilos fiyort koyunda rüzgara karşı bir çay içelum uşağum." },
        // 58 SİVAS
        new() { City = "Sivas", Word = "Heri & Yiğido", Meaning = "Hadi artık / Yiğit Sivaslı", Example = "Nereye koşuyon heri, Divriği Ulu Cami'nin gölgesine varalım!" },
        // 59 TEKİRDAĞ
        new() { City = "Tekirdağ", Word = "Abe & Kızan", Meaning = "Trakya seslenişi / Genç", Example = "Abe kızanım, köfteleri çevir de soğumasın be ya!" },
        // 60 TOKAT
        new() { City = "Tokat", Word = "Keleş & Bat", Meaning = "Güzel, hoş / Sulu mercimek yemeği", Example = "Tokat Kebabı pişti ellâhem, Ballıca Mağarası'na da uğrayalım." },
        // 61 TRABZON
        new() { City = "Trabzon", Word = "Ula & Kuymak", Meaning = "Hey delikanlı / Mıhlama", Example = "Haçan Sümela Manastırı'na varduk, bir kuymak yemeden dönmeyuk ula!" },
        // 62 TUNCELİ
        new() { City = "Tunceli", Word = "Cano & Kirvem", Meaning = "Canım / Yakın dost", Example = "Munzur Gözeleri'nin suyu gibi berrak ve duru olasın cano." },
        // 63 ŞANLIURFA
        new() { City = "Şanlıurfa", Word = "Hele & Gözüm", Meaning = "Bir baksana / Değerli dostum", Example = "Hele bir bax gözüm, Göbeklitepe insanlığın başladığı yerdir!" },
        // 64 UŞAK
        new() { City = "Uşak", Word = "Tarhana & Gari", Meaning = "Şifalı çorba / Artık", Example = "Ulubey Kanyonu'nun cam terasına varıverelim gari." },
        // 65 VAN
        new() { City = "Van", Word = "Bavo & Murtuğa", Meaning = "Baba, dost / Unlu kahvaltılık", Example = "Gevaş iskelesine gel bavo, Akdamar Adası motoru kalkıyor." },
        // 66 YOZGAT
        new() { City = "Yozgat", Word = "Arabaşı & Gadası", Meaning = "Hamurlu çorba / Canım", Example = "Arabaşı hamurunu çiğnemeden yutacaksın gadasını aldığım." },
        // 67 ZONGULDAK
        new() { City = "Zonguldak", Word = "Keleş & Mancar", Meaning = "Güzel çocuk / Karalahana", Example = "Maden ocağına inen emekçi kardeşlerimize selam olsun keleş uşağım." },
        // 68 AKSARAY
        new() { City = "Aksaray", Word = "Ihlara & Gadası", Meaning = "Kanyon vadisi / Canım", Example = "Ihlara Vadisi'ne inelim de Melendiz Çayı boyunca yürüyelim." },
        // 69 BAYBURT
        new() { City = "Bayburt", Word = "Lor Dolması & Ola", Meaning = "Pazılı dolma / Hey", Example = "Baksı Müzesi'nin tepesine çıkup Çoruh Nehri'ne bakalım ola." },
        // 70 KARAMAN
        new() { City = "Karaman", Word = "Batırık & Gari", Meaning = "Sıkma yöre aşı / Artık", Example = "Taşkale kaya ambarlarına bakıver gari, tarihin serinliğini hisset." },
        // 71 KIRIKKALE
        new() { City = "Kırıkkale", Word = "Keskinli & Gardaş", Meaning = "Abdal geleneği / Kardeş", Example = "Çeşnigir Kanyonu'nda tekne turuna çıkalım gardaşım." },
        // 72 BATMAN
        new() { City = "Batman", Word = "Kütülk & Babo", Meaning = "İçli köfte / Dost", Example = "Hasankeyf Arkeopark'taki taşınan türbelere bakmaya gel babo." },
        // 73 ŞIRNAK
        new() { City = "Şırnak", Word = "Suryaz & Bavo", Meaning = "Dağ otu aşı / Ağabey", Example = "Cizre Kırmızı Medrese'de El-Cezeri'nin izini sürelim bavo." },
        // 74 BARTIN
        new() { City = "Bartın", Word = "Keleş & Amasralı", Meaning = "Hoş, yakışıklı / Sahil insanı", Example = "Amasra Ceneviz Kalesi'ne baksana Karadeniz üstünde ne keleş duruyor." },
        // 75 ARDAHAN
        new() { City = "Ardahan", Word = "Malamat & Ola", Meaning = "Perişan / Hey delikanlı", Example = "Çıldır Gölü'nün buzu üstünde atlı kızakla turlayalım ola." },
        // 76 IĞDIR
        new() { City = "Iğdır", Word = "Piti & Ay balam", Meaning = "Çömlek yemeği / Canım yavrum", Example = "Ay balam, Ağrı Dağı'nın manzarasına karşı bir çay içek." },
        // 77 YALOVA
        new() { City = "Yalova", Word = "Yürüyen & Abe", Meaning = "Yürüyen Köşk / Pekiştirme", Example = "Atatürk'ün ağaç için kaydırdığı Yürüyen Köşk'ü gör be ya!" },
        // 78 KARABÜK
        new() { City = "Karabük", Word = "Safranlı & Bükme", Meaning = "Safranbolu lokumu / Taş fırın pidesi", Example = "Tarihi Safranbolu Çarşısı'nda lokum tadıp Kristal Teras'a çıkalım." },
        // 79 KİLİS
        new() { City = "Kilis", Word = "Kabaltı & Kurban", Meaning = "Kemerli sokak tüneli / Hitap", Example = "Kabaltıların altından serin serin geçip Kilis Tavası yiyek kurban." },
        // 80 OSMANİYE
        new() { City = "Osmaniye", Word = "Edem & Tirşik", Meaning = "Ağabey / Şifalı dağ çorbası", Example = "Zorkun Yaylası'na çıkalım da yayla havası alıp fıstık yiyek edem." },
        // 81 DÜZCE
        new() { City = "Düzce", Word = "Hafız & Melengücceği", Meaning = "Dost / Manda kaymaklı tatlı", Example = "Melen Çayı'nda bir rafting yapıp Akçakoca Kalesi'nde gün batımını izleyelim hafız." }
    };

    public LocalDictionaryPage()
    {
        InitializeComponent();
        LocalizationService.LanguageChanged += (s, e) => ApplyLocalization();
        ApplyLocalization();
        WordsCollection.ItemsSource = _allWords;
    }

    private void ApplyLocalization()
    {
        bool isEn = LocalizationService.IsEnglish;
        Title = LocalizationService.T("DialectTitle");
        PageTitleLabel.Text = isEn ? "🗣️ 81 Provinces Regional Dialect Atlas" : "🗣️ 81 İlin Yöresel Ağız & Deyimleri";
        PageSubtitleLabel.Text = isEn 
            ? "Blend in with the locals! Regional idioms, slang and expressions" 
            : "Gittiğin şehirde yabancılık çekme, yerel halk gibi konuş!";
        BtnFilterAll.Text = isEn ? "All" : "Tümü";
    }

    private void OnFilterClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            string regionOrCity = btn.Text;
            if (regionOrCity == "Tümü" || regionOrCity == "All")
            {
                WordsCollection.ItemsSource = _allWords;
            }
            else
            {
                WordsCollection.ItemsSource = _allWords
                    .Where(w => w.City.Contains(regionOrCity, StringComparison.OrdinalIgnoreCase) ||
                                w.Word.Contains(regionOrCity, StringComparison.OrdinalIgnoreCase) ||
                                w.Meaning.Contains(regionOrCity, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
        }
    }
}