# 🏢 Shiftex - Personel Vardiya ve Devam Takip Sistemi

Shiftex, işletmelerin personel vardiya görevlendirmelerini, devam durumlarını ve izin taleplerini yönetmek için geliştirilmiş modern bir web uygulamasıdır. Sistem JWT tabanlı güvenli kimlik doğrulama, yüz tanıma entegrasyonu ve kapsamlı API endpoint'leri ile sunulmaktadır.

![.NET Version](https://img.shields.io/badge/.NET-8.0-512bd4)
![License](https://img.shields.io/badge/license-MIT-green)

---

## ✨ Temel Özellikler

### 🔐 Güvenlik
- **JWT Authentication**: Güvenli token tabanlı kimlik doğrulama
- **Rate Limiting**: Login endpoint'i dakikada 10 istek, genel API dakikada 300 istek ile korunmaktadır
- **Password Hashing**: BCrypt kullanarak güvenli şifre depolama
- **CORS Support**: Geliştirme ve üretim ortamlarında yapılandırılabilir CORS politikası

### 👥 Personel Yönetimi
- Personel bilgileri yönetimi (kullanıcı, rol, departman)
- Vardiya görevlendirmesi ve takibi
- İzin taleplerinin incelenmesi ve onaylanması
- Devam durumu kaydı

### 📊 Raporlama ve İzleme
- Personel devam durumu raporları
- Vardiya geçmişi ve istatistikleri
- İzin kullanım raporları
- Health Check endpoint'leri

### 🖼️ Yüz Tanıma
- Yüz verileri yönetimi
- Devam takviyesi için yüz tanıma entegrasyonu

### 📝 Logging
- Serilog ile kapsamlı uygulama logging'i
- Günlük log dosyaları (14 gün tutma)
- Thread ID'si ile birlikte detaylı hata takibi

### 🏥 Health Checks
- `/health` endpoint'i ile uygulamanın ve veritabanının durumunu kontrol etme

---

## 🛠️ Teknoloji Stack

| Teknoloji | Versiyon | Amaç |
|-----------|----------|------|
| .NET | 8.0 | Framework |
| ASP.NET Core | 8.0.8 | Web Framework |
| Entity Framework Core | 8.0.8 | ORM |
| SQL Server | - | Veritabanı |
| JWT Bearer | 8.0.8 | Kimlik Doğrulama |
| BCrypt.Net-Next | 4.0.3 | Şifre Hashing |
| Serilog | 8.0.2 | Logging |
| Swagger/OpenAPI | 6.7.3 | API Dokümantasyonu |

---

## 📋 Gereksinimler

- **.NET 8.0** veya daha yenisi
- **SQL Server** (2016 veya daha yenisi)
- **Visual Studio 2022** (veya VS Code + .NET CLI)
- **.NET CLI** (isteğe bağlı)

---

## 🚀 Hızlı Başlangıç

### 1. Projeyi Klonlayın

```bash
git clone https://github.com/xBurak2/ShiftTrackingApp.git
cd ShiftTrackingApp
```

### 2. Bağlantı Dizesini Yapılandırın

`appsettings.json` dosyasında SQL Server bağlantı dizesini güncelleyin:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=ShiftTrackingDb;Trusted_Connection=true;Encrypt=false;"
  },
  "Jwt": {
    "Key": "your_secret_key_at_least_32_characters_long",
    "Issuer": "ShiftTrackingApp",
    "Audience": "ShiftTrackingAppUsers"
  },
  "Cors": {
    "AllowedOrigins": ["https://yourdomain.com"]
  }
}
```

### 3. Ortam Değişkenlerini Ayarlayın

JWT Key'i ortam değişkeni olarak ayarlayın (daha güvenli):

```bash
# Windows (PowerShell)
$env:JWT__Key = "your_secret_key_at_least_32_characters_long"

# Linux/Mac
export JWT__Key="your_secret_key_at_least_32_characters_long"
```

### 4. Veritabanı Migrasyonlarını Uygulayın

```bash
# Visual Studio Package Manager Console
Update-Database

# veya .NET CLI
dotnet ef database update
```

### 5. Projeyi Çalıştırın

```bash
dotnet run
```

Uygulamaya `https://localhost:7000` adresinden erişebilirsiniz.

### 6. Swagger API Dokümantasyonuna Erişin

Swagger UI'a `https://localhost:7000/swagger/index.html` adresinden erişin.

---

## 📚 API Endpoints

### Kimlik Doğrulama
- `POST /api/auth/register` - Yeni kullanıcı kaydı
- `POST /api/auth/login` - Giriş (rate limited: 10 req/min)
- `POST /api/auth/refresh` - Token yenileme

### Kullanıcılar
- `GET /api/users` - Tüm kullanıcıları listele
- `GET /api/users/{id}` - Kullanıcı detaylarını getir
- `PUT /api/users/{id}` - Kullanıcı güncelle
- `DELETE /api/users/{id}` - Kullanıcı sil

### Vardiyalar
- `GET /api/shifts` - Vardiyaları listele
- `POST /api/shifts` - Yeni vardiya oluştur
- `PUT /api/shifts/{id}` - Vardiya güncelle
- `DELETE /api/shifts/{id}` - Vardiya sil

### Vardiya Görevlendirmesi
- `GET /api/shifts/assignments` - Görevlendirmeleri listele
- `POST /api/shifts/assignments` - Görevlendirme oluştur
- `PUT /api/shifts/assignments/{id}` - Görevlendirme güncelle

