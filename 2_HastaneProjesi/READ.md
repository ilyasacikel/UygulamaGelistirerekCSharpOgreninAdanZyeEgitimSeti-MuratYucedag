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

---

## 🧪 Öğrenilen Konular
- ADO.NET ile veritabanı bağlantısı: SELECT, INSERT, UPDATE, DELETE
- Formlar arası veri aktarımı (örneğin, giriş yapan kullanıcının adını diğer forma taşımak)
- Process.Start() ile harici web sayfası açma
- Form.Show() vs Form.ShowDialog() farkları ve kullanım senaryoları
- Çoklu DataGridView kullanımı

## 📌 Ekran Görüntüleri
- Projeme ait bazı ekran görüntüleri
  
![image](https://github.com/user-attachments/assets/80bbb91a-2d6e-49a8-88b9-7a99d4abf2d9)

![image](https://github.com/user-attachments/assets/7ef7e4e6-41e0-4ccb-b42c-4c9647a0be7f)

![image](https://github.com/user-attachments/assets/7626b4d4-64f9-45e0-86d1-612bb035ed09)

![image](https://github.com/user-attachments/assets/1103dd2c-c732-46d4-8b10-04ff660873f2)

![image](https://github.com/user-attachments/assets/5c5cd56c-0ab0-447e-826d-46ade6788a66)
