using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
using Newtonsoft.Json;
using System.IO;


namespace MyLibrary
{
    class Program
    {
        static public int choice = 0;
        static public char Repeat;

        static void Main(string[] args)

        {
            int choice = 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(120, 40);
            Console.WriteLine("===================================");
            Console.WriteLine("| 1 - Add Book                    |");
            Console.WriteLine("| 2 - Search                      |");
            Console.WriteLine("| 3 - Delete Book                 |");
            Console.WriteLine("| 4 - Close                       |");
            Console.WriteLine("===================================");

            choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        do
                        {
                            List<Book> bookList;
                            string str = String.Empty;
                            using(StreamReader sr = File.OpenText(@"library.txt"))
                            {
                                str = sr.ReadToEnd();
                            }
                            bookList = JsonConvert.DeserializeObject<List<Book>>(str);
                            var book = new Book();
                            Console.WriteLine("Enter the name of the book, author, genre, release year and weight");
                            Console.WriteLine("     ");
                            Console.WriteLine("Enter name:");
                            book.Name = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter author:");
                            book.Author = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter genre:");
                            Genres bGenre;
                            Enum.TryParse<Genres>(Console.ReadLine(), out bGenre);
                            book.Genre = bGenre;
                            Console.WriteLine("Enter release year:");
                            book.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter weight:");
                            book.Weight = Convert.ToInt32(Console.ReadLine());

                            if(bookList == null)
                                bookList = new List<Book>();

                            bookList.Add(book);

                            var ootputStr = JsonConvert.SerializeObject(bookList);

                            File.WriteAllText(@"library.txt", ootputStr);
                            
                            Console.WriteLine("\nRefresh?(y/n)");
                            Repeat = Convert.ToChar(Console.ReadLine());
                        }
                        while (Repeat == 'y' || Repeat == 'Y');
                        break;
                    }

                case 2:
                    {
                        do
                        {
                            

                        }
                        while (Repeat == 'y' || Repeat == 'Y');

                        break;
                    }

                case 3:
                    {
                        do
                        {

                        }
                        while (Repeat == 'y' || Repeat == 'Y');
                        break;
                    }

                case 4:
                    {
                        break;
                    }
            }
        }
    }
}
