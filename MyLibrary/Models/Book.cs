using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Models
{

    public class Book
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public Genres Genre { get; set; }

        public int ReleaseYear { get; set; }

        public int Weight { get; set; }

        public Book()
        {

        }

        public Book(string name, string author, Genres genre, int releaseYear, int weight)
        {
            this.Name = name;
            this.Author = Author;
            this.Genre = Genre;
            this.ReleaseYear = ReleaseYear;
            this.Weight = Weight;

        }




    }
}




public enum Genres : int
{
    /// <summary>
    /// Детективные произведения
    /// </summary>
    Detective = 0,
    /// <summary>
    /// Драма
    /// </summary>
    Drama = 1,
    /// <summary>
    /// Поэзия
    /// </summary>
    Poetry = 2,
    /// <summary>
    /// Фентези
    /// </summary>
    Fantasy = 3,
    /// <summary>
    /// Комедия
    /// </summary>
    Humor = 4,
    /// <summary>
    /// Басня
    /// </summary>
    Fable = 5,
    /// <summary>
    /// Мифология
    /// </summary>
    Mythology = 6,
    /// <summary>
    /// Биография
    /// </summary>
    Biography = 7,
    /// <summary>
    /// Роман
    /// </summary>
    Novel = 8,
    /// <summary>
    /// Реализм
    /// </summary>
    Realism = 9,
    /// <summary>
    /// Философия
    /// </summary>
    Philosophy = 10,


}

