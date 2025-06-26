# 📚 Basit Kütüphane Uygulaması (Access Veritabanı ile)

Bu proje, C# Windows Forms kullanılarak geliştirilmiş basit bir kütüphane yönetim uygulamasıdır. Projenin ana amacı, **Access veritabanı (Access `.accdb`)** ile bağlantı kurmayı ve temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirmeyi öğrenmektir.

## 🎯 Proje Amacı

- Access veritabanı dosyasını projeye dahil etmek
- `OleDbConnection` ile veritabanına bağlanmak
- Kitap ekleme, silme, güncelleme ve listeleme işlemlerini gerçekleştirmek
- RadioButton ve ComboBox kullanımıyla form etkileşimi sağlamak

## 🛠️ Kullanılan Teknolojiler

- C# (.NET Framework)
- Windows Forms
- Microsoft Access (`.accdb`)
- OleDb (OLE DB Data Provider)

## 🧪 ADO.NET Kullanımı

Bu projede ADO.NET teknolojisi kullanılarak Microsoft Access veritabanı ile bağlantı kurulmuştur. `OleDbConnection`, `OleDbCommand`, `OleDbDataAdapter` gibi sınıflar ile veritabanı işlemleri gerçekleştirilmiştir.

Kullanılan ADO.NET işlemleri:
- Veritabanı bağlantısı (`OleDbConnection`)
- SQL komutları ile veri ekleme, silme, güncelleme (`OleDbCommand`)
- Verilerin `DataGridView` üzerinde listelenmesi (`OleDbDataAdapter`, `DataTable`)

## 🗃️ Veritabanı Yapısı (Kitaplik.accdb)

**Tablo Adı:** `Kitaplar`

| Alan Adı      | Veri Tipi   |
|---------------|-------------|
| KitapId       | AutoNumber  |
| KitapAd       | Short Text        |
| KitapYazar    | Short Text        |
| KitapTur      | Short Text        |
| KitapSayfa    | Number      |
| KitapDurum    | Yes/No (Boolean) |

## 🧩 Uygulama Özellikleri

- 📄 Kitapları listeleme (`dataGridView`)
- ➕ Yeni kitap ekleme
- 🗑️ Kitap silme
- 🔄 Kitap bilgilerini güncelleme
- 🔍 Kitap adına göre arama yapma
- ✅ Sıfır veya kullanılmış kitap durumunu seçebilme (RadioButton)

## 📌 Ekran Görüntüsü

![image](https://github.com/user-attachments/assets/e8535b25-2486-4048-97f5-a6e182c128b3)

![image](https://github.com/user-attachments/assets/2ac1c99e-cafc-44f2-9023-c1ef40258b27)


