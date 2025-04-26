
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

  



