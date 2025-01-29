# 📚 Kitap ve Yazar Yönetim Sistemi

Bu proje, bir kütüphane yönetim sistemi oluşturmayı amaçlamaktadır. Sistem, kitap ve yazar bilgilerini birbirine bağlayarak kullanıcıya kitapların başlıklarını ve yazarlarını listelemektedir.

## 🗂 Tablolar

### **1. Yazarlar Tablosu (Authors)**
| **Sütun Adı** | **Veri Tipi** | **Açıklama**              |
|---------------|---------------|--------------------------|
| AuthorId      | int           | Yazarın benzersiz kimliği |
| Name          | string        | Yazarın adı              |

### **2. Kitaplar Tablosu (Books)**
| **Sütun Adı** | **Veri Tipi** | **Açıklama**                   |
|---------------|---------------|---------------------------------|
| BookId        | int           | Kitabın benzersiz kimliği      |
| Title         | string        | Kitabın başlığı                |
| AuthorId      | int           | Kitabın yazarıyla ilişkilidir |

---

## 🛠 Özellikler
1. **Tablo Tanımları:**
   - `Authors` ve `Books` sınıfları, tablo yapılarına uygun olarak oluşturulmuştur.
   
2. **Veri Tanımları:**
   - `Authors` listesi, yazar bilgilerini içerir.
   - `Books` listesi, kitap bilgilerini içerir ve yazarlarla ilişkilendirilmiştir.

3. **LINQ Sorgusu:**
   - `Join` işlemi ile kitaplar ve yazarlar ilişkilendirilmiştir.
   - Her kitabın başlığı ve yazarı ekrana yazdırılmıştır.

---

## 💻 Koddan Örnek Çıktı

```plaintext
Kitap Adı: Bab-ı Esrar ---> Yazar Adı: Ahmet Ümit
Kitap Adı: İstanbul Hatırası ---> Yazar Adı: Ahmet Ümit
Kitap Adı: Aşk ---> Yazar Adı: Elif Şafak
Kitap Adı: Masumiyet Müzesi ---> Yazar Adı: Orhan Pamuk
