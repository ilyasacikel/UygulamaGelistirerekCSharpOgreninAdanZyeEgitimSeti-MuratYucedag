# 👔 Personel İşlemleri Projesi

Bu proje, Windows Forms (WinForms) kullanılarak geliştirilmiş basit bir **Personel Takip Otomasyonu** uygulamasıdır. Kullanıcıların sisteme giriş yaparak personel bilgilerini görüntüleyebildiği, düzenleyebildiği ve raporlayabildiği temel bir masaüstü uygulamadır.

---

## 🚀 Projenin Özellikleri

### ✅ Giriş Sistemi
- Sisteme sadece admin ya da tanımlanmış kullanıcılar giriş yapabilir.
- Giriş kontrolleri kullanıcı adı ve şifreyle yapılır.

### ✅ Personel İşlemleri
- **Ekleme** ve **Güncelleme** işlemleri:
  - Ad, Soyad
  - Şehir (ComboBox ile)
  - Maaş
  - Medeni Durum (Evli/Bekar RadioButton)
  - Meslek
- **Listeleme** işlemi:
  - `DataGridView` nesnesi kullanılmıştır.
  - Kaynak veriler `Choose Data Source` ile design ekranında bağlanmıştır.
- **Silme** işlemi:
  - Seçilen personel sistemden silinebilir.

---

## 📊 İstatistik Formu

"İstatistik" butonuna tıklandığında:
- SQL sorguları ile bazı personel verileri hesaplanır ve gösterilir:
  - Toplam personel sayısı – `COUNT(*)`
  - Farklı şehir sayısı – `DISTINCT`
  - Toplam maaş – `SUM(Maas)`
  - Ortalama maaş – `AVG(Maas)`
  - En yüksek/En düşük maaş – `MAX(Maas)`, `MIN(Maas)`

---

## 📈 Grafik Formu

"Ana form" üzerindeki "Grafikler" butonu ile:
- Yeni bir form açılır ve içinde 2 adet `Chart` kontrolü bulunur.
- Bu grafiklerde:
  - Personel sayılarının şehir dağılımı (`GROUP BY`)
  - Maaşlar gibi diğer bilgiler görsel olarak sunulur.

---

## 🛠️ Teknik Detaylar

- **Teknolojiler:**
  - C# (Windows Forms)
  - ADO.NET (Veri bağlantısı için)
  - MS SQL Server (Veritabanı)
- **Kullanılan SQL Komutları:**
  - `SELECT`, `INSERT`, `UPDATE`, `DELETE`
  - `COUNT`, `SUM`, `MAX`, `MIN`, `AVG`, `DISTINCT`, `GROUP BY`

---

## 📚 Öğrenilenler / Kazanımlar

- Design ekranında `DataGridView` üzerinden veri kaynağı bağlama (`Choose Data Source`)
- ADO.NET ile veritabanı bağlantısı oluşturma
- SQL sorguları ile raporlama ve veri analiz teknikleri
- WinForms ile temel grafik oluşturma (`Chart`)
- Formlar arası geçiş ve veri aktarımı

---

## 📸 Görseller

![image](https://github.com/user-attachments/assets/bd390bc4-4bd8-414f-b4fc-e6295d340c28)

![image](https://github.com/user-attachments/assets/19739a2e-3890-4923-b81a-1e71d3254741)

![image](https://github.com/user-attachments/assets/3b56336d-d8bd-41b8-8b74-bfc8d9c62cc9)

![image](https://github.com/user-attachments/assets/6d54a492-ca7a-4a67-ba9b-667d7945ff3e)

