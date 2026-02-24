# 🛒 StoreAppMvc

Modern ASP.NET Core MVC kullanılarak geliştirilmiş, katmanlı mimariye sahip bir E-Ticaret Web Uygulaması.

---

## 🚀 Proje Hakkında

StoreAppMvc, ürün ve sipariş yönetimi işlemlerini gerçekleştiren, sürdürülebilir ve ölçeklenebilir mimari prensiplerine uygun olarak geliştirilmiştir.

Bu projede:

- Katmanlı mimari kullanılmıştır
- Entity Framework Core ile veri erişimi sağlanmıştır
- Repository Pattern uygulanmıştır
- Service Layer ile iş mantığı ayrıştırılmıştır

---

## 🧱 Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|---------|----------|
| ASP.NET Core MVC | Web framework |
| Entity Framework Core | ORM |
| SQL Server | Veritabanı |
| C# | Programlama dili |
| LINQ | Veri sorgulama |
| Bootstrap | UI tasarımı |

---

## 📂 Proje Mimarisi
StoreAppMvc
│
├── StoreApp.Web → UI Layer
├── StoreApp.Service → Business Layer
├── StoreApp.Data → Data Access Layer
└── StoreApp.Entity → Entity Layer

---

## ✨ Özellikler

✔ Ürün listeleme  
✔ Ürün detay sayfası  
✔ Ürün ekleme, silme, güncelleme  
✔ Sipariş oluşturma  
✔ SQL Server entegrasyonu  
✔ Katmanlı mimari  

---
## ⚙ Kurulum ve Çalıştırma

Projeyi çalıştırmak için öncelikle repository’yi `git clone https://github.com/zehranurolcay/StoreAppMvc.git` komutu ile bilgisayarınıza klonlayın ve Visual Studio ile `StoreAppMvc.sln` dosyasını açın. 
Ardından `StoreApp.Web` klasörü içindeki `appsettings.json` dosyasında bulunan ConnectionStrings alanını kendi SQL Server bağlantı bilginize göre düzenleyin. 
Daha sonra Visual Studio içerisinde Tools → NuGet Package Manager → Package Manager Console bölümünü açarak `Update-Database` komutunu çalıştırın ve veritabanını oluşturun. 
Son olarak projeyi başlatmak için Ctrl + F5 tuşlarına basın veya Start butonuna tıklayın, uygulama tarayıcıda otomatik olarak açılacaktır.

---

## 🎯 Proje Amacı

Bu proje aşağıdaki konularda pratik yapmak için geliştirilmiştir:
ASP.NET Core MVC
Entity Framework Core
N-Tier Architecture
Repository Pattern
