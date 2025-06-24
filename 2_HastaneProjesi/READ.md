# 🏥 Basit Hastane Yönetim Sistemi

Bu proje, C# Windows Forms ve **ADO.NET** kullanılarak geliştirilmiş basit bir Hastane Sistemidir. Uygulama, **Hasta**, **Doktor** ve **Sekreter** rolleriyle giriş yapılabilen bir yapıya sahiptir. Her rolün sisteme özel yetkileri ve arayüzleri mevcuttur.

## 🎯 Proje Amaçları

- Formlar arası veri aktarma
- ADO.NET ile veritabanı işlemleri
- Kullanıcı dostu arayüz oluşturmak
- Web'e yönlendirme ve sistem işlevlerini tetikleme (Google, Sağlık Bakanlığı)
- `Form.Show()` ve `Form.ShowDialog()` farkını kavramak

## 🛠️ Kullanılan Teknolojiler

- C# (.NET Framework)
- Windows Forms
- Microsoft SQL Server
- **ADO.NET** (SqlConnection, SqlCommand, SqlDataAdapter, DataTable)
- Process sınıfı ile dış tarayıcı kontrolü

---

## 👥 Roller ve Özellikler

### 👤 Hasta Paneli
- TC Kimlik ve şifre ile giriş
- Kayıt olma ve bilgilerini güncelleme (Ad, Soyad, Cinsiyet, Telefon, Şifre)
- Geçmiş randevularını görüntüleme (DataGridView)
- Yeni randevu oluşturma: branş ve doktor seçimi + şikayet bildirimi
- Giriş yapan hastanın adı ve TCKN üst köşede gösterilir

### 🩺 Doktor Paneli
- TC Kimlik ve şifre ile giriş
- Giriş yapan doktor bilgileri (ad, TCKN) görüntülenir
- Doktor, kendisine atanmış randevuları görebilir
- Seçilen randevunun detayları (`şikayet`) gösterilir
- Bilgilerini düzenleyebilir
- 🔘 Hızlı Erişim Paneli:
  - 📢 Duyurular: Sekreterin gönderdiği mesajlar
  - 🌐 Google’da Ara
  - 🏛️ Sağlık Bakanlığı Sitesi (→ `https://www.saglik.gov.tr/`)
  - ❌ Çıkış

```csharp
Process.Start(new ProcessStartInfo {
    FileName = "https://www.saglik.gov.tr/",
    UseShellExecute = true
});
```
### 🧾 Sekreter Paneli
- TC Kimlik ile giriş, ad ve soyad görüntülenir
- Branş işlemleri: Görüntüleme, Ekleme, Güncelleme, Silme
- Doktor işlemleri: Görüntüleme, Ekleme, Güncelleme, Silme
- Randevu işlemleri: Tüm randevuları listeleme, randevu oluşturma, güncelleme
- Duyuru oluşturma: Doktorlara duyuru gönderme

## 🧪 Öğrenilen Konular
- ADO.NET ile veritabanı bağlantısı: SELECT, INSERT, UPDATE, DELETE
- Formlar arası veri aktarımı (örneğin, giriş yapan kullanıcının adını diğer forma taşımak)
- Process.Start() ile harici web sayfası açma
- Form.Show() vs Form.ShowDialog() farkları ve kullanım senaryoları
- Çoklu DataGridView kullanımı


🧑‍🏫 Bu proje, Murat Yücedağ'ın "Uygulama Geliştirerek C# Öğrenin: A'dan Z'ye Eğitim Seti" Udemy kursunun bir parçası olarak geliştirilmiştir.
