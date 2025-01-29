

using Linq_Join_Pratic;


List<Authors> authors = new List<Authors>   // Yazarlar listesi oluşturuldu
{
    new Authors { AuthorId = 1, Name = "Ahmet Ümit" },
    new Authors { AuthorId = 2, Name = "Elif Şafak" },
    new Authors { AuthorId = 3, Name = "Orhan Pamuk" }
};

List<Books> books = new List<Books>     // Kitaplar listesi oluşturuldu
{
    new Books { BookId = 1, Title = "Bab-ı Esrar", AuthorId = 1 },
    new Books { BookId = 2, Title = "İstanbul Hatırası", AuthorId = 1 },
    new Books { BookId = 3, Title = "Aşk", AuthorId = 2 },
    new Books { BookId = 4, Title = "Masumiyet Müzesi", AuthorId = 3 }
};

// LINQ ile kitaplar ve yazarlar listesi birleştirildi 

var bookAndAuthor = books.Join(authors,   // Birleştirilmek istenen ikinci liste 

                               book => book.AuthorId, // books listesindeki eşleştirme anahtarı
                               author => author.AuthorId, // authors listesindeki eşleştirme anahtarı
                               (book,author) => new   // Elde edilecek sonuç
                               {
                                   Title = book.Title, // Kitap başlığı
                                   AuthorName =author.Name, // Yazar adı
                               }
                           );

// Elde edilen sonuçlar ekrana yazdırılıyor

foreach ( var book in bookAndAuthor)
{
    Console.WriteLine("kitap adı: "+book.Title+" ------>"+" yazar adı: "+book.AuthorName);

}