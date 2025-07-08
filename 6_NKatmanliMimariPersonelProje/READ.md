# 🧱 N Katmanlı Mimari Personel Projesi

Bu proje, çok katmanlı mimari (N-Layer Architecture) kullanılarak geliştirilen çok basit bir **Personel Takip ve Yönetim Uygulamasıdır**. Uygulama; **Entity Layer**, **Data Access Layer (DAL)**, **Logic Layer (LL)** ve **Presentation Layer** olmak üzere 4 temel katmandan oluşur.

---

## 📁 Katman Yapısı

### 1️⃣ Entity Layer

* Uygulamanın temel veri nesneleri burada tanımlanır.
* **EntityDepartman.cs** ve **EntityPersonel.cs** adında iki sınıf yer alır.
* Sadece property ve field barındırır; iş veya veri erişim işlemlerini içermez.

### 2️⃣ Data Access Layer (DAL)

* Veritabanı işlemleri burada gerçekleştirilir (ADO.NET kullanılarak).
* **Baglanti.cs**: SQL Server bağlantısını tutar.

  ```csharp
  public class Baglanti
  {
      public static SqlConnection bgl = new SqlConnection("Data Source=...;Initial Catalog=...;Integrated Security=True;");
  }
  ```
* **DALDepartman.cs**, **DALPersonel.cs**:

  * Tüm CRUD işlemleri burada yapılır.
  * `SqlCommand.Connection.State` kontrolüyle bağlantının açık olup olmadığı kontrol edilerek performans ve hata yönetimi sağlanır:

    ```csharp
    if (komut.Connection.State != ConnectionState.Open)
    {
        komut.Connection.Open();
    }
    ```

### 3️⃣ Logic Layer (LL)

* İş mantığı burada tanımlanır.
* Verilerin doğrulaması bu katmanda yapılır.
* Örnek:

  ```csharp
  public static bool LLPersonelGuncelle(EntityPersonel entity)
  {
      if (entity.Ad != "" && entity.Soyad != "" && entity.Maas >= 5000 && entity.Ad.Length >= 3)
      {
          return DALPersonel.PersonelGuncelle(entity);
      }
      else
      {
          return false;
      }
  }
  ```

### 4️⃣ Presentation Layer (UI)

* **WinForms** tabanlı kullanıcı arayüzü burada yer alır.
* Kullanıcıdan alınan veriler Logic Layer’a gönderilir, validasyon geçerse DAL’a aktarılır.
* Formlar üzerinden departman ve personel işlemleri yapılabilir.

---

## ⚙️ Uygulama Özellikleri

* Personel ve departman:

  * **Ekleme**
  * **Silme**
  * **Güncelleme**
  * **Listeleme**
* Katmanlı mimari prensiplerine uygun yapı
* SQL bağlantısı merkezi ve yönetilebilir bir yapıda (Baglanti.cs)
* ADO.NET ile doğrudan sorgu yönetimi
* Validasyonların mantıksal ayrımı (LL katmanı)

---

## 🎓 Öğrenilen Konular

✅ N Katmanlı Mimari yapısı
✅ ADO.NET ile veri işlemleri
✅ Static class/method kullanımı
✅ `SqlConnection` yönetimi ve bağlantı durum kontrolü
✅ Formlar arası geçiş ve veri akışı
✅ Doğrulama ve iş kurallarının katmanlara ayrılması
✅ Katmanlar arası **referans verme işlemi**
✅ `WinForms` ile kullanıcı arayüzü geliştirme

---

## 🔌 Veritabanı Bilgisi

* SQL Server kullanıldı.
* `NKatmanliMimariPersonelProje` adlı veritabanı kullanıldı.
* Tablolar arasında ilişkiler tanımlandı.
* CRUD işlemler doğrudan SQL sorguları ile ADO.NET üzerinden yapıldı.

---

## 💡 Projenin Amacı

Bu proje, **katmanlı mimari yapısını** anlamak, **katmanlar arası bağımlılığı doğru yönetmek**, veri işlemlerini mantıksal ve teknik olarak ayrıştırmayı öğrenmek amacıyla geliştirilmiştir.

---

## 📸 Ekran Görüntüleri 

![image](https://github.com/user-attachments/assets/2d845e63-79c8-44c8-a154-6fdf8fea7029)

![image](https://github.com/user-attachments/assets/c063bf93-94fd-495c-bba7-cef886d6d8aa)

![image](https://github.com/user-attachments/assets/08dc04b5-a51d-4911-8c1e-7debbc183670)

