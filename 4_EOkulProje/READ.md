# 🎓 E-Okul Sistemi

Bu proje, temel bir **E-Okul sistemi**dir. Öğrenci ve öğretmenlerin kullanımı için iki ayrı arayüz içerir. Windows Forms (WinForms) kullanılarak geliştirilen bu masaüstü uygulaması, hem ADO.NET komutları hem de DataSet/Sihirbaz yöntemleri ile veri işlemlerini öğrenmek ve ilişkisel tablo mantığını anlamak amacıyla geliştirilmiştir.

---

## 🔑 Proje Girişleri

### 👨‍🎓 Öğrenci Paneli
- Ana form üzerinden **öğrenci numarası** girilerek sisteme giriş yapılır.
- Öğrenci giriş yaptıktan sonra:
  - Kendi notlarını detaylı şekilde görüntüleyebilir.
  - Not listesi `DataGridView` kontrolüyle gösterilir.

### 👩‍🏫 Öğretmen Paneli
Öğretmen girişiyle açılan formadan aşağıdaki işlemler yapılabilir:

#### 🧍 Öğrenci İşlemleri
- Yeni öğrenci ekleme
- Mevcut öğrenciyi güncelleme
- Öğrenci silme

#### 🧑‍🤝‍🧑 Kulüp İşlemleri
- Kulüp ekleme
- Kulüp silme
- Kulüp güncelleme

#### 📚 Ders İşlemleri
- Ders ekleme
- Ders silme
- Ders güncelleme

#### 📝 Not İşlemleri
- Öğrencilerin notları sisteme girilir.
- Notlar üzerinden:
  - Ortalama hesaplama
  - Geçti/Kaldı durumu güncelleme işlemleri yapılabilir.

---

## 🛠️ Teknik Detaylar

### 🔌 Veritabanı
- MS SQL Server kullanılmıştır.
- Veritabanında **ilişkili tablolar** tanımlanmıştır:
  - Öğrenciler
  - Dersler
  - Kulüpler
  - Notlar
  - Öğretmenler

### ⚙️ Kullanılan Teknolojiler
- C# (Windows Forms - WinForms)
- ADO.NET
  - **Klasik SqlCommand komutları** (`SELECT`, `INSERT`, `UPDATE`, `DELETE`)
  - **DataSet** + TableAdapter + Wizard yöntemi
- DataGridView, ComboBox, TextBox, RadioButton kontrolleri

### 🧪 Öğrenilen Konular
- ADO.NET ile SQL komutları üzerinden manuel sorgular yazma
- DataSet ve TableAdapter kullanarak Sihirbaz (Wizard) ile veri bağlantısı kurma
- İlişkili tablolar üzerinden comboBox’lara veri çekme
- Formlar arası bilgi aktarımı
- CRUD işlemleri (Create, Read, Update, Delete)

---

## 🎯 Proje Amacı

Bu proje, iki farklı ADO.NET yaklaşımını (klasik yöntem vs. DataSet/Sihirbaz yöntemi) karşılaştırmak ve uygulamalı olarak öğrenmek amacıyla geliştirilmiştir. Hem kullanıcı arayüzü hem de veri bağlantısı bakımından temel düzeyde gerçek bir e-okul sistemine benzerlik göstermektedir.

---

## 📸 Ekran Görüntüleri 

![image](https://github.com/user-attachments/assets/67b247eb-d704-4792-bf22-90f5e9c23415)

![image](https://github.com/user-attachments/assets/f47cf966-a880-44b6-af27-63cd0867a507)

![image](https://github.com/user-attachments/assets/9ecc92dd-6865-485a-87c8-24d58a9e83a8)

![image](https://github.com/user-attachments/assets/24204f42-4786-49e5-99a7-a16a0cd69b22)

![image](https://github.com/user-attachments/assets/bfab40e4-0943-4f84-858c-dbeb54b865d4)

![image](https://github.com/user-attachments/assets/24eb68b3-990b-4bf8-a91f-6e43eb3d52b6)
