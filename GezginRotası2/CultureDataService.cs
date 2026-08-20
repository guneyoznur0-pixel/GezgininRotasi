namespace GezginRotası2;

public class CultureDataService
{
    private readonly List<HistoricPerson> _people = new()
    {
        new() { City = "Konya", Name = "Mevlana Celaleddin-i Rumi", Title = "Evrensel Mutasavvıf & Şair", Bio = "Sevgi, hoşgörü ve tasavvuf felsefesiyle tüm dünyayı etkileyen büyük düşünür." },
        new() { City = "Kırşehir", Name = "Neşet Ertaş", Title = "Bozkırın Tezenesi", Bio = "Türk halk müziğinin efsanevi ozanı, abdallık geleneğinin son büyük temsilcisi." },
        new() { City = "Sivas", Name = "Aşık Veysel", Title = "Gönül Gözüyle Gören Ozan", Bio = "Türküleriyle insan sevgisini ve doğayı anlatan halk ozanımız." },
        new() { City = "Bursa", Name = "Zeki Müren", Title = "Sanat Güneşi", Bio = "Türk Sanat Müziği'nin unutulmaz sesi ve bestekarı." },
        new() { City = "Mardin", Name = "Aziz Sancar", Title = "Nobel Ödüllü Bilim İnsanı", Bio = "DNA onarımı alanındaki keşifleriyle Nobel Kimya Ödülü'nü kazanan gururumuz." },
        new() { City = "Eskişehir", Name = "Yunus Emre", Title = "Gönüllerin Şairi", Bio = "Dili Türkçe olan sevgi, barış ve kardeşlik şiirlerinin mimarı." },
        new() { City = "Rize", Name = "Kazım Koyuncu", Title = "Şair Ceketli Çocuk", Bio = "Karadeniz rock müziğinin ve doğa sevgisinin efsanevi sesi." }
    };

    private readonly List<FolkSong> _songs = new()
    {
        new() { City = "Kayseri", Title = "Gesi Bağları", Artist = "Kayseri Yöresi", Story = "Gurbetteki gelinlerin hasretini ve kederini anlatan en dokunaklı Anadolu ağıtlarından biridir." },
        new() { City = "Kırşehir", Title = "Gönül Dağı", Artist = "Neşet Ertaş", Story = "Bozkırın hüznünü ve derin aşkı en saf duygularla anlatan başyapıt." },
        new() { City = "Sivas", Title = "Uzun İnce Bir Yoldayım", Artist = "Aşık Veysel", Story = "İnsan ömrünün doğumdan ölüme kadar geçen seyahatini anlatan ölümsüz eser." },
        new() { City = "Bursa", Title = "Bursa'nın Ufak Tefek Taşları", Artist = "Bursa Yöresi", Story = "Bursa'nın tarihi sokaklarını ve geleneksel neşesini anlatan kıpır kıpır bir türkü." },
        new() { City = "Trabzon", Title = "Gelevera Deresi", Artist = "Karadeniz Yöresi / Kazım Koyuncu", Story = "Karadeniz dağlarının sisini ve kavuşamayan sevdalıları anlatan efsane türkü." },
        new() { City = "İzmir", Title = "İzmir'in Kavakları", Artist = "Ege Yöresi / Çakıcı Efe", Story = "Ege efelerinin cesaretini ve hürriyet sevdasını anlatan zeybek klasiği." }
    };

    public (List<HistoricPerson> people, List<FolkSong> songs) GetCultureData(string city)
    {
        if (string.IsNullOrWhiteSpace(city) || city == "Tüm Türkiye")
        {
            return (_people, _songs);
        }

        var p = _people.Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
        var s = _songs.Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();

        return (p, s);
    }
}