### İzin
- `GET /api/leave` - İzin taleplerini listele
- `POST /api/leave/request` - İzin talebi oluştur
- `PUT /api/leave/{id}/approve` - İzni onayla
- `PUT /api/leave/{id}/reject` - İzni reddet

### Devam
- `GET /api/attendance` - Devam kayıtlarını listele
- `POST /api/attendance/check-in` - Giriş kaydı
- `POST /api/attendance/check-out` - Çıkış kaydı

### Departmanlar
- `GET /api/departments` - Departmanları listele
- `POST /api/departments` - Departman oluştur
- `PUT /api/departments/{id}` - Departman güncelle
- `DELETE /api/departments/{id}` - Departman sil

### Health Check
- `GET /health` - Sistem durumunu kontrol et

---

## 🏗️ Proje Yapısı

```
ShiftTrackingApp/
├── Controllers/           # API Controller'ları
├── Data/                  # Entity Framework DbContext
├── Models/                # Veri modelleri ve Entity'leri
├── Services/              # İş mantığı katmanı
│   └── Interfaces/        # Servis arayüzleri
├── Middleware/            # Özel middleware'ler (Exception Handler)
├── Migrations/            # EF Core migrasyonları
├── Helpers/               # Yardımcı sınıflar (JWT Helper vb.)
├── Logs/                  # Uygulama log dosyaları
├── Program.cs             # Uygulama başlangıç noktası
└── appsettings.json       # Yapılandırma dosyası
```

---

## 🔧 Konfigürasyon

### appsettings.json Örneği

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ShiftTrackingDb;Integrated Security=true;Encrypt=false;"
  },
  "Jwt": {
    "Key": "very_long_secret_key_at_least_32_characters_for_security",
    "Issuer": "ShiftTrackingApp",
    "Audience": "ShiftTrackingAppUsers",
    "ExpirationMinutes": 60
  },
  "Cors": {
    "AllowedOrigins": [
      "https://yourdomain.com",
      "https://app.yourdomain.com"
    ]
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning"
    }
  }
}
```

### Rate Limiting Konfigürasyonu

- **Login Endpoint** (`/api/auth/login`): Dakikada maksimum 10 istek
- **Genel API**: Dakikada maksimum 300 istek
- **Response**: 429 Too Many Requests (Çok fazla istek)

---

## 🧪 Testler

Proje unit test'leri içerir. Test'leri çalıştırmak için:

```bash
# Tüm testleri çalıştır
dotnet test

# Belirli test projesini çalıştır
dotnet test ShiftTrackingApp.Tests/ShiftTrackingApp.Tests.csproj

# Detaylı output ile testleri çalıştır
dotnet test --verbosity detailed
```

---

## 📊 Logging

Serilog kullanarak kapsamlı logging yapılmaktadır:

- **Console Output**: Gerçek zamanlı log mesajları
- **File Output**: `Logs/shiftex-{date}.log` dosyalarında günlük log saklanır
- **Retention**: Son 14 gün log tutulur
- **Log Level**: Information (varsayılan), Warning (Microsoft kütüphaneleri için)

Örnek log çıktısı:
```
[14:23:45 INF] Application started
[14:23:46 DBG] User login attempt for userId: 123
[14:23:47 INF] Database migration completed
```

---

## 🐛 Hata Ayıklama

### Sık Karşılaşılan Sorunlar

#### 1. "JWT Key bulunamadı" hatası
- `JWT__Key` ortam değişkenini veya `appsettings.json` içerisinde `Jwt:Key` alanını kontrol edin
- Key en az 32 karakter olmalıdır

#### 2. Veritabanı bağlantı hatası
- SQL Server'ın çalıştığını kontrol edin
- Connection string'i `appsettings.json` içerisinde doğru yapılandırın
- Veritabanı izinlerini kontrol edin

#### 3. CORS hatası
- Geliştirme ortamında localhost otomatik olarak izin verilir
- Üretim ortamında `appsettings.json` içerisinde `Cors:AllowedOrigins` yapılandırın

#### 4. Rate Limiting hatası (429)
- Belirtilen zaman aralığı geçene kadar bekleyin
- Loglara bakarak istek sayısını kontrol edin

---

## 📖 Ek Kaynaklar

- [.NET 8 Dokümantasyonu](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)
- [ASP.NET Core Güvenliği](https://learn.microsoft.com/en-us/aspnet/core/security/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [JWT Authentication](https://tools.ietf.org/html/rfc7519)
- [Serilog](https://serilog.net/)

---

## 🤝 Katkıda Bulunma

Projeye katkıda bulunmak istiyorsanız:

1. Projeyi fork edin
2. Bir feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Bir Pull Request açın

---

## 📝 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

---

## 📞 İletişim

- **Repository**: [https://github.com/xBurak2/ShiftTrackingApp](https://github.com/xBurak2/ShiftTrackingApp)
- **Issues**: GitHub Issues sekmesinde sorun bildirin
- **Discussions**: GitHub Discussions'da fikirlerinizi paylaşın

---

## 🎯 Roadmap

- [ ] Mobil uygulama (React Native/Flutter)
- [ ] İleri analitik ve raporlama
- [ ] Multi-tenant desteği
- [ ] Çok dilli arayüz
- [ ] Biometric entegrasyonları
- [ ] Microservices mimarısine geçiş

---

## 👨‍💻 Geliştirici

**Burak Demirkıran**
- GitHub: [@xBurak2](https://github.com/xBurak2)

---

**Son Güncellenme**: 2026
