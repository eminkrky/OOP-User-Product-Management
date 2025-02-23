# OOP-User-Product-Management
# 🏗️ ConsoleApp2 - Nesne Yönelimli Programlama (OOP) ile Kullanıcı ve Ürün Yönetimi

Bu proje, **C# ile Nesne Yönelimli Programlama (OOP)** prensiplerini kullanarak bir **kullanıcı ve ürün yönetimi sistemi** oluşturmayı amaçlar.  
Proje, **admin** ve **customer** adlı kullanıcı rollerini içerir ve ürün ekleme/satın alma gibi temel işlemleri gerçekleştirmektedir.

## 🚀 Kullanılan OOP Kavramları
Bu projede **Nesne Yönelimli Programlama**'nın temel bileşenleri uygulanmıştır:

1. **Sınıflar (Classes)**  
   - `admin` ve `customer` sınıfları, kullanıcıları temsil eder.  
   - `addProduct` ve `buyProduct` sınıfları, ürün işlemlerini yönetir.

2. **Arayüzler (Interfaces)**  
   - `IUser` arayüzü, tüm kullanıcılar için ortak özellikler sunar.  
   - `admin` ve `customer` sınıfları bu arayüzü uygular.

3. **Kalıtım (Inheritance)**  
   - `admin` sınıfı, `addProduct` sınıfından miras alarak ürün ekleme işlemini yönetir.  
   - `customer` sınıfı, muhtemelen `buyProduct` ile ilişkilidir.

4. **Encapsulation (Kapsülleme)**  
   - `Name` gibi özellikler, `public string Name { get; set; }` ile kapsüllenmiştir.

5. **Polymorphism (Çok Biçimlilik)**  
   - `IUser` arayüzü, farklı sınıflar tarafından farklı şekillerde uygulanabilir.

---

## 📂 Proje Yapısı

ConsoleApp2/
│── Classes/
│   ├── admin.cs          # Admin kullanıcısı
│   ├── customer.cs       # Müşteri kullanıcısı
│
│── Features/
│   ├── addProduct.cs     # Ürün ekleme işlemi
│   ├── buyProduct.cs     # Ürün satın alma işlemi
│
│── Interfaces/
│   ├── IUser.cs          # Kullanıcı arayüzü (interface)
│── Program.cs            # Ana çalışma dosyası
---

## 🛠️ Kurulum ve Çalıştırma

1. **Projeyi klonlayın**  
   ```bash
   git clone https://github.com/kullaniciadi/ConsoleApp2.git
   cd ConsoleApp2

	2.	Visual Studio ile Açın
	•	Projeyi Visual Studio veya VS Code ile açın.
	3.	Çalıştırın
	•	F5 tuşuna basarak veya aşağıdaki komutla çalıştırabilirsiniz:

dotnet run

🔥 Kod Kullanımı

Program.cs içinde aşağıdaki kod çalıştırılmaktadır:

admin kullanici1 = new admin();
customer kullanici2 = new customer();

kullanici1.Name = "Ahmet";
kullanici2.Name = "Mehmet";

Console.Write(kullanici1.Name);
kullanici1.add();

Console.Write(kullanici2.Name);
kullanici2.buy();

🎯 Geliştirme Adımları

✅ Kullanıcılar için temel sınıflar oluşturuldu.
✅ Interface kullanılarak bağımlılıklar azaltıldı.
✅ Kapsülleme (Encapsulation) ile veri güvenliği sağlandı.
✅ Kalıtım (Inheritance) ve Polymorphism uygulandı.
🚀 Daha iyi bir veri tabanı yönetimi ve bağımlılık enjeksiyonu (Dependency Injection) eklenebilir.

📜 Lisans

Bu proje MIT Lisansı altında dağıtılmaktadır.

👨‍💻 Geliştirici: Muhammet Emin Karakaya
📅 Oluşturulma Tarihi: 23.02.2025

---
