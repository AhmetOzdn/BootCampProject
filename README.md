
## 📌 1. Task, async, await Nedir?

### ✅ Task

`.NET`’te **asenkron işlemleri temsil eden** bir sınıftır. Genellikle uzun süren IO işlemlerinde (veritabanı, API çağrısı, dosya erişimi vb.) kullanılır.

### ✅ async

Bir metodun **asenkron çalışacağını** belirtmek için kullanılan anahtar kelimedir. Bu metodun içinde `await` ifadesi bulunabilir.

### ✅ await

Bir `Task`’in tamamlanmasını **beklemek** için kullanılır. Ancak bu bekleme, ilgili **iş parçacığını (thread) bloke etmez**, dolayısıyla sistem kaynakları daha verimli kullanılır.



### 📌 2.Request-Response Pattern Nedir?
Request-Response Pattern, istemci (client) ile sunucu (server) arasında eşleşmiş iletişimi tanımlayan temel bir yazılım mimarisi desenidir.

### ✅ Client (istemci)
Bir request (örn. HTTP GET) gönderir.

### ✅ Server (sunucu)
Bu isteği işler ve bir response ile cevap verir.
Bu desen sayesinde istemci ne istediğini net olarak ifade eder, sunucu da buna karşılık organize bir cevap döner. Özellikle RESTful API yapılarında yaygın olarak kullanılır.

### 🌐 Kullanım Alanı
  Web API'ler
  Mikroservis mimarileri
  HTTP tabanlı tüm istemci-sunucu iletişimleri

  



