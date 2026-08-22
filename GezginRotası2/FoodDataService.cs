namespace GezginRotası2;

public class FoodDataService
{
    private readonly List<FoodItem> _foods = new()
    {
        // 01 ADANA
        new() { City = "Adana", Name = "Zırh Kıyma Adana Kebap", Category = "Ana Yemek", Description = "Erkek kuzu eti ve kuyruk yağından zırhla çekilen, köz biber ve sumaklı soğanla servis edilen efsane.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Kebapçı Mesut / Eyvan / Bolat", Rating = 5.0 },
        // 02 ADIYAMAN
        new() { City = "Adıyaman", Name = "Etsiz Adıyaman Çiğ Köftesi & Gerger Tavası", Category = "Yöresel", Description = "Cevizli, isotlu el yoğurması çiğ köfte ve fırında pişen kuzu tavası.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Adıyaman Tarihi Çarşı Köftecileri", Rating = 4.9 },
        // 03 AFYONKARAHİSAR
        new() { City = "Afyonkarahisar", Name = "Kaymaklı Ekmek Kadayıfı & Afyon Sucuğu", Category = "Tatlı", Description = "Hakiki manda kaymağıyla sunulan kadayıf ve geleneksel baharatlı sucuk.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "İkbal / Aftat / Cumhuriyet", Rating = 5.0 },
        // 04 AĞRI
        new() { City = "Ağrı", Name = "Abdigör Köftesi", Category = "Ana Yemek", Description = "Taş üzerinde tokmakla macun kıvamına getirilen yağsız kuzu etinden yapılan asırlık saray yemeği.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Doğubayazıt İshak Paşa Sofrası", Rating = 4.9 },
        // 05 AMASYA
        new() { City = "Amasya", Name = "Amasya Çöreği & Baklalı Dolma", Category = "Hamur İşi", Description = "Cevizli ve haşhaşlı çıtır çörek ve taze Amasya misket elması.", ImageUrl = "https://images.unsplash.com/photo-1509722747041-616f39b57569?q=80&w=600", WhereToEat = "Yalıboyu Fırınları & Amasya Mutfağı", Rating = 4.8 },
        // 06 ANKARA
        new() { City = "Ankara", Name = "Ankara Tavası & Yaprak Döner", Category = "Ana Yemek", Description = "Kuzu incikli arpa şehriye pilavı ve meşe odununda yaprak döner.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Boğaziçi Lokantası / Cici Piknik / Süha", Rating = 5.0 },
        // 07 ANTALYA
        new() { City = "Antalya", Name = "Tahinli Antalya Piyazı & Şiş Köfte", Category = "Yöresel", Description = "Özel tarator ve tahin soslu haşlanmış kuru fasulye ve şiş köfte.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Piyazcı Ahmet / Piyazcı Sami / Topçu", Rating = 5.0 },
        // 08 ARTVİN
        new() { City = "Artvin", Name = "Artvin Kuymağı & Laz Böreği", Category = "Yöresel", Description = "Kolot peynirli taze kuymak ve muhallebili çıtır şerbetli börek.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Şavşat & Macahel Yayla Tesisleri", Rating = 4.9 },
        // 09 AYDIN
        new() { City = "Aydın", Name = "Çine Köftesi & Aydın İnciri", Category = "Ana Yemek", Description = "Özel baharat ve ince kuzu kıymasıyla ızgarada pişen tescilli köfte.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Köfteci Tahsin Çine / Enver Usta", Rating = 4.9 },
        // 10 BALIKESİR
        new() { City = "Balıkesir", Name = "Balıkesir Höşmerimi & Susurluk Tostu", Category = "Tatlı", Description = "Taze peynir mayalı fırın tatlısı ve köpüklü yayık ayranı.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Susurluk Dinlenme Tesisleri / Yasa", Rating = 4.9 },
        // 11 BİLECİK
        new() { City = "Bilecik", Name = "Pazaryeri Helvası & Bozüyük Mantısı", Category = "Tatlı", Description = "Geleneksel susam tahin helvası ve fırınlanmış köy mantısı.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Bilecik Tarihi Çarşı", Rating = 4.7 },
        // 12 BİNGÖL
        new() { City = "Bingöl", Name = "Bingöl Yayla Balı & Mastuva", Category = "Yöresel", Description = "Yüksek rakım çiçek balı ve pirinçli yoğurtlu sıcak yöre aşı.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Bingöl Yöresel Sofrası", Rating = 4.8 },
        // 13 BİTLİS
        new() { City = "Bitlis", Name = "Bitlis Büryan Kebabı", Category = "Ana Yemek", Description = "Kuyu fırınlarda buhar ve köz ateşiyle saatlerce nar gibi pişen kuzu eti.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Bitlis & Tatvan Tarihi Büryancıları", Rating = 5.0 },
        // 14 BOLU
        new() { City = "Bolu", Name = "Mengen Aşçı Pilavı & Abant Kebabı", Category = "Ana Yemek", Description = "Kuzu eti, mantar ve bademli pilav ile köz patlıcana sarılı kebap.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Mengen Tarihi Lokantaları / Kubbealtı", Rating = 4.9 },
        // 15 BURDUR
        new() { City = "Burdur", Name = "Burdur Şiş & Ceviz Ezmesi", Category = "Ana Yemek", Description = "Kaburga kıyması ve tuzla yapılan ince şiş ve cevizli tatlı.", ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=600", WhereToEat = "Özsaray Şiş / Toros Lokantası", Rating = 4.9 },
        // 16 BURSA
        new() { City = "Bursa", Name = "Tarihi Bursa İskender Kebabı", Category = "Ana Yemek", Description = "Pide üzerinde ince kuzu döneri, sıcak köpüklü tereyağı ve tava yoğurdu.", ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=600", WhereToEat = "Kebapçı İskender (Mavi Dükkan) / Uludağ", Rating = 5.0 },
        // 17 ÇANAKKALE
        new() { City = "Çanakkale", Name = "Fırınlanmış Peynir Helvası & Ezine Peyniri", Category = "Tatlı", Description = "Tuzsuz taze koyun peyniriyle fırınlanan sıcak sarı helva.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Kadir Usta / Helvacı Ali / Babalık", Rating = 4.9 },
        // 18 ÇANKIRI
        new() { City = "Çankırı", Name = "Tuzda Kuzu & Yaren Güveci", Category = "Ana Yemek", Description = "Kaya tuzu kalıbında saatlerce pişen pamuk kuzu eti.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Çankırı Yaren Sofrası", Rating = 4.8 },
        // 19 ÇORUM
        new() { City = "Çorum", Name = "İskilip Dolması & Çifte Kavrulmuş Leblebi", Category = "Yöresel", Description = "Özel kazanlarda buğulama usulü pişen cağ dolması ve leblebi.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "İskilip Konağı / Çorum Hanoğlu", Rating = 4.9 },
        // 20 DENİZLİ
        new() { City = "Denizli", Name = "Fırında Denizli Tandır Kebabı", Category = "Ana Yemek", Description = "Sakız odununda pişen, çatalsız elle yenen pamuk kuzu tandır.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Kocabaylar / Kebapçı Halil / Enver", Rating = 5.0 },
        // 21 DİYARBAKIR
        new() { City = "Diyarbakır", Name = "Diyarbakır Ciğer Kebabı & Burma Kadayıf", Category = "Ana Yemek", Description = "Kuzu ciğeri, sumaklı lavaş ve fıstıklı sıcak burma kadayıf.", ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=600", WhereToEat = "Ciğerci Xale Meheme / Sıtkı Usta", Rating = 5.0 },
        // 22 EDİRNE
        new() { City = "Edirne", Name = "Edirne Tava Ciğeri & Karaağaç Biberi", Category = "Ana Yemek", Description = "Yaprak inceliğinde kesilip kızgın yağda saniyeler içinde pişen çıtır ciğer.", ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=600", WhereToEat = "Ciğerci Niyazi Usta / Kazım Usta", Rating = 5.0 },
        // 23 ELAZIĞ
        new() { City = "Elazığ", Name = "Harput Köftesi & Orcik Tatlısı", Category = "Ana Yemek", Description = "Reyhanlı minik salçalı köfte ve cevizli taze üzüm sucuğu.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Harput Lokantası / Akgün Kebap", Rating = 4.8 },
        // 24 ERZİNCAN
        new() { City = "Erzincan", Name = "Erzincan Tulum Peyniri & Yaprak Döneri", Category = "Yöresel", Description = "Şavak yayla tulum peyniri ve odun ateşinde leziz et döner.", ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=600", WhereToEat = "Evin Döner / Tarihi Kapalı Çarşı", Rating = 4.9 },
        // 25 ERZURUM
        new() { City = "Erzurum", Name = "Erzurum Cağ Kebabı & Kadayıf Dolması", Category = "Ana Yemek", Description = "Yatık şişte meşe odununda pişen marine kuzu eti ve cevizli fıstıklı çıtır tatlı.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Koç Cağ Kebap / Gel-Gör / Muammer Usta", Rating = 5.0 },
        // 26 ESKİŞEHİR
        new() { City = "Eskişehir", Name = "Kırım Çiböreği & Balaban Kebabı", Category = "Hamur İşi", Description = "Puf kabaran çıtır kıymalı hamur ve yoğurtlu tereyağlı pide köftesi.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Papağan Çiğbörek / Fahrettin Usta", Rating = 4.9 },
        // 27 GAZİANTEP
        new() { City = "Gaziantep", Name = "Gaziantep Baklavası & Beyran Çorbası", Category = "Tatlı", Description = "40 kat yufka, boz fıstık ve sabah alevde pişen sarımsaklı kuzu çorbası.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "İmam Çağdaş / Koçak / Metanet", Rating = 5.0 },
        // 28 GİRESUN
        new() { City = "Giresun", Name = "Giresun Tombul Fındığı & Görele Pidesi", Category = "Yöresel", Description = "Dünyanın en kaliteli fındığı ve ortası yumurtalı gevrek pide.", ImageUrl = "https://images.unsplash.com/photo-1509722747041-616f39b57569?q=80&w=600", WhereToEat = "Görele Pidecileri / Fındık Pazarı", Rating = 4.9 },
        // 29 GÜMÜŞHANE
        new() { City = "Gümüşhane", Name = "Dut Pestili, Köme & Siron", Category = "Tatlı", Description = "Dut şırası ve cevizli geleneksel tatlı ve yoğurtlu fırın yufkası.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Kral Pestil / Gümüşhane Çarşısı", Rating = 4.8 },
        // 30 HAKKARİ
        new() { City = "Hakkari", Name = "Doğaba Yemeği & Yüksekova Kebabı", Category = "Ana Yemek", Description = "Kıymalı köfte, buğday ve süzme yoğurtlu asırlık düğün aşı.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Hakkari Yöresel Evi", Rating = 4.8 },
        // 31 HATAY
        new() { City = "Hatay", Name = "Tescilli Antakya Künefesi & Tepsi Kebabı", Category = "Tatlı", Description = "Közde pişen peynirli sıcak çıtır künefe ve fırınlanmış zırh kıyması.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Çınaraltı Künefe / Pöç Kasabı", Rating = 5.0 },
        // 32 ISPARTA
        new() { City = "Isparta", Name = "Isparta Fırın Kebabı & Gül Lokumu", Category = "Ana Yemek", Description = "Bakır kaplarda saatlerce eriyen kuzu eti ve mis kokulu gül lokumu.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Kebapçı Ferrodin / Gülbirlik", Rating = 4.9 },
        // 33 MERSİN
        new() { City = "Mersin", Name = "Biftek Mersin Tantunisi & Cezerye", Category = "Sokak Lezzeti", Description = "Pamuk yağıyla sacda pişen ince dana biftek ve havuçlu cevizli cezerye.", ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=600", WhereToEat = "Memoş Tantuni / Göksel Tantuni / Dondurmacı Halil", Rating = 5.0 },
        // 34 İSTANBUL
        new() { City = "İstanbul", Name = "Tarihi Sultanahmet Köftesi & Balık Ekmek", Category = "Sokak Lezzeti", Description = "1920'den beri değişmeyen ızgara köfte ve Eminönü tekne balık ekmeği.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Tarihi Sultanahmet Köftecisi (1920)", Rating = 4.9 },
        // 35 İZMİR
        new() { City = "İzmir", Name = "İzmir Boyozu, Gevrek & Çeşme Kumrusu", Category = "Sokak Lezzeti", Description = "Haşlanmış yumurtalı boyoz ve nohut mayalı ekmekte ızgara sucuk kaşar.", ImageUrl = "https://images.unsplash.com/photo-1509722747041-616f39b57569?q=80&w=600", WhereToEat = "Alsancak Dostlar Fırını / Kumrucu Şevki", Rating = 5.0 },
        // 36 KARS
        new() { City = "Kars", Name = "Fırında Kars Kazı & Kars Gravyeri", Category = "Ana Yemek", Description = "Kurutulmuş kaz eti, tereyağlı bulgur pilavı ve Boğatepe peyniri.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Kars Kaz Evi / Pushkin Restoran", Rating = 5.0 },
        // 37 KASTAMONU
        new() { City = "Kastamonu", Name = "Kastamonu Pastırması & Taşköprü Sarımsağı", Category = "Yöresel", Description = "Taş fırın kurutmalı çemenli pastırma ve sacda pişen etli ekmek.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Tabakoğlu Pastırma / Münire Medresesi", Rating = 4.9 },
        // 38 KAYSERİ
        new() { City = "Kayseri", Name = "Kayseri Mantısı & Yağlama (Şebit)", Category = "Ana Yemek", Description = "Bir kaşığa 40 tane sığan minik mantı ve kat kat kıymalı yağlama.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Kaşık-La / Elmacıoğlu / Sultan Sofrası", Rating = 5.0 },
        // 39 KIRKLARELİ
        new() { City = "Kırklareli", Name = "Kırklareli Köftesi & Hardaliye", Category = "Ana Yemek", Description = "Trakya süt danasından ızgara köfte ve hardal tohumlu fermente üzüm suyu.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Köfteci Ahmet / Tarihi Çarşı", Rating = 4.8 },
        // 40 KIRŞEHİR
        new() { City = "Kırşehir", Name = "Ahi Helvası & Çömlek Kebabı", Category = "Tatlı", Description = "Un, pekmez ve cevizle kavrulan asırlık helva ve tandır kebabı.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Ahi Sofrası Kırşehir", Rating = 4.8 },
        // 41 KOCAELİ
        new() { City = "Kocaeli", Name = "İzmit Pişmaniyesi & Kandıra Yoğurdu", Category = "Tatlı", Description = "İpek gibi tel tel dökülen pişmaniye ve manda sütü koyu yoğurt.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "İpek Pişmaniye / Tarihi Kandıra", Rating = 4.8 },
        // 42 KONYA
        new() { City = "Konya", Name = "Konya Etliekmeği & Fırın Kebabı", Category = "Ana Yemek", Description = "Metrelerce uzayan incecik çıtır pide ve taş fırında pişen kuzu.", ImageUrl = "https://images.unsplash.com/photo-1509722747041-616f39b57569?q=80&w=600", WhereToEat = "Havutlu Etliekmek / Hacı Şükrü (1907)", Rating = 5.0 },
        // 43 KÜTAHYA
        new() { City = "Kütahya", Name = "Kütahya Güveci & Cimcik Hamuru", Category = "Ana Yemek", Description = "Toprak güveçte saatlerce pişen dana eti ve minik çimdik mantısı.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Germiyan Konağı Restoran", Rating = 4.8 },
        // 44 MALATYA
        new() { City = "Malatya", Name = "Malatya Kağıt Kebabı & Kayısı Tatlısı", Category = "Ana Yemek", Description = "Yağlı kağıtta fırınlanan lokum kuzu eti ve tereyağlı cevizli kayısı.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Hacı Baba Sinan Et Lokantası", Rating = 5.0 },
        // 45 MANİSA
        new() { City = "Manisa", Name = "Tarihi Manisa Kebabı & Mesir Macunu", Category = "Ana Yemek", Description = "Pide üzerinde domatesli tereyağlı şiş köfte ve 41 çeşit baharatlı macun.", ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=600", WhereToEat = "Gülcemal Manisa Kebabı", Rating = 4.9 },
        // 46 KAHRAMANMARAŞ
        new() { City = "Kahramanmaraş", Name = "Dövme Maraş Dondurması & Eli Böğründe", Category = "Tatlı", Description = "Keçi sütü ve salepli dövme dondurma ve fırında yan yana kebap.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Yaşar Pastanesi / MADO / Kervan", Rating = 5.0 },
        // 47 MARDİN
        new() { City = "Mardin", Name = "Mardin Tavası & Sembusek (Kapalı Lahmacun)", Category = "Ana Yemek", Description = "Zırh kıyması, sumaklı soğan ve baharatlı çıtır kapalı hamur.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Bağdadi Restoran / Kebapçı Rıdo", Rating = 5.0 },
        // 48 MUĞLA
        new() { City = "Muğla", Name = "Çökertme Kebabı & Kabak Çiçeği Dolması", Category = "Ana Yemek", Description = "Kibrit patates üstü marine et, yoğurt ve zeytinyağlı taze dolma.", ImageUrl = "https://images.unsplash.com/photo-1555939594-58d7cb561ad1?q=80&w=600", WhereToEat = "Sünger Pizza Bodrum / Akyaka Sofrası", Rating = 5.0 },
        // 49 MUŞ
        new() { City = "Muş", Name = "Muş Köftesi & Havdel Tatlısı", Category = "Ana Yemek", Description = "Haşlama dev içli köfte ve geleneksel tereyağlı un helvası.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Muş Tarihi Lokantaları", Rating = 4.8 },
        // 50 NEVŞEHİR
        new() { City = "Nevşehir", Name = "Nevşehir Testi Kebabı", Category = "Ana Yemek", Description = "Masada alevler eşliğinde kırılan toprak çömlekte pişen kuzu eti.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Dibek Restoran Göreme / Seyyah Han", Rating = 5.0 },
        // 51 NİĞDE
        new() { City = "Niğde", Name = "Niğde Tavası & Bor Söğürmesi", Category = "Ana Yemek", Description = "Kuzu eti, sarımsak ve biberle fırınlanan tava ve meşhur Niğde gazozu.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Niğde Fırın Lokantaları", Rating = 4.8 },
        // 52 ORDU
        new() { City = "Ordu", Name = "Ordu Yağlı Pidesi & Fındıklı Burma", Category = "Hamur İşi", Description = "Kıymalı yumurtalı tereyağlı pide ve çıtır cevizli fındıklı burma tatlısı.", ImageUrl = "https://images.unsplash.com/photo-1509722747041-616f39b57569?q=80&w=600", WhereToEat = "Aktaşlar Pide / Derin Balık", Rating = 4.9 },
        // 53 RİZE
        new() { City = "Rize", Name = "Rize Kavurması & Muhlama", Category = "Ana Yemek", Description = "Bakır tavada pişen pamuk dana kavurma ve uzayan Kolot peynirli kuymak.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Liman Lokantası / Çayeli Hüsrev", Rating = 5.0 },
        // 54 SAKARYA
        new() { City = "Sakarya", Name = "Sakarya Islama Köftesi & Kabak Tatlısı", Category = "Ana Yemek", Description = "Kemik suyuyla ıslatılmış kırmızı biberli ekmek üstü ızgara köfte.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Köfteci İsmail / Köfteci Mustafa", Rating = 5.0 },
        // 55 SAMSUN
        new() { City = "Samsun", Name = "Bafra Pidesi & Çakallı Menemeni", Category = "Hamur İşi", Description = "İnce çıtır kapalı kıymalı tereyağlı pide ve bol kaşarlı sıcak menemen.", ImageUrl = "https://images.unsplash.com/photo-1509722747041-616f39b57569?q=80&w=600", WhereToEat = "Niyazi Kesim Bafra Pidesi / Çakallı", Rating = 5.0 },
        // 56 SİİRT
        new() { City = "Siirt", Name = "Siirt Büryan Kebabı & Perde Pilavı", Category = "Ana Yemek", Description = "Kuyu fırınlarında buharla nar gibi pişen kuzu ve hamur kaplı keklik pilavı.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Siirt Büryancısı Murat Usta", Rating = 5.0 },
        // 57 SİNOP
        new() { City = "Sinop", Name = "Cevizli ve Yoğurtlu Sinop Mantısı", Category = "Ana Yemek", Description = "Yarısı cevizli yarısı sarımsaklı yoğurtlu el açması incecik mantı.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Teyzenin Yeri Mantı Salonu / Örnek Mantı", Rating = 5.0 },
        // 58 SİVAS
        new() { City = "Sivas", Name = "Sivas Köftesi & Sivas Katmeri", Category = "Ana Yemek", Description = "Sadece kıyma ve tuzla yapılan tescilli köfte ve kat kat tereyağlı katmer.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Köfteci Ahmet Usta / Kirli Ahmet", Rating = 5.0 },
        // 59 TEKİRDAĞ
        new() { City = "Tekirdağ", Name = "Tekirdağ Köftesi & Hayrabolu Tatlısı", Category = "Ana Yemek", Description = "Özel acı sosuyla servis edilen ızgara köfte ve tahinli peynir tatlısı.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Özcanlar Köfte / İki Kardeşler", Rating = 5.0 },
        // 60 TOKAT
        new() { City = "Tokat", Name = "Özel Fırınında Tokat Kebabı", Category = "Ana Yemek", Description = "Patlıcan, domates, sarımsak ve kuzu etinin dikey şişte nar gibi pişmesi.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Mollaoğlu Tokat Kebabı / İşeri Restoran", Rating = 5.0 },
        // 61 TRABZON
        new() { City = "Trabzon", Name = "Akçaabat Köftesi & Hamsiköy Sütlacı", Category = "Ana Yemek", Description = "Sarımsaklı ızgara köfte ve yayla sütüyle fırınlanan üzeri fındıklı sütlaç.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Nihat Usta Akçaabat / Hamsiköy Tarihi Sütlaççıları", Rating = 5.0 },
        // 62 TUNCELİ
        new() { City = "Tunceli", Name = "Ovacık Kuru Fasulyesi & Babuko", Category = "Yöresel", Description = "Munzur kaynak sularıyla yetişen organik fasulye ve sarımsaklı yoğurtlu gömbe.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Munzur Sofrası Tunceli", Rating = 4.8 },
        // 63 ŞANLIURFA
        new() { City = "Şanlıurfa", Name = "Şanlıurfa Zırh Kebabı & İsotlu Çiğ Köfte", Category = "Ana Yemek", Description = "Zırhta çekilen kuzu kıyması ve hakiki tescilli Urfa isotlu çiğ köfte.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Gülbaba / Dedecan Ciğer / Cevahir Han", Rating = 5.0 },
        // 64 UŞAK
        new() { City = "Uşak", Name = "Uşak Tarhana Çorbası & Ebem Köftesi", Category = "Çorba", Description = "Kırmızı biber ve yoğurtla fermente edilen tescilli şifa çorbası.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Uşak Yöresel Evi", Rating = 4.8 },
        // 65 VAN
        new() { City = "Van", Name = "Meşhur Van Kahvaltısı & Otlu Peynir", Category = "Kahvaltı", Description = "Murtuğa, kavut, otlu peynir, bal ve sıcak lavaşla 20 çeşit ziyafet.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Bak Hele Bak Yusuf Konak / Sütçü Fevzi", Rating = 5.0 },
        // 66 YOZGAT
        new() { City = "Yozgat", Name = "Yozgat Testi Kebabı & Arabaşı", Category = "Ana Yemek", Description = "Közde kırılan toprak çömlek kebabı ve çiğnenmeden yutulan arabaşı çorbası.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Zafer Türk Mutfağı Yozgat", Rating = 4.9 },
        // 67 ZONGULDAK
        new() { City = "Zonguldak", Name = "Karadeniz Ereğli Pidesi & Mancar Sarması", Category = "Hamur İşi", Description = "Kıymalı çıtır Ereğli pidesi ve kestaneli karalahana sarması.", ImageUrl = "https://images.unsplash.com/photo-1509722747041-616f39b57569?q=80&w=600", WhereToEat = "Ereğli Pidecileri / Zonguldak Çarşı", Rating = 4.8 },
        // 68 AKSARAY
        new() { City = "Aksaray", Name = "Aksaray Tavası & Şerbetsiz Şekerli Pide", Category = "Ana Yemek", Description = "Kuzu kuşbaşı, sarımsak ve biberle fırınlanan tava ve peynirli pide.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Kardeşler Fırın Kebap Aksaray", Rating = 4.8 },
        // 69 BAYBURT
        new() { City = "Bayburt", Name = "Bayburt Lor Dolması & Galacoş", Category = "Yöresel", Description = "Pazı yaprağına sarılı taze lor ve bulgur dolması, kavurmalı yoğurtlu ekmek.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Bayburt Yöresel Konakları", Rating = 4.9 },
        // 70 KARAMAN
        new() { City = "Karaman", Name = "Taşkale Divle Obruk Peyniri & Fırın Kebap", Category = "Yöresel", Description = "Doğal mağaralarda olgunlaşan tulum peyniri ve yumuşacık fırın kebabı.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Karaman Tarihi Çarşı Lokantaları", Rating = 4.9 },
        // 71 KIRIKKALE
        new() { City = "Kırıkkale", Name = "Keskin Tavası", Category = "Ana Yemek", Description = "Kuzu pirzola, sarımsak, domates ve biberin sacda fırınlanması.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Keskin Tarihi Taş Mektep Restoran", Rating = 4.8 },
        // 72 BATMAN
        new() { City = "Batman", Name = "Batman Şam Böreği & Sason Çileği", Category = "Hamur İşi", Description = "Kıymalı sac böreği ve organik aromatik Sason dağ çileği.", ImageUrl = "https://images.unsplash.com/photo-1509722747041-616f39b57569?q=80&w=600", WhereToEat = "Batman Çarşı Lokantaları", Rating = 4.8 },
        // 73 ŞIRNAK
        new() { City = "Şırnak", Name = "Şırnak Kutlık'ı (Haşlama İçli Köfte)", Category = "Ana Yemek", Description = "İnce bulgur kabuğunda kıymalı cevizli haşlama köfte ve suryaz aşı.", ImageUrl = "https://images.unsplash.com/photo-1529042410759-befb1204b468?q=80&w=600", WhereToEat = "Cizre ve Şırnak Konakları", Rating = 4.8 },
        // 74 BARTIN
        new() { City = "Bartın", Name = "Amasra Salatası & Karadeniz Mezgit Tava", Category = "Yöresel", Description = "25 çeşit taze yeşillikle hazırlanan sanat eseri salata ve taze balık.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Mustafa Amca'nın Yeri / Canlı Balık Amasra", Rating = 5.0 },
        // 75 ARDAHAN
        new() { City = "Ardahan", Name = "Çıldır Sarıbalık Buğulama & Göle Kaşarı", Category = "Yöresel", Description = "Buz altından çıkan taze sarıbalık ve tescilli yayla kaşarı.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Çıldır Kütük Ev Tesisleri", Rating = 4.9 },
        // 76 IĞDIR
        new() { City = "Iğdır", Name = "Iğdır Bozbaşı (Piti Kebabı)", Category = "Ana Yemek", Description = "Özel çömlek kaplarda nohut ve kuzu incikle pişen safranlı lavaşlı ziyafet.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Iğdır Piti Salonları", Rating = 5.0 },
        // 77 YALOVA
        new() { City = "Yalova", Name = "Yalova Sütlüsü & Termal Sarması", Category = "Tatlı", Description = "Güllü ve fındıklı hafif tatlı ve dana etli sebzeli fırın sarması.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Yalova Sütlüsü İskele Şubesi", Rating = 4.8 },
        // 78 KARABÜK
        new() { City = "Karabük", Name = "Safranbolu Lokumu & Safranbolu Bükmesi", Category = "Tatlı", Description = "Hakiki safranlı taze lokum ve ıspanaklı kıymalı taş fırın bükmesi.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "İmren Lokumları / Tarihi Safranbolu Çarşısı", Rating = 5.0 },
        // 79 KİLİS
        new() { City = "Kilis", Name = "Kilis Tavası & Cennet Çamuru", Category = "Ana Yemek", Description = "Zırh kıymasının tepsiye yayılıp fırınlanması ve fıstıklı sıcak kadayıf.", ImageUrl = "https://images.unsplash.com/photo-1544025162-d76694265947?q=80&w=600", WhereToEat = "Kilis Tarihi Fırınları & Tatlıcıları", Rating = 5.0 },
        // 80 OSMANİYE
        new() { City = "Osmaniye", Name = "Osmaniye Yer Fıstığı & Kadirli Tirşiği", Category = "Yöresel", Description = "Tescilli çifte kavrulmuş fıstık ve şifalı yılan yastığı otu çorbası.", ImageUrl = "https://images.unsplash.com/photo-1541518763669-27fef04b14ea?q=80&w=600", WhereToEat = "Osmaniye Çarşı & Kadirli Lokantaları", Rating = 4.8 },
        // 81 DÜZCE
        new() { City = "Düzce", Name = "Akçakoca Melengücceği Tatlısı & Düzce Köftesi", Category = "Tatlı", Description = "Manda kaymağı ve cevizli şerbetli çıtır tatlı ve meşhur ızgara köfte.", ImageUrl = "https://images.unsplash.com/photo-1551024709-8f23befc6f87?q=80&w=600", WhereToEat = "Akçakoca Tarihi Konakları / Köfteci Hasan", Rating = 4.9 }
    };

    public List<FoodItem> GetFoods(string city, string category)
    {
        var query = _foods.AsQueryable();

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