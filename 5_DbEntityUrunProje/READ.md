# 🛒 Ürün Yönetim Sistemi

Bu proje, temel bir **Ürün ve Kategori Yönetim Sistemi**'dir. Kullanıcı dostu bir arayüz ile kategori ve ürün işlemleri yapılabilmekte, ayrıca istatistiksel bilgiler de görüntülenebilmektedir.

---

## ⚡ Özellikler

### 📂 Kategori İşlemleri
- Kategori ekleme
- Kategori güncelleme
- Kategori silme
- Kategori listeleme

### 📦 Ürün İşlemleri
- Ürün ekleme
- Ürün güncelleme
- Ürün silme
- Ürün listeleme

### 📊 İstatistikler
- Ürün ve kategori bazlı çeşitli istatistikler
- Örneğin: En çok ürüne sahip marka bilgisi (örnek sorgu kullanımı)

---

## 🛠️ Kullanılan Teknolojiler ve Yöntemler

- **C# / WinForms**
- **Entity Framework (Database First)**
  - EF paketleri NuGet Paket Yöneticisi ile indirildi.
  - Veritabanı değiştiğinde **Model güncelleme** nasıl yapılır öğrenildi.
- **MS SQL Server** veritabanı (ilişkisel tablolar kullanıldı)
- **LINQ ve Lambda ifadeleri**
  - LINQ sorguları ile veri çekme, filtreleme ve sıralama
  - Lambda fonksiyonları ile dinamik veri işlemleri
- **Null-Coalescing operatörü (`??`)** kullanımı ile boş değer kontrolü
- **SELECT TOP 1 ... GROUP BY ... ORDER BY COUNT(*) DESC**
  - SQL sorgusu ile en çok ürüne sahip marka tespiti ve bu sorgunun EF/LINQ'e entegrasyonu
- **DataGridView**
  - Yalnızca istenilen sütunların gösterilmesi için özelleştirildi.

---

## 🎯 Öğrenilen / Uygulanan Konular

✅ Entity Framework DB First yaklaşımı ve model güncellemeleri  
✅ LINQ ve lambda ifadeleriyle veri sorgulama ve manipülasyon  
✅ Sorgularda **null kontrolü**, **gruplama**, **aggregate (SUM, COUNT)** fonksiyonları  
✅ SQL sorgularının EF ile kullanımı  
✅ Veritabanında yapılan değişikliklerin projeye nasıl yansıtılacağı

---

## 🌟 Projenin Amacı

Bu proje, **Entity Framework Database First yaklaşımını uygulamalı olarak öğrenmek**, LINQ ve lambda ifadeleriyle sorgulama ve işlemler yapabilmek amacıyla geliştirilmiştir.

---

## 📸 Ekran Görüntüleri

![image](https://github.com/user-attachments/assets/791db7bd-ef13-41f6-a79f-1b664615a578)

![image](https://github.com/user-attachments/assets/d93d16af-76d2-4064-9165-976ee2a83158)

![image](https://github.com/user-attachments/assets/8d13bdfb-af7a-42d8-b278-d9080e8a7765)

![image](https://github.com/user-attachments/assets/e8cf3242-6c68-468e-b1ce-7e1623d08bca)
