namespace GezginRotası2;

public class PlacesDataService
{
    private readonly List<PlaceItem> _places = new()
    {
        // ==========================================
        // 01 ADANA
        // ==========================================
        new() { City = "Adana", Name = "Varda Köprüsü (Alman Köprüsü) - Karaisalı", Category = "Gezilecek", Description = "1912 yapımı, 99 metre yükseklikteki anıtsal demiryolu viyadüğü ve kanyon manzarası.", ImageUrl = "https://images.unsplash.com/photo-1544620347-c4fd4a3d5957?q=80&w=800", Rating = 4.9 },
        new() { City = "Adana", Name = "Kapıkaya Kanyonu - Karaisalı", Category = "Gezilecek", Description = "Çakıt Çayı boyunca uzanan 20 km kanyon, ahşap yürüyüş parkurları ve şelaleler.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Adana", Name = "Tarihi Taşköprü & Seyhan Nehri", Category = "Gezilecek", Description = "Roma İmparatoru Hadrianus döneminden kalan dünyanın en eski taş köprüsü.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.8 },
        new() { City = "Adana", Name = "Büyük Saat Kulesi & Kazancılar Çarşısı", Category = "Gezilecek", Description = "Türkiye'nin en uzun saat kulesi (32 m) ve sabah ciğercilerinin tarihi çarşısı.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },
        new() { City = "Adana", Name = "Anavarza Antik Kenti & Kalesi - Kozan", Category = "Müzeler", Description = "UNESCO Dünya Mirası Geçici Listesi, anıtsal zafer takı ve sütunlu cadde.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 02 ADIYAMAN
        // ==========================================
        new() { City = "Adıyaman", Name = "Nemrut Dağı Tümülüsü & Heykelleri - Kahta", Category = "Müzeler", Description = "UNESCO Dünya Mirası, 2150 m zirvede Kommagene Kralı Antiochos ve dev tanrı heykelleri.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 5.0 },
        new() { City = "Adıyaman", Name = "Cendere Köprüsü (Roma Köprüsü) - Kahta", Category = "Gezilecek", Description = "Septimius Severus adına yaptırılan harçsız kesme taşlardan dünyanın en eski kemerli köprüsü.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.9 },
        new() { City = "Adıyaman", Name = "Arsemia Antik Kenti & Kaya Tüneli - Kahta", Category = "Müzeler", Description = "Kommagene yazlık başkenti, Herakles ile Antiochos tokalaşma steli ve 158 m tünel.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },
        new() { City = "Adıyaman", Name = "Perre Antik Kenti & Kaya Mezarları", Category = "Müzeler", Description = "Roma ordularının konaklama merkezi ve yüzlerce kayaya oyulmuş mezar odası.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 03 AFYONKARAHİSAR
        // ==========================================
        new() { City = "Afyonkarahisar", Name = "Tarihi Afyon Kalesi & Zirvesi", Category = "Gezilecek", Description = "226 metre yükseklikte volkanik kaya kütlesi üzerine kurulu 3300 yıllık Hitit kalesi.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.8 },
        new() { City = "Afyonkarahisar", Name = "Frig Vadisi & Emre Gölü - İhsaniye", Category = "Gezilecek", Description = "Kaya oyma anıtlar, peribacaları, kale yerleşimleri ve gölde sıcak hava balonu turları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Afyonkarahisar", Name = "Afyon Konakları & Zafer Müzesi", Category = "Müzeler", Description = "Rengarenk restore edilmiş Osmanlı konakları ve Başkomutanlık Karargahı Zafer Müzesi.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.7 },

        // ==========================================
        // 04 AĞRI
        // ==========================================
        new() { City = "Ağrı", Name = "İshak Paşa Sarayı - Doğubayazıt", Category = "Müzeler", Description = "Topkapı Sarayı'ndan sonra 2. büyük saray; Osmanlı, Selçuklu ve Barok mimari şaheseri.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 5.0 },
        new() { City = "Ağrı", Name = "Ağrı Dağı Milli Parkı & Meteor Çukuru", Category = "Gezilecek", Description = "5.137 m zirveli Türkiye'nin çatısı ve dünyanın en derin 2. meteor krateri çukuru.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Ağrı", Name = "Balık Gölü Tabiat Parkı - Taşlıçay", Category = "Gezilecek", Description = "2241 m rakımda Türkiye'nin en yüksek tatlı su gölü ve alabalık vadisi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 05 AMASYA
        // ==========================================
        new() { City = "Amasya", Name = "Kral Kaya Mezarları & Harşena Kalesi", Category = "Gezilecek", Description = "Kalker kayalara oyulmuş Pontus Kralları anıt mezarları ve UNESCO adayı kale.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },
        new() { City = "Amasya", Name = "Yalıboyu Ahşap Evleri & Hazeranlar Konağı", Category = "Gezilecek", Description = "Yeşilırmak kıyısında sıralanan cumbalı tarihi Osmanlı yalıları ve etnografya müzesi.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.9 },
        new() { City = "Amasya", Name = "Amasya Arkeoloji ve Mumyalar Müzesi", Category = "Müzeler", Description = "İlhanlılar dönemine ait dünyaca ünlü mumyalar ve Selçuklu hazineleri.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.8 },
        new() { City = "Amasya", Name = "Boraboy Gölü Tabiat Parkı - Taşova", Category = "Gezilecek", Description = "Zümrüt yeşili krater heyelan gölü, çam ormanları ve ahşap yürüyüş yolları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 06 ANKARA
        // ==========================================
        new() { City = "Ankara", Name = "Anıtkabir & Atatürk Müzesi", Category = "Müzeler", Description = "Gazi Mustafa Kemal Atatürk'ün anıt mezarı, Aslanlı Yol ve Kurtuluş Savaşı Müzesi.", ImageUrl = "https://images.unsplash.com/photo-1589829545856-d10d557cf95f?q=80&w=800", Rating = 5.0 },
        new() { City = "Ankara", Name = "Anadolu Medeniyetleri Müzesi & Ankara Kalesi", Category = "Müzeler", Description = "Avrupa'da yılın müzesi ödüllü, Paleolitik çağdan Hititlere devasa arkeoloji hazinesi.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.9 },
        new() { City = "Ankara", Name = "Beypazarı Tarihi Konakları & İnözü Vadisi", Category = "Gezilecek", Description = "Geleneksel ahşap Osmanlı evleri, Yaşayan Müze ve gümüş telkâri çarşıları.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },
        new() { City = "Ankara", Name = "Eymir Gölü & Mogan Parkı - Gölbaşı", Category = "Gezilecek", Description = "Çam ormanları içinde bisiklet turları, göl yürüyüş parkuru ve yelken kulübü.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 07 ANTALYA
        // ==========================================
        new() { City = "Antalya", Name = "Kaleiçi, Hadrian Kapısı & Hıdırlık Kulesi", Category = "Gezilecek", Description = "Antik Roma surları, cumbalı Osmanlı konakları, Yat Limanı ve Üçkapılar.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Antalya", Name = "Kaş, Kaputaş Plajı & Kekova Batık Şehir", Category = "Gezilecek", Description = "Kanyon ağzındaki turkuaz plaj, Simena Kalesi ve su altındaki antik kent batıkları.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 5.0 },
        new() { City = "Antalya", Name = "Aspendos Antik Tiyatrosu & Perge - Serik", Category = "Müzeler", Description = "Dünyanın en iyi korunmuş 15.000 kişilik Roma tiyatrosu ve anıtsal sütunlu caddeler.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Antalya", Name = "Düden & Manavgat Şelaleleri", Category = "Gezilecek", Description = "Falezlerden 40 metre yükseklikten Akdeniz'e dökülen doğa harikası şelaleler.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Antalya", Name = "Alanya Kalesi, Kızılkule & Damlataş", Category = "Gezilecek", Description = "Selçuklu Tersanesi, yarımada surları ve astıma iyi gelen sarkıt mağarası.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 08 ARTVİN
        // ==========================================
        new() { City = "Artvin", Name = "Borçka Karagöl Tabiat Parkı", Category = "Gezilecek", Description = "Ladin ve kayın ormanları arasında ayna gibi parlayan heyelan set gölü ve yürüyüş parkuru.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Artvin", Name = "Şavşat Karagöl & Macahel Vadisi", Category = "Gezilecek", Description = "UNESCO Biyosfer Rezervi, Maral Şelalesi ve İsviçre Alpleri'ni andıran yayla köyleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Artvin", Name = "Mençuna Şelalesi & Çifte Köprü - Arhavi", Category = "Gezilecek", Description = "Kamilet Vadisi'nde 100 metreden dökülen görkemli şelale ve 18. yy kemer köprüleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 09 AYDIN
        // ==========================================
        new() { City = "Aydın", Name = "Aphrodisias Antik Kenti & Müzesi - Karacasu", Category = "Müzeler", Description = "UNESCO Dünya Mirası, dev antik stadyum, Tetrapylon kapısı ve heykeltıraşlık okulu.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 5.0 },
        new() { City = "Aydın", Name = "Dilek Yarımadası Milli Parkı & Zeus Mağarası", Category = "Gezilecek", Description = "Kuşadası'nda turkuaz bakir koylar, kanyon yürüyüş parkuru ve dağ göleti mağarası.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 4.9 },
        new() { City = "Aydın", Name = "Didim Apollon Tapınağı & Milet Antik Kenti", Category = "Müzeler", Description = "Antik dünyanın en büyük kehanet tapınaklarından biri ve filozoflar kenti tiyatrosu.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 10 BALIKESİR
        // ==========================================
        new() { City = "Balıkesir", Name = "Cunda Adası & Taksiyarhis Kilisesi - Ayvalık", Category = "Gezilecek", Description = "Tarihi Rum taş evleri, Arnavut kaldırımlı sokaklar ve Rahmi Koç Müzesi.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },
        new() { City = "Balıkesir", Name = "Şeytan Sofrası & Ayvalık Adaları", Category = "Gezilecek", Description = "Lav birikintisi seyir tepesinden Midilli ve Ege adaları gün batımı manzarası.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 4.9 },
        new() { City = "Balıkesir", Name = "Kazdağları Milli Parkı & Hasanboğuldu Göleti", Category = "Gezilecek", Description = "Dünyanın en yüksek oksijen oranına sahip şelaleler ve kanyon doğa yürüyüşü.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 11 BİLECİK
        // ==========================================
        new() { City = "Bilecik", Name = "Şeyh Edebali Türbesi & Osmanlı Yerleşkesi", Category = "Gezilecek", Description = "Osman Gazi'nin kayınpederi ve devletin manevi kurucusunun tarihi türbesi.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.8 },
        new() { City = "Bilecik", Name = "Söğüt Ertuğrul Gazi Türbesi & Kuyulu Cami", Category = "Gezilecek", Description = "Osmanlı Devleti'nin temellerinin atıldığı tarihi türbe ve alp nöbet değişimi.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 12 BİNGÖL
        // ==========================================
        new() { City = "Bingöl", Name = "Solhan Yüzen Adalar Tabiat Anıtı", Category = "Gezilecek", Description = "Krater gölü üzerinde rüzgarla ve hareketle bağımsız yüzen sazlık adacıklar.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Bingöl", Name = "Hesarek Kayak Merkezi & Çir Şelalesi", Category = "Gezilecek", Description = "Kış sporları tesisleri ve 50 metre yükseklikten dökülen doğal çağlayan.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.7 },

        // ==========================================
        // 13 BİTLİS
        // ==========================================
        new() { City = "Bitlis", Name = "Nemrut Krater Gölü & Kalderası - Tatvan", Category = "Gezilecek", Description = "Dünyanın en büyük 2. krater gölü, buhar bacaları, ılıcalar ve kamp alanı.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Bitlis", Name = "Ahlat Selçuklu Meydan Mezarlığı & Kümbetler", Category = "Müzeler", Description = "UNESCO Geçici Liste, dünyanın en büyük Türk-İslam açık hava anıt mezarlığı.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 14 BOLU
        // ==========================================
        new() { City = "Bolu", Name = "Yedigöller Milli Parkı", Category = "Gezilecek", Description = "Heyelanla oluşan Büyükgöl, Seringöl, Nazlıgöl gibi 7 kartpostallık göl ve orman.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Bolu", Name = "Abant & Gölcük Tabiat Parkları", Category = "Gezilecek", Description = "Göl kenarı ahşap konuk evi, nilüfer çiçekleri ve dört mevsim doğa manzarası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Bolu", Name = "Göynük & Mudurnu Tarihi Konakları", Category = "Gezilecek", Description = "Cittaslow sakin şehir Zafer Kulesi, Akşemseddin Türbesi ve ahşap konaklar.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 15 BURDUR
        // ==========================================
        new() { City = "Burdur", Name = "Salda Gölü Tabiat Parkı - Yeşilova", Category = "Gezilecek", Description = "Türkiye'nin Maldivleri olarak bilinen beyaz magnezyum kumsalları ve turkuaz sular.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 5.0 },
        new() { City = "Burdur", Name = "Sagalassos Antik Kenti & Antoninler Çeşmesi - Ağlasun", Category = "Müzeler", Description = "Torosların zirvesinde bin yıldır suyu akan anıtsal çeşme, tiyatro ve agora.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 5.0 },
        new() { City = "Burdur", Name = "Kibyra Antik Kenti (Gladyatörler Kenti) - Gölhisar", Category = "Müzeler", Description = "Dünyada eşi olmayan Medusa mozaikli orkestrası ve 10.000 kişilik antik stadyumu.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 16 BURSA
        // ==========================================
        new() { City = "Bursa", Name = "Ulu Cami, Kozahan & Tarihi Kapalıçarşı", Category = "Gezilecek", Description = "20 kubbeli erken Osmanlı başyapıtı ve tarihi ipek kervansarayı avlusu.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 5.0 },
        new() { City = "Bursa", Name = "Cumalıkızık UNESCO Köyü & Gölyazı", Category = "Gezilecek", Description = "700 yıllık taş sokaklı Osmanlı vakıf köyü ve Apolyont Gölü üzerindeki ada yarımadası.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.9 },
        new() { City = "Bursa", Name = "Uludağ Milli Parkı & Teleferik Hattı", Category = "Gezilecek", Description = "Türkiye'nin ilk kış sporları merkezi ve 9 km'lik panoramik teleferik yolculuğu.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 17 ÇANAKKALE
        // ==========================================
        new() { City = "Çanakkale", Name = "Gelibolu Şehitlikleri & Şehitler Abidesi", Category = "Müzeler", Description = "Çanakkale Savaşları'nın kahramanlık anıtları, 57. Alay ve Conkbayırı siperleri.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 5.0 },
        new() { City = "Çanakkale", Name = "Troya Antik Kenti ve Troya Müzesi", Category = "Müzeler", Description = "UNESCO Dünya Mirası, Homeros destanı tahta atı ve Avrupa ödüllü müze.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Çanakkale", Name = "Assos Antik Kenti & Athena Tapınağı - Behramkale", Category = "Gezilecek", Description = "Ege Denizi ve Midilli Adası manzaralı sarp dor tapınağı ve antik liman.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 18 ÇANKIRI
        // ==========================================
        new() { City = "Çankırı", Name = "Tarihi Kaya Tuzu Mağarası", Category = "Gezilecek", Description = "Yer altında 150 metre derinlikte Hititlerden kalma 5000 yıllık devasa tuz galerileri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Çankırı", Name = "Ilgaz Dağı Milli Parkı & Yıldıztepe", Category = "Gezilecek", Description = "Çam ormanları içinde kış kayak merkezi ve yaz doğa yürüyüşü rotaları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 19 ÇORUM
        // ==========================================
        new() { City = "Çorum", Name = "Hattuşa Ören Yeri & Yazılıkaya - Boğazkale", Category = "Müzeler", Description = "UNESCO Dünya Mirası, Hitit İmparatorluğu Başkenti, Aslanlı Kapı ve açık hava mabedi.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 5.0 },
        new() { City = "Çorum", Name = "Alacahöyük Kral Mezarları & İncesu Kanyonu", Category = "Müzeler", Description = "Sfenksli kapı, altın süs eşyaları ve Kybele kabartmalı kanyon yürüyüş yolu.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 20 DENİZLİ
        // ==========================================
        new() { City = "Denizli", Name = "Pamukkale Travertenleri & Hierapolis Antik Kenti", Category = "Gezilecek", Description = "UNESCO Dünya Mirası beyaz kalsiyum terasları ve Kleopatra Antik Termal Havuzu.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 5.0 },
        new() { City = "Denizli", Name = "Laodikeia Antik Kenti & Işıklı Gölü (Çivril)", Category = "Müzeler", Description = "İncil'deki 7 kiliseden biri ve yüzlerce nilüfer çiçeğiyle kaplı gölde tekne turu.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 21 DİYARBAKIR
        // ==========================================
        new() { City = "Diyarbakır", Name = "Diyarbakır Surları & Hevsel Bahçeleri", Category = "Gezilecek", Description = "UNESCO Dünya Mirası, Çin Seddi'nden sonra dünyanın en uzun kalkan surları ve Dicle vadisi.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 5.0 },
        new() { City = "Diyarbakır", Name = "Tarihi Ulu Cami & Hasan Paşa Hanı", Category = "Gezilecek", Description = "İslam aleminin 5. Harem-i Şerif'i kabul edilen avlulu mabet ve kahvaltı hanı.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },
        new() { City = "Diyarbakır", Name = "On Gözlü Köprü & Malabadi Köprüsü (Silvan)", Category = "Gezilecek", Description = "Dicle üzerindeki tarihi taş köprü ve Artuklu dönemi dünyanın en geniş kemerli köprüsü.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 22 EDİRNE
        // ==========================================
        new() { City = "Edirne", Name = "Selimiye Camii ve Külliyesi", Category = "Gezilecek", Description = "UNESCO Dünya Mirası, Mimar Sinan'ın Ustalık Eseri kabul edilen kubbe şaheseri.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 5.0 },
        new() { City = "Edirne", Name = "II. Bayezid Külliyesi Sağlık Müzesi (Darüşşifa)", Category = "Müzeler", Description = "Müzik, su sesi ve kokularla psikolojik tedavi yapılan tarihi Osmanlı şifahanesi.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.9 },
        new() { City = "Edirne", Name = "Meriç ve Tunca Köprüleri & Karaağaç Tren Garı", Category = "Gezilecek", Description = "Tarihi taş kemer köprüler, Lozan Anıtı ve nehir kenarı çay bahçeleri.", ImageUrl = "https://images.unsplash.com/photo-1544620347-c4fd4a3d5957?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 23 ELAZIĞ
        // ==========================================
        new() { City = "Elazığ", Name = "Tarihi Harput Kalesi & Eğik Minareli Ulu Cami", Category = "Gezilecek", Description = "Pisa Kulesi'nden daha eğik minaresi, Meryem Ana Kilisesi ve tarihi kervansaray.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Elazığ", Name = "Hazar Gölü & Batık Şehir - Sivrice", Category = "Gezilecek", Description = "Su altındaki tarihi yerleşimiyle tektonik göl ve su sporları merkezi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Elazığ", Name = "Keban Barajı & Çırçır Şelalesi", Category = "Gezilecek", Description = "Türkiye'nin dev baraj gölü manzarası ve alabalık tesisleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.7 },

        // ==========================================
        // 24 ERZİNCAN
        // ==========================================
        new() { City = "Erzincan", Name = "Kemaliye Karanlık Kanyon & Taş Yolu", Category = "Gezilecek", Description = "Dünyanın en sarp kanyonlarından biri, Fırat üzerinde tekne turları ve el oyması tüneller.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Erzincan", Name = "Girlevik Şelalesi Tabiat Anıtı", Category = "Gezilecek", Description = "Kışın dev buz sarkıtlarına dönüşen, yazın gürül gürül akan 3 katlı çağlayan.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Erzincan", Name = "Ergan Dağı Kış Sporları Merkezi", Category = "Gezilecek", Description = "Göl manzaralı Türkiye'nin en uzun telesiyej hatlarına sahip kayak merkezi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 25 ERZURUM
        // ==========================================
        new() { City = "Erzurum", Name = "Çifte Minareli Medrese & Erzurum Kalesi", Category = "Müzeler", Description = "Selçuklu taş süsleme sanatının başyapıtı ve Saat Kulesi panoramik şehir manzarası.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Erzurum", Name = "Palandöken Ejder 3200 Kayak Merkezi", Category = "Gezilecek", Description = "Dünyaca ünlü kristal toz kar kalitesi, gece aydınlatmalı pistler ve kış turizmi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Erzurum", Name = "Tortum Şelalesi & Tortum Gölü - Uzundere", Category = "Gezilecek", Description = "48 metre yükseklikten dökülen Türkiye'nin en görkemli çağlayanlarından biri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 26 ESKİŞEHİR
        // ==========================================
        new() { City = "Eskişehir", Name = "Tarihi Odunpazarı Evleri & OMM Müzesi", Category = "Gezilecek", Description = "Restore edilmiş renkli ahşap Osmanlı konakları, Çağdaş Sanat Müzesi ve Balmumu Müzesi.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.9 },
        new() { City = "Eskişehir", Name = "Porsuk Çayı Gondol Turları & Adalar", Category = "Gezilecek", Description = "Venedik usulü gondol ve bot turları, kafe ve yürüyüş bulvarı.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },
        new() { City = "Eskişehir", Name = "Sazova Bilim Kültür ve Sanat Parkı", Category = "Gezilecek", Description = "Masal Şatosu, Korsan Gemisi, Uzay Evi ve Hayvanat Bahçesi kompleksi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 27 GAZİANTEP
        // ==========================================
        new() { City = "Gaziantep", Name = "Zeugma Mozaik Müzesi", Category = "Müzeler", Description = "Çingene Kızı mozaiğiyle dünyaca ünlü, dünyanın en büyük mozaik koleksiyonu.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 5.0 },
        new() { City = "Gaziantep", Name = "Bakırcılar Çarşısı, Kale & Tahmis Kahvesi", Category = "Gezilecek", Description = "Yaşayan el sanatları ustaları, 400 yıllık menengiç kahvesi ve tarihi hanlar.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.9 },
        new() { City = "Gaziantep", Name = "Rumkale & Fırat Nehri Tekne Turu - Yavuzeli", Category = "Gezilecek", Description = "Fırat'ın zümrüt suları üzerindeki sarp kayalık Orta Çağ kalesi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 28 GİRESUN
        // ==========================================
        new() { City = "Giresun", Name = "Kuzalan Şelalesi & Mavi Göl - Dereli", Category = "Gezilecek", Description = "Sodalı kireç taşlarının oluşturduğu turkuaz doğal traverten göletleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Giresun", Name = "Giresun Kalesi & Giresun Adası", Category = "Gezilecek", Description = "Karadeniz'in iki yaşanabilir adasından biri ve panoramik deniz manzaralı kale.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.8 },
        new() { City = "Giresun", Name = "Kümbet & Bektaş Yaylaları", Category = "Gezilecek", Description = "Çam ormanları içindeki yayla şenlik alanları ve ahşap yayla evleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 29 GÜMÜŞHANE
        // ==========================================
        new() { City = "Gümüşhane", Name = "Karaca Mağarası - Torul", Category = "Gezilecek", Description = "Damlataş sarkıtları, dikitleri ve mağara gülleriyle dünyanın sayılı mağaralarından biri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Gümüşhane", Name = "Torul Kalesi Cam Seyir Terası", Category = "Gezilecek", Description = "240 metre yükseklikte vadi uçurumu üzerine kurulu heyecan verici cam teras.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Gümüşhane", Name = "Limni Gölü & Tomara Şelalesi", Category = "Gezilecek", Description = "Sarıçam ormanları arasındaki krater gölü ve kayadan fışkıran 40 gözlü çağlayan.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 30 HAKKARİ
        // ==========================================
        new() { City = "Hakkari", Name = "Cilo Buzulları & Cennet-Cehennem Vadisi", Category = "Gezilecek", Description = "Türkiye'nin en yüksek 2. zirvesi Reşko Dağı eteklerindeki 20 bin yıllık devasa buzul kanyonu.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Hakkari", Name = "Zap Vadisi & Merga Bütan Kayak Merkezi", Category = "Gezilecek", Description = "Sarp vadi manzaraları ve 2800 m rakımda uzun kış sezonlu modern kayak tesisi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 31 HATAY
        // ==========================================
        new() { City = "Hatay", Name = "Hatay Arkeoloji Müzesi", Category = "Müzeler", Description = "Dünyanın en zengin mozaik koleksiyonuna sahip anıtsal müze kompleksi.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 5.0 },
        new() { City = "Hatay", Name = "St. Pierre Kilisesi (İlk Mağara Kilisesi)", Category = "Müzeler", Description = "Hristiyanlık kelimesinin tarihte ilk kez kullanıldığı mağara kilise ve hac merkezi.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },
        new() { City = "Hatay", Name = "Titus Tüneli & Beşikli Mağara - Samandağ", Category = "Gezilecek", Description = "Roma İmparatoru Vespasianus'un dağları delerek yaptırdığı 1380 m insan yapımı su tüneli.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Hatay", Name = "Vakıflı Köyü & Harbiye Şelaleleri", Category = "Gezilecek", Description = "Türkiye'nin tek Ermeni köyü organik tarım bahçeleri ve defne ağaçlı çağlayanlar.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 32 ISPARTA
        // ==========================================
        new() { City = "Isparta", Name = "Kuyucak Lavanta Köyü - Keçiborlu", Category = "Gezilecek", Description = "Türkiye'nin lavanta üretim merkezi, mor çiçek tarlaları ve fotoğraf platosu.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 4.9 },
        new() { City = "Isparta", Name = "Eğirdir Gölü & Yeşilada", Category = "Gezilecek", Description = "Turkuaz tatlı su gölü, Dündar Bey Medresesi ve ada balıkçı köyleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Isparta", Name = "Yazılı Kanyon Tabiat Parkı - Sütçüler", Category = "Gezilecek", Description = "Filozof Epiktetos'un Hür İnsan Üzerine Şiiri'nin kayalara kazındığı kanyon nehri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 33 MERSİN
        // ==========================================
        new() { City = "Mersin", Name = "Kızkalesi (Deniz Kalesi) - Erdemli", Category = "Gezilecek", Description = "Kıyıdan 600 metre açıkta ada üzerine kurulu efsanevi Orta Çağ kalesi.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },
        new() { City = "Mersin", Name = "Cennet - Cehennem Obrukları & Narlıkuyu", Category = "Gezilecek", Description = "452 basamakla inilen Meryem Ana Kiliseli karstik çöküntü obruğu.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Mersin", Name = "Tarihi Tarsus Evleri, St. Paul Kuyusu & Şelalesi", Category = "Gezilecek", Description = "Nusret Mayın Gemisi, Eshab-ı Kehf Mağarası ve Kleopatra Kapısı.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },
        new() { City = "Mersin", Name = "Mamure Kalesi & Gilindire Mağarası - Anamur", Category = "Gezilecek", Description = "Akdeniz kıyısındaki en görkemli kale ve buzul çağından kalma ayna gölü mağarası.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 34 İSTANBUL
        // ==========================================
        new() { City = "İstanbul", Name = "Ayasofya-i Kebir Camii & Sultanahmet", Category = "Gezilecek", Description = "Dünya mimarlık tarihinin şaheseri ve 1500 yıllık mozaikli mabed.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 5.0 },
        new() { City = "İstanbul", Name = "Topkapı Sarayı & Yerebatan Sarnıcı", Category = "Müzeler", Description = "Osmanlı padişahlarının 400 yıllık sarayı ve Medusa başlı yeraltı sarnıcı.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 5.0 },
        new() { City = "İstanbul", Name = "Galata Kulesi & İstiklal Caddesi", Category = "Gezilecek", Description = "Panoramik Haliç ve Boğaz manzaralı Ceneviz kulesi ve tarihi tramvay hattı.", ImageUrl = "https://images.unsplash.com/photo-1527838832700-5059252407fa?q=80&w=800", Rating = 4.9 },
        new() { City = "İstanbul", Name = "Dolmabahçe Sarayı & Boğaz Vapur Hattı", Category = "Müzeler", Description = "Boğaz kıyısındaki Barok Osmanlı sarayı ve Adalar vapur seferleri.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 35 İZMİR
        // ==========================================
        new() { City = "İzmir", Name = "Efes Antik Kenti & Celsus Kütüphanesi - Selçuk", Category = "Müzeler", Description = "UNESCO Dünya Mirası, 25.000 kişilik antik tiyatro ve Meryem Ana Evi.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 5.0 },
        new() { City = "İzmir", Name = "Şirince Taş Köyü & Nesin Matematik Köyü", Category = "Gezilecek", Description = "Tarihi Rum mimarisi taş evler, meyve şarapları ve şeftali bahçeleri.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.9 },
        new() { City = "İzmir", Name = "Çeşme Alaçatı Taş Sokakları & Yel Değirmenleri", Category = "Gezilecek", Description = "Rüzgar sörfü koyları, begonvilli butik oteller ve tarihi taş değirmenler.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 4.9 },
        new() { City = "İzmir", Name = "Tarihi Kemeraltı, Saat Kulesi & Tarihi Asansör", Category = "Gezilecek", Description = "Kızlarağası Hanı, Konak Meydanı ve İzmir Körfezi gün batımı seyir balkonu.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 36 KARS
        // ==========================================
        new() { City = "Kars", Name = "Ani Ören Yeri (1001 Kiliseli Şehir)", Category = "Müzeler", Description = "UNESCO Dünya Mirası, İpek Yolu üzerindeki görkemli Orta Çağ katedrali ve surları.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 5.0 },
        new() { City = "Kars", Name = "Çıldır Gölü & Kışın Atlı Kızak Turları", Category = "Gezilecek", Description = "Buz tutan 123 km²'lik göl üzerinde atlı kızakla gezinti ve Eskimo balıkçılığı.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Kars", Name = "Sarıkamış Kayak Merkezi & Kars Kalesi", Category = "Gezilecek", Description = "Kristal toz kar pistleri, sarıçam ormanları ve Baltık mimarisi taş konaklar.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 37 KASTAMONU
        // ==========================================
        new() { City = "Kastamonu", Name = "Horma & Valla Kanyonu - Pınarbaşı", Category = "Gezilecek", Description = "3 km asma ahşap kanyon yürüyüş yolu, Ilıca Şelalesi ve 1200 m derinliğinde kanyon.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Kastamonu", Name = "Nasrullah Camii, Kale & Saat Kulesi", Category = "Gezilecek", Description = "Milli Mücadele'nin İstiklal Yolu merkezi ve ahşap konaklar şehri.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 38 KAYSERİ
        // ==========================================
        new() { City = "Kayseri", Name = "Erciyes Dağı Kayak Merkezi", Category = "Gezilecek", Description = "3917 m volkanik zirve eteklerinde uluslararası standartlarda kış sporları kompleksi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Kayseri", Name = "Kapuzbaşı Şelaleleri - Yahyalı", Category = "Gezilecek", Description = "Kayalıklardan fışkıran 7 adet dev çağlayan ve Aladağlar vadisi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Kayseri", Name = "Soğanlı Vadisi & Ağırnas Mimar Sinan Evi", Category = "Gezilecek", Description = "Kaya kiliseleri, peribacaları sıcak hava balon turları ve yeraltı şehirleri.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 39 KIRKLARELİ
        // ==========================================
        new() { City = "Kırklareli", Name = "İğneada Longoz Ormanları Milli Parkı", Category = "Gezilecek", Description = "Avrupa'nın en büyük subasar ormanı, kano parkurları ve Mert Gölü sahili.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Kırklareli", Name = "Dupnisa Mağarası & Kıyıköy Beldesi", Category = "Gezilecek", Description = "Trakya'nın tek turizme açık mağarası ve Aya Nikola Kaya Manastırı.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 40 KIRŞEHİR
        // ==========================================
        new() { City = "Kırşehir", Name = "Cacabey Gökbilim Medresesi & Rasathanesi", Category = "Müzeler", Description = "1272 Selçuklu dönemi gökbilim medresesi, rasat kuyusu ve güneş sistemi sütunları.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Kırşehir", Name = "Kaman Japon Bahçesi & Kalehöyük Müzesi", Category = "Gezilecek", Description = "Japonya dışındaki en büyük botanik Japon bahçesi ve arkeoloji merkezi.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.8 },
        new() { City = "Kırşehir", Name = "Ahi Evran Külliyesi & Neşet Ertaş Gönül Dağı Evi", Category = "Müzeler", Description = "Ahilik teşkilatının kurucusu Ahi Evran türbesi ve Bozkırın Tezenesi müzesi.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 41 KOCAELİ
        // ==========================================
        new() { City = "Kocaeli", Name = "Kartepe Kayak Merkezi & Maşukiye Şelaleleri", Category = "Gezilecek", Description = "Samanlı Dağları zirvesi kayak pistleri ve dere kenarı doğa restoranları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Kocaeli", Name = "Kerpe Kartal Kayalıkları & Kefken", Category = "Gezilecek", Description = "Karadeniz falez dalış kayalıkları ve Pembe Kayalıklar doğa harikası.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.8 },
        new() { City = "Kocaeli", Name = "Ballıkayalar Tabiat Parkı ve Kanyonu", Category = "Gezilecek", Description = "Kaya tırmanışı, kanyon göletleri ve trekking yürüyüş parkurları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.7 },

        // ==========================================
        // 42 KONYA
        // ==========================================
        new() { City = "Konya", Name = "Mevlânâ Müzesi & Kubbe-i Hadra", Category = "Müzeler", Description = "Evrensel hoşgörü felsefesinin merkezi, Hz. Mevlana Türbesi ve derviş hücreleri.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 5.0 },
        new() { City = "Konya", Name = "Çatalhöyük Neolitik Kenti - Çumra", Category = "Müzeler", Description = "UNESCO Dünya Mirası, 9000 yıllık insanlık tarihinin ilk toplu yerleşimi ve duvar resimleri.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Konya", Name = "Beyşehir Eşrefoğlu Camii & Sille Köyü", Category = "Gezilecek", Description = "UNESCO tescilli ahşap direkli cami ve Aya Elena kaya kiliseli tarihi Rum köyü.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },
        new() { City = "Konya", Name = "Konya Tropikal Kelebek Bahçesi", Category = "Gezilecek", Description = "Avrupa'nın en büyük kelebek uçuş alanı ve binlerce tropik bitki serası.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 43 KÜTAHYA
        // ==========================================
        new() { City = "Kütahya", Name = "Aizanoi Antik Kenti (Zeus Tapınağı) - Çavdarhisar", Category = "Müzeler", Description = "Dünyanın en iyi korunmuş Zeus Tapınağı ve tarihin ilk borsa yapısı.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Kütahya", Name = "Tarihi Germiyan Sokağı & Çini Müzesi", Category = "Gezilecek", Description = "Geleneksel ahşap konaklar ve UNESCO tescilli Kütahya çini sanatı galerisi.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 44 MALATYA
        // ==========================================
        new() { City = "Malatya", Name = "Arslantepe Höyüğü - Battalgazi", Category = "Müzeler", Description = "UNESCO Dünya Mirası, tarihin bilinen ilk kerpiç sarayı ve ilk metal kılıçları.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 5.0 },
        new() { City = "Malatya", Name = "Somuncu Baba Külliyesi & Tohma Kanyonu - Darende", Category = "Gezilecek", Description = "Kudret havuzu, kanyon yürüyüş parkuru ve Günpınar Şelalesi doğa rotası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Malatya", Name = "Levent Vadisi & Cam Teras - Akçadağ", Category = "Gezilecek", Description = "65 milyon yıllık kanyon vadisi ve 240 m uçurum üzerindeki cam seyir terası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 45 MANİSA
        // ==========================================
        new() { City = "Manisa", Name = "Sardes Antik Kenti & Artemis Tapınağı - Salihli", Category = "Müzeler", Description = "Lidya Krallığı'nın başkenti, dünyada paranın ilk basıldığı yer ve anıt sinagog.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Manisa", Name = "Kula-Salihli UNESCO Jeoparkı & Peribacaları", Category = "Gezilecek", Description = "Volkanik lav konileri, Divlit Yanardağı yürüyüş yolu ve Kula taş konakları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Manisa", Name = "Spil Dağı Milli Parkı & Ağlayan Kaya (Niobe)", Category = "Gezilecek", Description = "Yılkı atları, zengin endemik florası ve Niobe efsanesinin doğal kayalığı.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 46 KAHRAMANMARAŞ
        // ==========================================
        new() { City = "Kahramanmaraş", Name = "Kahramanmaraş Kalesi & Kapalı Çarşı", Category = "Gezilecek", Description = "Tarihi Hitit temelli kale, Bakırcılar Çarşısı ve yaşayan el sanatları atölyeleri.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.8 },
        new() { City = "Kahramanmaraş", Name = "Yedi Güzel Adam Edebiyat Müzesi", Category = "Müzeler", Description = "Tarihi Gazipaşa Mektebi binasında Türk edebiyatına damga vuran şairlerin müzesi.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.9 },
        new() { City = "Kahramanmaraş", Name = "Döngel Mağaraları ve Şelalesi - Onikişubat", Category = "Gezilecek", Description = "Prehistorik çağ yerleşim mağaraları, gürül gürül akan çağlayan ve kanyon vadisi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Kahramanmaraş", Name = "Başkonuş Yaylası & Geyik Alanı", Category = "Gezilecek", Description = "Sedir, köknar ve ardıç ormanları içindeki serin yayla ve doğa yürüyüş rotaları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Kahramanmaraş", Name = "Eshab-ı Kehf Külliyesi - Afşin", Category = "Müzeler", Description = "Yedi Uyurlar efsanesinin geçtiği kutsal mağara ve Selçuklu-Osmanlı külliyesi.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 47 MARDİN
        // ==========================================
        new() { City = "Mardin", Name = "Deyrulzafaran Manastırı - Artuklu", Category = "Müzeler", Description = "M.S. 5. yy Süryani kadim manastırı, Güneş Tapınağı ve Mezopotamya manzarası.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 5.0 },
        new() { City = "Mardin", Name = "Kasımiye & Zinciriye Medreseleri", Category = "Müzeler", Description = "Taş işçiliği havuzlu avluları ve kubbesinden Mezopotamya ovası seyir noktası.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Mardin", Name = "Dara Antik Kenti & Dev Sarnıçlar - Nusaybin", Category = "Müzeler", Description = "Oğuz Köyü'nde Doğu Roma sınırı devasa yeraltı zindanları, su sarnıçları ve nekropol.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 5.0 },
        new() { City = "Mardin", Name = "Midyat Devlet Konukevi (Sıla Konağı) & Telkâri", Category = "Gezilecek", Description = "Taş oymacılığının zirvesi 3 katlı konak ve tarihi gümüşçüler çarşısı.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.9 },
        new() { City = "Mardin", Name = "Mor Gabriel Manastırı - Midyat", Category = "Müzeler", Description = "Dünyanın ayakta kalan en eski Süryani Ortodoks manastırlarından biri (M.S. 397).", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 5.0 },

        // ==========================================
        // 48 MUĞLA
        // ==========================================
        new() { City = "Muğla", Name = "Ölüdeniz Tabiat Parkı & Belcekız Plajı", Category = "Gezilecek", Description = "Dünyanın en güzel lagünü seçilen dalgasız turkuaz sular ve beyaz kumsal.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 5.0 },
        new() { City = "Muğla", Name = "Kelebekler Vadisi ve Kabak Koyu - Faralya", Category = "Gezilecek", Description = "350 m sarp kayalıklarla çevrili endemik kaplan kelebekleri koyu ve kamp alanı.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Muğla", Name = "Saklıkent Kanyonu - Seydikemer", Category = "Gezilecek", Description = "18 km uzunluğunda, buz gibi kaynak suları içinden geçilen devasa kanyon.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Muğla", Name = "Bodrum Kalesi ve Sualtı Arkeoloji Müzesi", Category = "Müzeler", Description = "St. Jean Şövalyeleri kalesi ve dünyanın en zengin batık amfora koleksiyonu.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },
        new() { City = "Muğla", Name = "Dalyan İztuzu Plajı & Kaunos Kral Mezarları", Category = "Gezilecek", Description = "Caretta Caretta kaplumbağaları kumsalı ve nehir kenarındaki kaya mezarları.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 5.0 },
        new() { City = "Muğla", Name = "Akyaka Azmak Çayı Tekne Turu", Category = "Gezilecek", Description = "Cittaslow Akyaka buz gibi berrak nehir tekne turları ve sazlık florası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 49 MUŞ
        // ==========================================
        new() { City = "Muş", Name = "Tarihi Murat Köprüsü", Category = "Gezilecek", Description = "Murat Nehri üzerinde Selçuklu döneminden kalan 12 gözlü tarihi taş köprü.", ImageUrl = "https://images.unsplash.com/photo-1544620347-c4fd4a3d5957?q=80&w=800", Rating = 4.8 },
        new() { City = "Muş", Name = "Malazgirt Meydan Muharebesi Tarihi Milli Parkı", Category = "Müzeler", Description = "1071 Anadolu'nun kapılarını açan zafer anıtı, tarihi kale ve şehitlik.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Muş", Name = "Hamurpet (Akdoğan) Volkanik Gölleri - Varto", Category = "Gezilecek", Description = "2149 m rakımda krater gölü manzarası ve zengin yaban hayatı alanı.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.7 },

        // ==========================================
        // 50 NEVŞEHİR (KAPADOKYA)
        // ==========================================
        new() { City = "Nevşehir", Name = "Göreme Açık Hava Müzesi & Karanlık Kilise", Category = "Müzeler", Description = "UNESCO Dünya Mirası, M.S. 4. yy kaya oyma manastırları ve freskler.", ImageUrl = "https://images.unsplash.com/photo-1608755728617-aefab37d2edd?q=80&w=800", Rating = 5.0 },
        new() { City = "Nevşehir", Name = "Uçhisar Kalesi & Güvercinlik Vadisi", Category = "Gezilecek", Description = "Kapadokya'nın en yüksek noktası volkanik kaya kalesi ve balon izleme tepesi.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 5.0 },
        new() { City = "Nevşehir", Name = "Derinkuyu & Kaymaklı Yeraltı Şehirleri", Category = "Müzeler", Description = "8 kat yer altına inen havalandırma bacalı, kiliseli ve ahırlı sığınak şehirleri.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 5.0 },
        new() { City = "Nevşehir", Name = "Paşabağları & Zelve Açık Hava Müzesi", Category = "Gezilecek", Description = "Üç başlı dev peribacaları ve Aziz Simeon hücresinin bulunduğu açık hava vadisi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 51 NİĞDE
        // ==========================================
        new() { City = "Niğde", Name = "Gümüşler Manastırı ve Yeraltı Şehri", Category = "Müzeler", Description = "Dünyada tek olan Gülümseyen Meryem Ana freski ve tüf kayaya oyulu manastır.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.9 },
        new() { City = "Niğde", Name = "Aladağlar Milli Parkı & Demirkazık Zirvesi", Category = "Gezilecek", Description = "Türkiye'nin dağcılık ve kaya tırmanış merkezi, Yedigöller Dağ Platosu.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Niğde", Name = "Tyana Antik Kenti & Roma Su Kemerleri - Bor", Category = "Müzeler", Description = "Kemerhisar'da Roma döneminden kalan anıtsal su kemerleri ve antik kalıntılar.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 52 ORDU
        // ==========================================
        new() { City = "Ordu", Name = "Boztepe Teleferik & Seyir Terası", Category = "Gezilecek", Description = "530 m rakımdan Karadeniz ve Ordu şehir manzarasını izleyen teleferik zirvesi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Ordu", Name = "Yason Burnu & Tarihi Yason Kilisesi - Perşembe", Category = "Gezilecek", Description = "Argonotlar Efsanesi'nin geçtiği deniz feneri ve tarihi yarımada kilisesi.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },
        new() { City = "Ordu", Name = "Perşembe Yaylası Menderesleri & Çiseli Şelalesi - Aybastı", Category = "Gezilecek", Description = "Dünyaca ünlü kıvrımlı nehir menderesleri ve yayla göletleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Ordu", Name = "Ulugöl Tabiat Parkı - Gölköy", Category = "Gezilecek", Description = "Krater krater orman içi krater gölü, sonbahar yaprak şöleni ve yürüyüş parkuru.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 53 RİZE
        // ==========================================
        new() { City = "Rize", Name = "Zil Kale ve Palovit Şelalesi - Çamlıhemşin", Category = "Gezilecek", Description = "Fırtına Vadisi'nde sarp uçurum üzerindeki kale ve debisi yüksek orman şelalesi.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 5.0 },
        new() { City = "Rize", Name = "Ayder Yaylası & Gelin Tülü Şelalesi", Category = "Gezilecek", Description = "Kaçkar Dağları eteklerinde kaplıcaları ve tüllere benzeyen şelalesiyle ünlü yayla.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Rize", Name = "Pokut & Sal Yaylaları (Bulut Denizi)", Category = "Gezilecek", Description = "2050 m rakımda bulutların üzerinde yükselen tarihi ahşap yayla evleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Rize", Name = "Haremtepe (Çeçeva) Çay Tarlaları - Çayeli", Category = "Gezilecek", Description = "Düzenli budanmış basamaklı yeşil çay terasları ve fotoğraf platosu.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 54 SAKARYA
        // ==========================================
        new() { City = "Sakarya", Name = "Sapanca Gölü Sahili & Kırkpınar", Category = "Gezilecek", Description = "Göl kenarı yürüyüş parkurları, doğa kafeleri ve dere içi restoranları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Sakarya", Name = "Acarlar Longozu Subasar Ormanı - Karasu", Category = "Gezilecek", Description = "Türkiye'nin tek parça en büyük subasar ormanı ve nilüfer göletleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Sakarya", Name = "Taraklı Tarihi Konakları & Yunus Paşa Camii", Category = "Gezilecek", Description = "Cittaslow sakin şehir tescilli 3 katlı ahşap Osmanlı konakları.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },
        new() { City = "Sakarya", Name = "Maden Deresi ve Şelalesi - Kocaali", Category = "Gezilecek", Description = "Tarihi maden tünelleri içinden geçilen kanyon ve orman yürüyüş parkuru.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.7 },

        // ==========================================
        // 55 SAMSUN
        // ==========================================
        new() { City = "Samsun", Name = "Bandırma Vapuru ve Milli Mücadele Müzesi", Category = "Müzeler", Description = "19 Mayıs 1919'da Atatürk ve silah arkadaşlarını Samsun'a getiren simge vapur.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 5.0 },
        new() { City = "Samsun", Name = "Şahinkaya Kanyonu Tabiat Parkı - Vezirköprü", Category = "Gezilecek", Description = "Kızılırmak üzerinde 2,5 km uzunluğunda, 400 m duvar yüksekliğinde tekne kanyonu.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Samsun", Name = "Kızılırmak Deltası Kuş Cenneti - Bafra", Category = "Gezilecek", Description = "UNESCO Dünya Mirası Geçici Listesi, 350'den fazla kuş türü ve yılkı atları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Samsun", Name = "Göğceli Camii (Çivisiz Cami) - Çarşamba", Category = "Müzeler", Description = "Hiç çivi kullanılmadan ahşap kütüklerin birbirine geçirilmesiyle yapılan 800 yıllık cami.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 56 SİİRT
        // ==========================================
        new() { City = "Siirt", Name = "Tillo Işık Hadisesi & İbrahim Hakkı Türbesi", Category = "Müzeler", Description = "Güneşin doğduğu an hocasının başucunu aydınlatan dahi astronomi düzeneği.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Siirt", Name = "Botan Kanyonu & Rasıl Hacar Cam Seyir Terası", Category = "Gezilecek", Description = "Botan Çayı'nın sarp kanyon vadisi ve 350 m uçurum cam terası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Siirt", Name = "Veysel Karani Türbesi - Baykan", Category = "Gezilecek", Description = "Ziyaret Beldesi'nde İslam tarihinin büyük velisinin anıt türbesi.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 57 SİNOP
        // ==========================================
        new() { City = "Sinop", Name = "Tarihi Sinop Kapalı Cezaevi Müzesi", Category = "Müzeler", Description = "Şiirlere ve romanlara konu olan deniz kenarındaki tarihi kale cezaevi.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 5.0 },
        new() { City = "Sinop", Name = "Hamsilos Koyu Tabiat Parkı & İnceburun", Category = "Gezilecek", Description = "Türkiye'nin tek fiyort benzeri koyu ve Türkiye'nin en kuzey uç deniz feneri.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },
        new() { City = "Sinop", Name = "Erfelek Tatlıca Şelaleleri (28 Şelale)", Category = "Gezilecek", Description = "Merdiven şeklinde ardı ardına sıralanan 28 basamaklı doğal şelaleler vadisi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 58 SİVAS
        // ==========================================
        new() { City = "Sivas", Name = "Divriği Ulu Cami ve Darüşşifası", Category = "Müzeler", Description = "UNESCO Dünya Mirası, taş işçiliğinin doruk noktası ve namaz kılan insan gölgesi silueti.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 5.0 },
        new() { City = "Sivas", Name = "Çifte Minareli Medrese & Buruciye Medresesi", Category = "Müzeler", Description = "Tarihi Hükümet Meydanı'ndaki Selçuklu çini ve taş süsleme şaheserleri.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },
        new() { City = "Sivas", Name = "Gökpınar Gölü Tabiat Parkı - Gürün", Category = "Gezilecek", Description = "Doğal akvaryum berraklığında dibi görünen turkuaz renkli kaynak gölü.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Sivas", Name = "Kangal Balıklı Kaplıcaları", Category = "Gezilecek", Description = "Dünyaca ünlü sedef hastalığı tedavisinde kullanılan şifalı doktor balıklar.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 59 TEKİRDAĞ
        // ==========================================
        new() { City = "Tekirdağ", Name = "Uçmakdere Yamaç Paraşütü & Asırlık Çınarlar - Şarköy", Category = "Gezilecek", Description = "Ganos Dağları'ndan Marmara Denizi'ne süzülen yamaç paraşütü merkezi.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },
        new() { City = "Tekirdağ", Name = "Namık Kemal Evi & Rakoczi Müzesi", Category = "Müzeler", Description = "Vatan Şairi'nin doğduğu konak ve Macar Prensi Ferenc Rakoczi'nin sürgün köşkü.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },
        new() { City = "Tekirdağ", Name = "Hora Feneri & Şarköy Bağ Rotaları", Category = "Gezilecek", Description = "1861 Fransız yapımı deniz feneri ve Türkiye'nin en uzun sahil kumsalları.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 4.7 },

        // ==========================================
        // 60 TOKAT
        // ==========================================
        new() { City = "Tokat", Name = "Ballıca Mağarası Tabiat Parkı - Pazar", Category = "Gezilecek", Description = "UNESCO Geçici Liste, dünyanın en nadir soğan sarkıtlarına sahip devasa mağara.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Tokat", Name = "Tarihi Tokat Kalesi & Zindanları", Category = "Gezilecek", Description = "Kont Drakula'nın hapsedildiği tarihi sarp kale ve Saat Kulesi.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.8 },
        new() { City = "Tokat", Name = "Sulu Sokak Yağıbasan Tıp Medresesi & Taşhan", Category = "Müzeler", Description = "Anadolu'nun ilk kapalı avlulu tıp medresesi ve geleneksel tahta baskı çarşısı.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.8 },
        new() { City = "Tokat", Name = "Niksar Kalesi & Zile Kalesi (Veni Vidi Vici)", Category = "Gezilecek", Description = "Türkiye'nin 2. büyük kalesi ve Jül Sezar'ın ünlü sözünü söylediği amfi tiyatro kalesi.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 61 TRABZON
        // ==========================================
        new() { City = "Trabzon", Name = "Sümela Manastırı & Altındere Vadisi - Maçka", Category = "Müzeler", Description = "UNESCO Dünya Mirası Geçici Listesi, Karadağ'ın sarp kayalıklarına oyulmuş 1600 yıllık mabet.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 5.0 },
        new() { City = "Trabzon", Name = "Uzungöl Tabiat Parkı & Karester Yaylası - Çaykara", Category = "Gezilecek", Description = "Dağlar arasında sisli heyelan set gölü ve zirveden panoramik göl manzarası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Trabzon", Name = "Trabzon Ayasofyası Müzesi - Ortahisar", Category = "Müzeler", Description = "13. yy Bizans kilisesi, freskleri ve bahçesindeki tarihi çan kulesi.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },
        new() { City = "Trabzon", Name = "Atatürk Köşkü & Soğuksu Koruluğu", Category = "Müzeler", Description = "Çam korusu içinde 19. yy Avrupa sivil mimarisi ve Atatürk'ün vasiyetini yazdığı köşk.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 62 TUNCELİ
        // ==========================================
        new() { City = "Tunceli", Name = "Munzur Gözeleri & Ziyaret Köyü - Ovacık", Category = "Gezilecek", Description = "Kayalardan fışkıran buz gibi kutsal kaynak suları ve çağlayanlar.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Tunceli", Name = "Munzur Vadisi Milli Parkı & Kutu Deresi", Category = "Gezilecek", Description = "Kanyon boyunca rafting parkurları, zengin yaban hayatı ve serin vadiler.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Tunceli", Name = "Pertek Kalesi - Baraj Adası", Category = "Gezilecek", Description = "Keban Baraj Gölü suları ortasında ada kale, feribot manzarası.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.8 },
        new() { City = "Tunceli", Name = "Çemişgezek Tarihi İn Delikleri (Derviş Hücreleri)", Category = "Gezilecek", Description = "Tahar Çayı sarp kayalıklarına oyulmuş 4 katlı antik mağara yerleşimi.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 63 ŞANLIURFA
        // ==========================================
        new() { City = "Şanlıurfa", Name = "Göbeklitepe & Karahantepe Ören Yeri", Category = "Müzeler", Description = "UNESCO Dünya Mirası, 12.000 yıllık T biçimli dikilitaşlar ve tarihin sıfır noktası.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 5.0 },
        new() { City = "Şanlıurfa", Name = "Balıklıgöl (Halil-ür Rahman) & Ayn Zeliha", Category = "Gezilecek", Description = "Hz. İbrahim'in ateşe atıldığı yer kabul edilen kutsal balıklı havuzlar ve Rızvaniye Camii.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 5.0 },
        new() { City = "Şanlıurfa", Name = "Eski Halfeti Batık Şehir & Rumkale Tekne Turu", Category = "Gezilecek", Description = "Birecik Barajı altında kalan batık minare, Fırat kanyonu ve sarp kale surları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Şanlıurfa", Name = "Harran Kümbet Evleri & İlk İslam Üniversitesi", Category = "Müzeler", Description = "Konik kubbeli kerpiç evler, bin yıllık rasathane kalıntıları ve Harran Kalesi.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 64 UŞAK
        // ==========================================
        new() { City = "Uşak", Name = "Ulubey Kanyonu ve Cam Seyir Terası", Category = "Gezilecek", Description = "Amerika'daki Grand Canyon'dan sonra dünyanın en uzun 2. kanyonu ve cam terası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Uşak", Name = "Blaundus Antik Kenti & Kaya Mezarları - Sülümenli", Category = "Müzeler", Description = "Kanyon yarımadası üzerindeki Büyük İskender komutanları şehri ve tapınaklar.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Uşak", Name = "Tarihi Clandıras Köprüsü & Su Kemeri - Karahallı", Category = "Gezilecek", Description = "2500 yıllık Frigya dönemi Pepouza antik su kemeri ve şelale.", ImageUrl = "https://images.unsplash.com/photo-1544620347-c4fd4a3d5957?q=80&w=800", Rating = 4.8 },
        new() { City = "Uşak", Name = "Uşak Arkeoloji Müzesi & Karun Hazineleri", Category = "Müzeler", Description = "Dünyaca ünlü Kanatlı Denizatı Broşu ve Lidya Karun Hazineleri sergisi.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 65 VAN
        // ==========================================
        new() { City = "Van", Name = "Akdamar Adası ve Kutsal Haç Kilisesi - Gevaş", Category = "Müzeler", Description = "Van Gölü üzerindeki badem ağaçlı ada, dış cephe İncil kabartmalı 10. yy taş kilisesi.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 5.0 },
        new() { City = "Van", Name = "Van Kalesi & Analıkız Urartu Açık Hava Tapınağı", Category = "Müzeler", Description = "Urartu Krallığı başkenti Tuşpa'nın görkemli kaya kalesi ve çivi yazılı kitabeleri.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Van", Name = "Muradiye Şelalesi ve Asma Köprü", Category = "Gezilecek", Description = "Bend-i Mahi Çayı üzerinde kışın buz tutan, yazın gürül gürül akan çağlayan.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Van", Name = "Van Kedisi Araştırma Merkezi (Kedi Villası)", Category = "Gezilecek", Description = "Farklı renkli gözleri ve ipeksi beyaz tüyleriyle meşhur koruma altındaki Van kedileri.", ImageUrl = "https://images.unsplash.com/photo-1514888286974-6c03e2ca1dba?q=80&w=800", Rating = 4.9 },

        // ==========================================
        // 66 YOZGAT
        // ==========================================
        new() { City = "Yozgat", Name = "Sarıkaya Tarihi Roma Hamamı (Basilica Therma)", Category = "Müzeler", Description = "UNESCO Geçici Liste, 2000 yıldır termal şifalı suyu kesilmeyen antik havuz.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Yozgat", Name = "Yozgat Çamlığı Milli Parkı (İlk Milli Park)", Category = "Gezilecek", Description = "Türkiye'nin 1958'de ilan edilen ilk milli parkı, Kafkas çamları ve göletler.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Yozgat", Name = "Kazankaya Kanyonu - Aydıncık", Category = "Gezilecek", Description = "10 km uzunluğunda kanyon yürüyüş rotası ve kayaya oyulmuş Kybele kabartması.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 67 ZONGULDAK
        // ==========================================
        new() { City = "Zonguldak", Name = "Zonguldak Maden Müzesi ve Eğitim Ocağı", Category = "Müzeler", Description = "Maden ocağına inilerek gezilen Türkiye'nin ilk maden müzesi ve kömür galerileri.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.9 },
        new() { City = "Zonguldak", Name = "Gökgöl Mağarası - Merkez", Category = "Gezilecek", Description = "875 metrelik yürüyüş parkuru, damlataş sarkıtları ve mikroklimal şifa havası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Zonguldak", Name = "Cehennem Ağzı Mağaraları - Karadeniz Ereğli", Category = "Gezilecek", Description = "Mitolojide Herakles'in Kerberos ile savaştığı yer kabul edilen tarihi ayazma mağaraları.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },
        new() { City = "Zonguldak", Name = "Filyos (Tios) Antik Kenti ve Kalesi - Çaycuma", Category = "Müzeler", Description = "Karadeniz'in Efes'i olarak bilinen antik liman, tapınaklar ve sahil kalesi.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 68 AKSARAY
        // ==========================================
        new() { City = "Aksaray", Name = "Ihlara Vadisi Kanyonu & Kaya Kiliseleri - Güzelyurt", Category = "Gezilecek", Description = "Melendiz Çayı boyunca 14 km uzanan kanyon, Ağaçaltı ve Yılanlı kaya kiliseleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Aksaray", Name = "Selime Katedrali & Manastırı", Category = "Müzeler", Description = "Kapadokya'nın en büyük kaya oyma manastır kompleksi ve Star Wars çekim platosu.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Aksaray", Name = "Sultanhanı Kervansarayı - Sultanhanı", Category = "Müzeler", Description = "İpek Yolu üzerindeki Anadolu'nun en büyük ve en görkemli Selçuklu kervansarayı.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Aksaray", Name = "Narlıgöl Krater Gölü & Aşıklı Höyük", Category = "Gezilecek", Description = "Kalp şeklinde volkanik maar gölü ve 10.000 yıllık neolitik tıp köyü.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 69 BAYBURT
        // ==========================================
        new() { City = "Bayburt", Name = "Baksı Müzesi - Bayraktar Köyü", Category = "Müzeler", Description = "Avrupa Konseyi Müze Ödüllü, çağdaş sanat ile geleneksel el sanatlarını buluşturan tepe müzesi.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 5.0 },
        new() { City = "Bayburt", Name = "Kenan Yavuz Etnografya Müzesi - Beşpınar Köyü", Category = "Müzeler", Description = "Avrupa Silletto Ödüllü köy yaşamı, değirmen ve silo kütüphanesi ekomüzesi.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Bayburt", Name = "Bayburt Kalesi (Çinimaçin Kalesi) & Çoruh Parkı", Category = "Gezilecek", Description = "Çoruh Nehri'ne hakim sarp tepe kalesi ve D915 Derebaşı Virajları rotası.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.8 },
        new() { City = "Bayburt", Name = "Aydıntepe Yeraltı Şehri", Category = "Müzeler", Description = "Tüf kayaya oyulmuş odalar, su kanalları ve havalandırma bacalı sığınak.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 70 KARAMAN
        // ==========================================
        new() { City = "Karaman", Name = "Taşkale Doğal Tahıl Ambarları", Category = "Gezilecek", Description = "250'den fazla kayaya oyulmuş doğal soğuk hava tahıl ambarı ve killi kaya duvarı.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.9 },
        new() { City = "Karaman", Name = "Manazan Mağaraları & İncesu Mağarası", Category = "Gezilecek", Description = "5 katlı kayaya oyulmuş devasa yerleşim platosu ve damlataş mağarası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },
        new() { City = "Karaman", Name = "Binbirkilise - Karadağ (Madenşehri Köyü)", Category = "Müzeler", Description = "Erken Hristiyanlık dönemi bazilikaları, manastırlar ve krater yılkı atları.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.8 },
        new() { City = "Karaman", Name = "Tarihi Ermenek Konakları, Maraspoli & Baraj Gölü", Category = "Gezilecek", Description = "Firan Kalesi, yeraltı şelaleli mağara ve kanyon tekne turları.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 71 KIRIKKALE
        // ==========================================
        new() { City = "Kırıkkale", Name = "Tarihi Çeşnigir Köprüsü ve Kanyonu", Category = "Gezilecek", Description = "Kızılırmak üzerinde Selçuklu köprüsü, cam seyir terası ve tekne turları.", ImageUrl = "https://images.unsplash.com/photo-1544620347-c4fd4a3d5957?q=80&w=800", Rating = 4.9 },
        new() { City = "Kırıkkale", Name = "MKE Silah Sanayi Müzesi", Category = "Müzeler", Description = "Türkiye'nin tek askeri çelik ve hafif silah sanayi müzesi koleksiyonu.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.8 },
        new() { City = "Kırıkkale", Name = "Keskin Hacı Taşan Kültür Merkezi (Taş Mektep)", Category = "Gezilecek", Description = "Bozlak ve Abdal geleneğinin merkezi, Rahmi Pehlivanlı Evi ve Sulu Mağara.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 72 BATMAN
        // ==========================================
        new() { City = "Batman", Name = "Hasankeyf Yeni Kültür Yarımadası & Arkeopark", Category = "Müzeler", Description = "Sular altından kurtarılan Zeynel Bey Türbesi, El-Rızk Camii ve Artuklu Hamamı.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Batman", Name = "Hasankeyf Kalesi & Dicle Tekne Turları", Category = "Gezilecek", Description = "Küçük Saray, Dicle Nehri su sporları ve yeni kanyon yürüyüş rotaları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Batman", Name = "Mor Kuryakos Manastırı - Gercüş (Ayrancı Köyü)", Category = "Müzeler", Description = "M.S. 4. yy Süryani manastırı ve Mereto Dağı trekking rotası.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 73 ŞIRNAK
        // ==========================================
        new() { City = "Şırnak", Name = "El-Cezeri Müzesi ve Türbesi - Cizre", Category = "Müzeler", Description = "Sibernetik ve robotik biliminin kurucusu İsmail El-Cezeri'nin doğduğu merkez.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.9 },
        new() { City = "Şırnak", Name = "Kırmızı Medrese & Mem û Zîn Türbesi - Cizre", Category = "Müzeler", Description = "Melaye Ciziri'nin ders verdiği 14. yy medresesi ve efsanevi aşıkların türbesi.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.9 },
        new() { City = "Şırnak", Name = "Hz. Nuh (A.S.) Türbesi & Cudi Dağı Sefine", Category = "Gezilecek", Description = "Nuh Tufanı gemisinin oturduğu inanılan Cudi Dağı ve Hz. Nuh Camii.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.8 },
        new() { City = "Şırnak", Name = "Kasrik Boğazı Tabiat Anıtı", Category = "Gezilecek", Description = "Kralların kabartma heykelleri, tarihi su kemerleri ve kanyon geçidi.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 74 BARTIN
        // ==========================================
        new() { City = "Bartın", Name = "Amasra Ceneviz Kalesi ve Kemere Köprüsü", Category = "Gezilecek", Description = "Fatih Sultan Mehmet'in Çeşm-i Cihan dediği sahil kalesi, Boztepe Adası ve Çekiciler Çarşısı.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 5.0 },
        new() { City = "Bartın", Name = "Güzelcehisar 80 Milyon Yıllık Lav Sütunları", Category = "Gezilecek", Description = "Dünyada nadir görülen volkanik sütunlar ve ahşap sahil yürüyüş platformu.", ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=800", Rating = 4.9 },
        new() { City = "Bartın", Name = "Küre Dağları Milli Parkı & Ulukaya Şelalesi - Ulus", Category = "Gezilecek", Description = "PAN Parks sertifikalı kanyon vadileri ve kayadan dökülen şelale.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 75 ARDAHAN
        // ==========================================
        new() { City = "Ardahan", Name = "Çıldır Gölü & Kışın Atlı Kızak Turları", Category = "Gezilecek", Description = "1 metre buz üstünde kızaklar, Eskimo usulü sarıbalık avı ve Akçakale Kütük Ev.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 5.0 },
        new() { City = "Ardahan", Name = "Şeytan Kalesi - Kocaköy (Çıldır)", Category = "Gezilecek", Description = "Karaçay Kanyonu'nun sarp uçurum kayalıkları üzerine kurulu görkemli kale.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },
        new() { City = "Ardahan", Name = "Ardahan Kalesi & Damal Doğal Atatürk Silueti", Category = "Gezilecek", Description = "Kura Nehri kıyısındaki kale ve her yaz dağ sırtlarına vuran doğal siluet.", ImageUrl = "https://images.unsplash.com/photo-1524231757912-21f4fe3a7200?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 76 IĞDIR
        // ==========================================
        new() { City = "Iğdır", Name = "Tuzluca Tuz Terapi Mağaraları", Category = "Gezilecek", Description = "Doğu Anadolu'nun yer altı devasa tuz galerileri ve nefes terapi salonları.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Iğdır", Name = "Karakoyunlu Tarihi Koç Başlı Mezar Taşları", Category = "Müzeler", Description = "Açık hava müzesinde sergilenen bin yıllık koç başlı taş anıtlar.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.7 },
        new() { City = "Iğdır", Name = "Ağrı Dağı Milli Parkı Kuzey Buzul Rotaları", Category = "Gezilecek", Description = "Mikroklima iklimi, İrem Bağları ve dağın kuzey tırmanış rotası.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 77 YALOVA
        // ==========================================
        new() { City = "Yalova", Name = "Yürüyen Köşk ve Sahil Parkı", Category = "Gezilecek", Description = "Atatürk'ün bir çınar dalını kesmemek için raylar üzerinde kaydırdığı tarihi köşk.", ImageUrl = "https://images.unsplash.com/photo-1541432901042-2d8bd64b4a9b?q=80&w=800", Rating = 4.9 },
        new() { City = "Yalova", Name = "Tarihi Termal Kaplıcaları & Atatürk Köşkü", Category = "Gezilecek", Description = "Roma ve Osmanlı'dan günümüze gelen şifalı sular ve yeşillikler içindeki tesisler.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Yalova", Name = "Karaca Arboretumu & Erikli Şelalesi - Çınarcık", Category = "Gezilecek", Description = "Türkiye'nin ilk özel canlı ağaç müzesi ve çifte şelaleler tabiat parkı.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 78 KARABÜK
        // ==========================================
        new() { City = "Karabük", Name = "Tarihi Safranbolu Çarşısı ve Konakları", Category = "Gezilecek", Description = "UNESCO Dünya Mirası, Cinci Hanı, Kaymakamlar Evi ve ahşap Osmanlı konakları.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 5.0 },
        new() { City = "Karabük", Name = "Kristal Cam Teras & Tokatlı Kanyonu", Category = "Gezilecek", Description = "Kanyon uçurumu üzerine kurulu cam seyir terası ve İncekaya Su Kemeri parkuru.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Karabük", Name = "Bulak (Mencilis) Mağarası & Yörük Köyü", Category = "Gezilecek", Description = "Türkiye'nin 4. büyük mağarası ve koruma altındaki tarihi Bektaşi köyü konakları.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },
        new() { City = "Karabük", Name = "Hadrianapolis Antik Kenti - Eskipazar", Category = "Müzeler", Description = "Karadeniz'in Zeugması olarak bilinen erken Bizans mozaikleri ve kiliseleri.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 79 KİLİS
        // ==========================================
        new() { City = "Kilis", Name = "Tarihi Kilis Konakları ve Kabaltılar", Category = "Gezilecek", Description = "Dar sokakları bağlayan kemerli taş tüneller ve Neşet Efendi Etnografya Konağı.", ImageUrl = "https://images.unsplash.com/photo-1578925518470-4def7a0f08bb?q=80&w=800", Rating = 4.8 },
        new() { City = "Kilis", Name = "Ravanda Kalesi - Polateli (Belenözü)", Category = "Gezilecek", Description = "Afrin Çayı vadisine hakim sarp kayalık tepe kalesi ve sarnıçları.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.8 },
        new() { City = "Kilis", Name = "Oylum Höyük ve Mozaikli Bazilika", Category = "Müzeler", Description = "Güneydoğu'nun en büyük höyüklerinden biri ve 6. yy mozaikli bazilikası.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.7 },

        // ==========================================
        // 80 OSMANİYE
        // ==========================================
        new() { City = "Osmaniye", Name = "Karatepe-Aslantaş Hitit Açık Hava Müzesi - Kadirli", Category = "Müzeler", Description = "UNESCO Geçici Liste, Geç Hitit kalesi ve çift dilli Fenike-Hitit yazıtları.", ImageUrl = "https://images.unsplash.com/photo-1566127444979-b3d2b654e3d7?q=80&w=800", Rating = 4.9 },
        new() { City = "Osmaniye", Name = "Kastabala Antik Kenti (Hierapolis) - Merkez", Category = "Müzeler", Description = "Sütunlu cadde, antik tiyatro ve kaya mezarları ören yeri.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 },
        new() { City = "Osmaniye", Name = "Toprakkale Kalesi & Zorkun Yaylası", Category = "Gezilecek", Description = "Kilikya ovasını denetleyen kale ve sedir ormanları içindeki serin yayla.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.8 },

        // ==========================================
        // 81 DÜZCE
        // ==========================================
        new() { City = "Düzce", Name = "Akçakoca Ceneviz Kalesi ve Plajı", Category = "Gezilecek", Description = "UNESCO Geçici Liste, Karadeniz kıyısında mavi bayraklı plaj ve tarihi ahşap evler.", ImageUrl = "https://images.unsplash.com/photo-1533089860892-a7c6f0a88666?q=80&w=800", Rating = 4.9 },
        new() { City = "Düzce", Name = "Samandere & Güzeldere Şelaleleri", Category = "Gezilecek", Description = "Dev kazanları, çavlanlar ve 130 metreden basamaklı dökülen doğa şelaleleri.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Düzce", Name = "Melen Çayı Rafting Parkuru - Cumayeri", Category = "Gezilecek", Description = "Dokuzdeğirmen Köyü'nde Türkiye'nin en popüler nehir rafting parkuru.", ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=800", Rating = 4.9 },
        new() { City = "Düzce", Name = "Konuralp (Prusias ad Hypium) Antik Tiyatrosu", Category = "Müzeler", Description = "Kırk Basamaklar Roma tiyatrosu, Konuralp Müzesi ve antik kemer köprü.", ImageUrl = "https://images.unsplash.com/photo-1583037189850-1921ae7c6c22?q=80&w=800", Rating = 4.8 }
    };

    public List<PlaceItem> GetPlaces(string city, string category)
    {
        var query = _places.AsQueryable();

        if (!string.IsNullOrWhiteSpace(city) && city != "Tüm Türkiye")
        {
            query = query.Where(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(category) && category != "Tümü")
        {
            query = query.Where(x => x.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        return query.ToList();
    }
}