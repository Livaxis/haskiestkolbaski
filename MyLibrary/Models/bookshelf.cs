using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    class bookshelf
    {
        public List<Book> bookcase = new List<Book>();
        Book mt = new Book("Mtsyri", "Mikhail Yurjevich Lermontov", Genres.Poetry, 1839, 402);
        Book he = new Book()
        {
            Name = "Heroes of our time",
            Author = "Mikhail Yurjevich Lermontov",
            Genre = Genres.Realism,
            ReleaseYear = 1840,
            Weight = 376
        };
        Book bo = new Book
        {
            Name = "Borodino",
            Author = "Mikhail Yurjevich Lermontov",
            Genre = Genres.Poetry,
            ReleaseYear = 1837,
            Weight = 298
        };

        Book sh = new Book
        {
            Name = "The Complete Sherlock Holmes",
            Author = "Arthur Conan Doyle",
            Genre = Genres.Detective,
            ReleaseYear = 1887,
            Weight = 720
        };

        Book mi = new Book
        {
            Name = "Misery",
            Author = "Stephen King",
            Genre = Genres.Detective,
            ReleaseYear = 1987,
            Weight = 593
        };

        Book ta = new Book
        {
            Name = "Tales of Mystery and Imagination",
            Author = "Edgar Allan Poe",
            Genre = Genres.Detective,
            ReleaseYear = 1852,
            Weight = 583
        };

        Book my = new Book
        {
            Name = "The Mysterious Affair at Styles",
            Author = "Agatha Christie",
            Genre = Genres.Detective,
            ReleaseYear = 1920,
            Weight = 523
        };

        Book cr = new Book
        {
            Name = "Criticism of pure reason",
            Author = "Immanuel Kant",
            Genre = Genres.Philosophy,
            ReleaseYear = 1781,
            Weight = 488
        };

        Book so = new Book
        {
            Name = "So spoke Zarathustra",
            Author = "Friedrich Nietzsche",
            Genre = Genres.Philosophy,
            ReleaseYear = 1891,
            Weight = 607
        };

        Book pr = new Book
        {
            Name = "The Prince",
            Author = "Niccolo Machiavelli",
            Genre = Genres.Philosophy,
            Weight = 710
        };

        Book re = new Book
        {
            Name = "The Republic",
            Author = "Plato",
            Genre = Genres.Philosophy,
            ReleaseYear = 360,
            Weight = 589
        };

        Book don = new Book
        {
            Name = "Don Quixote",
            Author = "Miguel de Cervantes",
            Genre = Genres.Novel,
            ReleaseYear = 1615,
            Weight = 723
        };

        //BOOL true-false

        public bool Add(Book newbook)
        {
            //Проверка есть ли книга
            if(bookcase.Contains(newbook))
            {
                return false;
            }
            else
            {
                bookcase.Add(newbook);
                return true;
            }
        }
    }
}
