namespace GezginRotası2;

public class CultureDataService
{
    private readonly List<HistoricPerson> _people = new()
    {
        // KİLİS
        new() { City = "Kilis", Name = "Kilisli Muallim Rıfat", Title = "Büyük Türkolog ve Dil Bilimci", Bio = "Divânu Lugâti't-Türk eserini keşfedip Türk kültürüne kazandıran büyük edebiyatçı." },
        new() { City = "Kilis", Name = "Şahin Bey & Kuvay-ı Milliye", Title = "Milli Mücadele Kahramanları", Bio = "Kilis ve Antep savunmasında canını feda eden istiklal şehitlerimiz." },

        // KONYA
        new() { City = "Konya", Name = "Mevlana Celaleddin-i Rumi", Title = "Evrensel Mutasavvıf & Düşünür", Bio = "Sevgi, hoşgörü ve tasavvuf felsefesiyle tüm dünyayı etkileyen büyük düşünür." },
        new() { City = "Konya", Name = "Nasreddin Hoca", Title = "Halk Bilgesi ve Nüktedan", Bio = "Akşehir'de yaşamış, fıkralarıyla ders veren Türk halk bilgesi." },

        // KIRŞEHİR & SİVAS
        new() { City = "Kırşehir", Name = "Neşet Ertaş", Title = "Bozkırın Tezenesi", Bio = "Türk halk müziğinin efsanevi ozanı, abdallık geleneğinin son büyük temsilcisi." },
        new() { City = "Sivas", Name = "Aşık Veysel", Title = "Gönül Gözüyle Gören Ozan", Bio = "Türküleriyle insan sevgisini ve doğayı anlatan halk ozanımız." },

        // BURSA & İSTANBUL
        new() { City = "Bursa", Name = "Zeki Müren & Müzeyyen Senar", Title = "Sanat Güneşi ve Cumhuriyetin Divası", Bio = "Türk Sanat Müziği'nin unutulmaz iki büyük efsane sesi." },
        new() { City = "İstanbul", Name = "Mimar Sinan & Yahya Kemal", Title = "Koca Mimar ve Şair", Bio = "İstanbul'un siluetini ve ruhunu mısralara ve taşlara işleyen dev isimler." },

        // MARDİN & GAZİANTEP
        new() { City = "Mardin", Name = "Aziz Sancar", Title = "Nobel Ödüllü Bilim İnsanı", Bio = "DNA onarımı alanındaki keşifleriyle Nobel Kimya Ödülü'nü kazanan gururumuz." },
        new() { City = "Gaziantep", Name = "Şahin Bey", Title = "Kurtuluş Savaşı Kahramanı", Bio = "Gaziantep savunmasının sembolleşmiş efsanevi komutanı." },

        // ESKİŞEHİR & RİZE
        new() { City = "Eskişehir", Name = "Yunus Emre", Title = "Gönüllerin Şairi", Bio = "Dili Türkçe olan sevgi, barış ve kardeşlik şiirlerinin mimarı." },
        new() { City = "Rize", Name = "Kazım Koyuncu", Title = "Şair Ceketli Çocuk", Bio = "Karadeniz müziğini ve doğa sevgisini gençliğe aşılayan efsane sanatçı." }
    };

    private readonly List<FolkSong> _songs = new()
    {
        // KİLİS
        new() { City = "Kilis", Title = "Kilis'in Bağları & Yoğurt Koydum Dolaba", Artist = "Kilis Yöresi", Story = "Kilis'in zeytin ve bağ kültürünü, geleneksel neşesini anlatan kıpır kıpır bir türkü." },
        new() { City = "Kilis", Title = "Zeytinyağlı Yiyemem Aman", Artist = "Güneydoğu Yöresi", Story = "Kilis ve civarında zeytin hasadı zamanı dillerden düşmeyen meşhur ezgi." },

        // DİĞER ŞEHİRLER
        new() { City = "Kayseri", Title = "Gesi Bağları", Artist = "Selda Bağcan / Barış Manço", Story = "Gurbetteki gelinlerin hasretini anlatan en dokunaklı Anadolu ağıtlarından biridir." },
        new() { City = "Kırşehir", Title = "Gönül Dağı", Artist = "Neşet Ertaş", Story = "Bozkırın hüznünü ve derin aşkı en saf duygularla anlatan başyapıt." },
        new() { City = "Sivas", Title = "Uzun İnce Bir Yoldayım", Artist = "Aşık Veysel", Story = "İnsan ömrünün doğumdan ölüme kadar geçen seyahatini anlatan ölümsüz eser." },
        new() { City = "Trabzon", Title = "Gelevera Deresi", Artist = "Kazım Koyuncu", Story = "Karadeniz dağlarının sisini ve kavuşamayan sevdalıları anlatan efsane türkü." },
        new() { City = "İzmir", Title = "İzmir'in Kavakları", Artist = "Ege Yöresi / Çakıcı Efe", Story = "Ege efelerinin cesaretini ve hürriyet sevdasını anlatan zeybek klasiği." },
        new() { City = "Gaziantep", Title = "Antep'in Hamamları", Artist = "Gaziantep Yöresi", Story = "Gaziantep'in köklü hamam ve yemek kültürünü anlatan neşeli türkü." },
        new() { City = "Şanlıurfa", Title = "Urfa'nın Etrafı Dumanlı Dağlar", Artist = "İbrahim Tatlıses / Urfa Sıra Gecesi", Story = "Sıra gecelerinin vazgeçilmezi olan derin duygulu Urfa klasiği." }
    };

    public (List<HistoricPerson> people, List<FolkSong> songs) GetCultureData(string city)
    {
        if (string.IsNullOrWhiteSpace(city) || city == "Tüm Türkiye")
        {
            return (_people, _songs);
        }

        var p = _people.Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
        var s = _songs.Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();

        // 81 İLİN HİÇBİRİ ASLA BOŞ KALMASIN DİYE AKILLI TAMAMLAMA MOTORU
        if (p.Count == 0)
        {
            p.Add(new HistoricPerson
            {
                City = city,
                Name = $"{city} Halk Ozanları & Bilgeleri",
                Title = "Yöresel Kültür Elçileri",
                Bio = $"{city} ilimizin tarih boyunca yetiştirdiği ozanlar, mutasavvıflar ve ilim insanları yöre kültürünü günümüze taşımıştır."
            });
            p.Add(new HistoricPerson
            {
                City = city,
                Name = $"{city} Milli Mücadele Kahramanları",
                Title = "İstiklal ve Cumhuriyet Şehitleri",
                Bio = $"Kurtuluş Savaşı'nda {city} müdafaasında canını siper eden kahraman ecdadımız."
            });
        }

        if (s.Count == 0)
        {
            s.Add(new FolkSong
            {
                City = city,
                Title = $"{city} Yöresi Oyun Havaları & Türküleri",
                Artist = $"{city} TRT Radyo / Mahalli Sanatçıları",
                Story = $"{city} ilimizin dağlarını, sevdalarını ve köklü geleneklerini anlatan yöresel türkü."
            });
            s.Add(new FolkSong
            {
                City = city,
                Title = $"{city} Halay ve Karşılama Havaları",
                Artist = "Yöresel Müzik Grubu",
                Story = $"Düğünlerde ve bayramlarda coşkuyla çalınan geleneksel {city} ezgisi."
            });
        }

        return (p, s);
    }
}