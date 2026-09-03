<div align="center">

# 🧭 Gezginin Rotası | Traveler's Route
### *81 İlin Kültür, Doğa, Lezzet & Yapay Zeka Seyahat Rehberi*
### *All 81 Provinces of Turkey — Culture, Nature, Gastronomy & AI Travel Companion*

[![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![.NET MAUI](https://img.shields.io/badge/.NET_MAUI-Cross--Platform-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/apps/maui)
[![C# 12](https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Google Gemini AI](https://img.shields.io/badge/Google_Gemini-3.6_Flash-4285F4?style=for-the-badge&logo=google&logoColor=white)](https://ai.google.dev/)
[![Language: TR / EN](https://img.shields.io/badge/Language-TR%20%7C%20EN-FF7F00?style=for-the-badge)](https://github.com/guneyoznur0-pixel/GezgininRotasi)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](LICENSE)

<br/>

<p align="center">
  <b>Gezginin Rotası</b>, Türkiye'nin 81 ilini tarihi yapıları, kanyonları, antik kentleri, yöresel mutfakları, bölgesel şiveleri ve Google Gemini Yapay Zekası ile keşfetmenizi sağlayan modern, çift dilli (Türkçe & İngilizce) bir mobil ve masaüstü seyahat ekosistemidir.
</p>

---

</div>

## 🌟 Key Features | Öne Çıkan Özellikler

### 🏛️ 1. 81 İl Kapsamlı Gezi & Müze Atlası (Sights & Attractions)
* **01 Adana'dan 81 Düzce'ye kadar:** Türkiye'nin tüm ilçelerindeki kanyonlar, kaleler, antik kentler, yaylalar ve açık hava müzeleri.
* **Tek Tıkla Google Maps Entegrasyonu:** Her noktanın detayından anında Google Haritalar üzerinden rota ve yol tarifi alma.
* **Akıllı Filtreleme:** Gezilecek Yerler, Doğa Parkları ve Müzeler kategorilerine göre filtreleme.

### 🍲 2. Yöresel Gastronomi & "Nerede Yenir?" Rehberi (Gastronomy)
* Her ilin tescilli imza yemekleri, tatlıları ve sokak lezzetleri.
* O yörenin en meşhur tarihi ustaları ve restoran tavsiyeleri (*Where to Eat?*).

### 🤖 3. Google Gemini Destekli Gezgin AI Asistanı (AI Travel Assistant)
* **Çift Dilli Akıllı Asistan:** Seçtiğiniz şehir ve dile (TR/EN) göre özel 1 günlük rotalar, bütçe tavsiyeleri ve gizli kalmış mekanları listeleyen yapay zeka entegrasyonu.
* **Hızlı İstekler:** *"1 Günlük Rota Çiz"*, *"Ne Yenir?"*, *"Bütçe Dostu Gezi"*, *"Gizli Kalmış Yerler"*.

### 🇹🇷 4. Oyunlaştırılmış 81 İl Gezgin Pasaportu (Travel Passport)
* Ziyaret ettiğiniz illeri işaretleyerek Türkiye keşif yüzdenizi (%0 - %100) takip edin.
* **Kazanılabilir Başarı Rozetleri:** *İlk Adım, Ege Aşığı, Karadeniz Kaşifi, Metropol Seyyahı, Güneydoğu Gurmesi, Türkiye Fatihi*.
* **Gezgin Seviyeleri:** *Yolun Başında ➡️ Meraklı Gezgin ➡️ Yol Kaşifi ➡️ Usta Seyyah ➡️ Bölge Fatihi ➡️ Türkiye Fatihi 🏆*.

### 🗣️ 5. Büyük Türkiye Ağızları & Şive Atlası (Regional Dialect Atlas)
* Türkiye'nin 81 iline ait otantik yöresel tabirler, deyimler, hitaplar ve örnek cümleler.

### 🎒 6. Özel Gezgin Araçları (Travel Utilities)
* **Akıllı Valiz Listesi (Packing Checklist):** Yaz/Deniz, Kış/Kayak, Doğa/Kamp ve Şehir gezilerine göre dinamik valiz hazırlama kontrol listesi.
* **Şans Çarkı / Kararsızım (Lucky Spin):** Kararsız kalan gezginler için tek tıkla rastgele il, yemek, gezilecek yer ve yöresel türkü seçen macera çarkı.
* **Dijital Kartpostal Paylaşımı (Social Postcard):** Instagram Story ve WhatsApp için onaylı gezgin kartpostalı üretme.
* **Gezgin Günlüğüm (Travel Diary):** Ziyaret edilen yerlere ait anıları, tarih ve duygu durumuyla yerel veritabanında saklama.

---

## 🌐 Çoklu Dil Desteği (Multi-Language / Internationalization)

Uygulama, hem yerli gezginler hem de Türkiye'yi ziyaret eden uluslararası turistler için **tek tıkla Türkçe 🇹🇷 ve İngilizce 🇬🇧** arasında geçiş yapabilen `LocalizationService` mimarisine sahiptir:
* Menüler, filtreler, rozetler ve içerikler seçilen dile anında uyarlanır.
* Google Gemini AI, İngilizce seçildiğinde yabancı turistlere yönelik İngilizce rehberlik moduna geçer.

---

## 🛠️ Architecture & Tech Stack | Mimari ve Teknolojiler

```
GezginRotası/
├── GezginRotası2/
│   ├── LocalizationService.cs      # Event-driven TR/EN çoklu dil yöneticisi
│   ├── GeminiService.cs            # Google Gemini 1.5 Flash REST API Entegrasyonu
│   ├── PlacesDataService.cs        # 81 İl gezi & müze veritabanı
│   ├── FoodDataService.cs          # 81 İl yöresel gastronomi veritabanı
│   ├── PassportService.cs          # Pasaport istatistik, rozet ve rütbe motoru
│   ├── CultureDataService.cs       # Yöresel halk türküleri & tarihi şahsiyetler
│   ├── DiaryService.cs             # Yerel anı & günlük depolama servisi
│   ├── MainPage.xaml               # Modern Dark Luxury ana kontrol paneli
│   ├── PlacesPage.xaml             # Dinamik gezi kartları ve harita aksiyonları
│   ├── FoodsPage.xaml              # Lezzet kartları & nerede yenir rehberi
│   ├── PassportPage.xaml           # 81 İl interaktif pasaport ekranı
│   └── AiAssistantPage.xaml        # Gemini AI interaktif sohbet arayüzü
```

| Teknoloji | Açıklama |
| :--- | :--- |
| **Framework** | .NET 8.0 MAUI (Multi-platform App UI) |
| **Language** | C# 12 |
| **Platforms** | Android, iOS, Windows, macOS (Mac Catalyst) |
| **AI Integration** | Google Gemini API (`generateContent` endpoint) |
| **Design System** | Modern Dark Luxury UI, Responsive Card Grids, Glassmorphism, Micro-interactions |
| **Maps Integration** | Native Deep-linking via Google Maps URL Scheme |

---

## 🚀 Getting Started | Kurulum ve Çalıştırma

### Gereksinimler (Prerequisites)
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* [Visual Studio 2022](https://visualstudio.microsoft.com/) (.NET MAUI iş yükü yüklü) veya VS Code (.NET MAUI Extension)

### Adımlar (Steps)

1. **Depoyu Klonlayın:**
   ```bash
   git clone https://github.com/guneyoznur0-pixel/GezgininRotasi.git
   cd GezgininRotasi/GezginRotası2
   ```

2. **Bağımlılıkları Yükleyin:**
   ```bash
   dotnet restore
   ```

3. **Uygulamayı Çalıştırın:**
   * **Windows üzerinde çalıştırmak için:**
     ```bash
     dotnet build -f net8.0-windows10.0.19041.0
     dotnet run -f net8.0-windows10.0.19041.0
     ```
   * **Android Emülatör / Cihaz üzerinde çalıştırmak için:**
     ```bash
     dotnet build -f net8.0-android
     ```

---

## 💼 CV / Portfolyo Özeti (Project Highlights for Resume)

* **Full-Stack Cross-Platform Architecture:** .NET 8 MAUI kullanılarak Android, iOS ve Windows için tek kod tabanından derlenen modern mobil uygulama.
* **Generative AI Integration:** Google Gemini API entegrasyonu ile akıllı, bağlama duyarlı seyahat asistanı ve seyahat planlayıcısı geliştirildi.
* **Large-Scale Data Architecture:** Türkiye'nin 81 ilinin tamamını kapsayan kanyonlar, müzeler, gastronomi ve kültürel şive verileri optimize edilmiş veri servisleriyle modellendi.
* **Internationalization (i18n):** Uluslararası kullanıcılar için event-driven çoklu dil mimarisi ve çift dilli prompt mühendisliği uygulandı.
* **Gamification:** Gezilen illerin durumunu takip eden, başarı rozetleri ve seviye atlama sistemi içeren interaktif Gezgin Pasaportu geliştirildi.

---

## 📄 Lisans (License)
Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.

<div align="center">
  <sub>Developed with ❤️ for Turkish Culture & Global Travelers.</sub>
</div>
