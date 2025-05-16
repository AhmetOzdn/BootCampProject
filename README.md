
## 📌 1. Task, async, await Nedir?

### ✅ Task

`.NET`’te **asenkron işlemleri temsil eden** bir sınıftır. Genellikle uzun süren IO işlemlerinde (veritabanı, API çağrısı, dosya erişimi vb.) kullanılır.

### ✅ async

Bir metodun **asenkron çalışacağını** belirtmek için kullanılan anahtar kelimedir. Bu metodun içinde `await` ifadesi bulunabilir.

### ✅ await

Bir `Task`’in tamamlanmasını **beklemek** için kullanılır. Ancak bu bekleme, ilgili **iş parçacığını (thread) bloke etmez**, dolayısıyla sistem kaynakları daha verimli kullanılır.



### 📌 2. Request-Response Pattern Nedir?

### 📚 REPR Deseni Nedir?
REPR (Request, Endpoint, Response) tasarım deseni, web API uç noktalarını üç temel bileşene ayırarak tanımlar:

- **Request (İstek)** → Uç noktanın beklediği veri modelini temsil eder.
- **Endpoint (Uç Nokta)** → Gelen isteğe göre çalıştırılacak iş mantığını içerir.
- **Response (Yanıt)** → Uç noktanın istemciye döndürdüğü veri modelidir.

Bu desen, REST API geliştirme sürecini basitleştirerek uç noktaların daha modüler ve yönetilebilir olmasını sağlar. Ayrıca, Tek Sorumluluk İlkesi’ni (Single Responsibility Principle — SRP) uygulayarak her bileşenin belirli bir göreve odaklanmasını sağlar.

---

### 🎯 Neden REPR Deseni?
- **Daha küçük ve odaklanmış bileşenler:** Her uç nokta tek bir sorumluluğa sahip olur.
- **Bakımı ve ölçeklendirmesi kolay:** Büyük, karmaşık controller’lar yerine küçük ve bağımsız bileşenlerle çalışılır.
- **Daha kolay test edilebilir:** Ayrıştırılmış yapı, testlerin daha net ve kolay olmasını sağlar.
- **Daha az değişiklik, daha az hata riski:** Yeni ActionMethod eklemeye gerek kalmadan, uç noktalar daha stabil olur. Dosya değişiklikleri azaldıkça, hata yapma olasılığı da azalır.



---

# ✅ Global Exception Handling (Mayıs-1 Araştırma Ödevi)

## 📌 1. Global Exception Handler Nedir ve Neden Kullanılır?
- Uygulama genelinde oluşabilecek tüm hataları **tek noktadan** yakalayıp yönetmeyi sağlar.
- **Loglama**, kullanıcıya özel hata mesajı döndürme ve sistemin çökmesini engelleme amacıyla kullanılır.

## 🧱 2. Middleware Üzerinden Hata Yönetimi Nasıl Yapılır?
- `app.UseMiddleware<ExceptionMiddleware>();` şeklinde özel bir middleware yazılarak gerçekleştirilir.
- Her yere `try-catch` yazmak yerine merkezi bir yapı ile hata yönetimi sağlanır.

## ⚙️ 3. .NET Core’da Global Exception Handling için Kullanılan Yapılar
- `IMiddleware`
- `RequestDelegate`
- `HttpContext`
- `ILogger`
- `ProblemDetails` (standart hata çıktısı için)

## 🚨 4. BusinessException Gibi Özel Sınıflar Nasıl Yönetilir?
- `BusinessException : Exception` şeklinde tanımlanır.
- Middleware içerisinde `catch (BusinessException ex)` ile ayrıştırılarak özel mesajlar döndürülebilir.
- Kullanıcıya anlamlı ve sade hata bilgisi sunmak için kullanılır.

---

# 🧭 Clean Architecture – Onion Architecture – CQRS Karşılaştırması

| Mimari | Tanım | Katmanlar | Avantajları | Zorlukları | Kullanım Alanı |
|--------|-------|-----------|-------------|------------|----------------|
| **Clean Architecture** | Bağımlılıklar dışa yöneliktir (Dependency Rule). | Entities → UseCases → Interfaces → UI | Test edilebilirlik, katı yapı | Başlangıçta karmaşık olabilir | Orta ve büyük projeler |
| **Onion Architecture** | Katmanlar soğan halkası gibi iç içedir, merkezde domain vardır. | Domain → Application → Infrastructure → UI | Domain merkezli, loosely coupled | Öğrenme eğrisi yüksek | Kurumsal sistemlerde tercih edilir |
| **CQRS** | Komut (write) ve sorgu (read) işlemleri ayrı yapılır. | Command & Query ayrıdır | Performans, ölçeklenebilirlik | Kod karmaşası artabilir | E-ticaret, yoğun veri sistemleri |

## 🎯 Farklılıklar ve Benzerlikler

| Özellik | Clean Architecture | Onion Architecture | CQRS |
|--------|---------------------|--------------------|------|
| Katmanlı yapı | ✅ | ✅ | ❌ |
| Domain Driven Design uyumu | ✅ | ✅ | ❌ (isteğe bağlı) |
| İş kurallarına odak | ✅ | ✅ | ✅ |
| Okuma ve yazma ayrımı | ❌ | ❌ | ✅ |
| Uygulama alanı | SaaS, ERP sistemleri | Kurumsal uygulamalar | Raporlama, veri odaklı sistemler |





