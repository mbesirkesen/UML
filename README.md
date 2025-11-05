# UML Projeleri

Bu repository, .NET 8.0 ile geliştirilmiş UML diyagramlarının implementasyonlarını içermektedir.

## Projeler

### uml_1 - Person ve Öğrenci Yönetim Sistemi

Bu proje, kişi, adres, öğrenci ve profesör sınıflarını içeren bir yönetim sistemidir.

**Sınıflar:**
- `Person`: Kişi bilgilerini (ad, telefon, email, adres) tutar ve park yeri satın alma işlemi yapar
- `Address`: Adres bilgilerini tutar ve doğrulama/etiket oluşturma işlevleri sağlar
- `Student`: Öğrenci bilgilerini (öğrenci numarası, ortalama not) tutar ve ders kayıt uygunluğu kontrolü yapar
- `Profesor`: Profesör bilgilerini (maaş, personel numarası, hizmet yılı, ders sayısı) tutar ve öğrenci gözetimi yapar

### uml_3 - Pet Yönetim Sistemi

Evcil hayvan yönetimi için geliştirilmiş bir sistemdir.

**Sınıflar:**
- `Pet`: Evcil hayvan bilgilerini (ID, ad, yaş, sahip, tip) tutar ve besleme işlemleri yapar
- `Owner`: Hayvan sahibi bilgilerini tutar
- `Animal`: Hayvan tipi ve cins bilgilerini tutar
- `PetInformation`: Hayvan özellikleri ve aşı bilgilerini tutar
- `Vaccine`: Aşı bilgilerini tutar
- `Identifiable`: ID özelliği sağlayan interface
- `Experienced`: Ad özelliği sağlayan interface

### uml_5 - Araba Kiralama Sistemi

Araba kiralama ve rezervasyon işlemlerini yöneten bir sistemdir.

**Sınıflar:**
- `Transaction`: Kiralama işlemlerini tutar
- `Reservation`: Rezervasyon bilgilerini tutar ve onaylama işlemi yapar
- `Customer`: Müşteri bilgilerini (ID, ad, iletişim, adres, ödeme) tutar
- `Car`: Araba bilgilerini tutar ve borç işlemi yapar
- `RentingOwner`: Kiralama sahibi bilgilerini tutar ve hesap doğrulama yapar
- `Payment`: Ödeme bilgilerini tutar ve ekleme/güncelleme işlemleri yapar
- `Rentals`: Kiralama bilgilerini tutar ve ekleme/güncelleme işlemleri yapar

## Gereksinimler

- .NET 8.0 SDK veya üzeri
- Visual Studio 2022 veya Visual Studio Code

## Kullanım

Her projeyi ayrı ayrı çalıştırabilirsiniz:

```bash
# uml_1 projesini çalıştırma
cd uml_1/uml_1
dotnet run

# uml_3 projesini çalıştırma
cd uml_3/uml_3
dotnet run

# uml_5 projesini çalıştırma
cd uml_5/uml_5
dotnet run
```

## Proje Yapısı

```
UML/
├── uml_1/
│   ├── uml_1/
│   │   ├── Program.cs
│   │   └── uml_1.csproj
│   ├── uml_1.jpg
│   └── uml_1.sln
├── uml_3/
│   ├── uml_3/
│   │   ├── Program.cs
│   │   └── uml_3.csproj
│   ├── uml_3.jpg
│   └── uml_3.sln
└── uml_5/
    ├── uml_5/
    │   ├── Program.cs
    │   └── uml_5.csproj
    ├── uml_5.jpg
    └── uml_5.sln
```

## Notlar

- Her proje kendi solution (.sln) dosyasına sahiptir
- UML diyagramları proje klasörlerinde .jpg formatında bulunmaktadır
- Build çıktıları (bin/, obj/) ve Visual Studio dosyaları (.vs/) .gitignore ile hariç tutulmuştur

