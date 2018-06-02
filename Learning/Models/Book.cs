using System.Collections.Generic;

namespace Learning.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>
            {
                new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "ms-appx:///Assets/1.png" },
                new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "ms-appx:///Assets/2.png" },
                new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "ms-appx:///Assets/3.png" },
                new Book { BookId = 4, Title = "Etiam", Author = "Option", CoverImage = "ms-appx:///Assets/4.png" },
                new Book { BookId = 5, Title = "Feugait Eros Libex", Author = "Accumsan", CoverImage = "ms-appx:///Assets/5.png" },
                new Book { BookId = 6, Title = "Nonummy Erat", Author = "Legunt Xaepius", CoverImage = "ms-appx:///Assets/6.png" },
                new Book { BookId = 7, Title = "Nostrud", Author = "Eleifend", CoverImage = "ms-appx:///Assets/7.png" },
                new Book { BookId = 8, Title = "Per Modo", Author = "Vero Tation", CoverImage = "ms-appx:///Assets/8.png" },
                new Book { BookId = 9, Title = "Suscipit Ad", Author = "Jack Tibbles", CoverImage = "ms-appx:///Assets/9.png" },
                new Book { BookId = 10, Title = "Decima", Author = "Tuffy Tibbles", CoverImage = "ms-appx:///Assets/10.png" },
                new Book { BookId = 11, Title = "Erat", Author = "Volupat", CoverImage = "ms-appx:///Assets/11.png" },
                new Book { BookId = 12, Title = "Consequat", Author = "Est Possim", CoverImage = "ms-appx:///Assets/12.png" },
                new Book { BookId = 13, Title = "Aliquip", Author = "Magna", CoverImage = "ms-appx:///Assets/13.png" }
            };

            return books;
        }
    }
}
