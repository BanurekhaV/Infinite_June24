using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Models;

namespace CodeFirst
{
    class Program
    {
        static BooksDBContext db = new BooksDBContext();

        public static void ShowAllBooks()
        {
            var bk = from b in db.book
                       select b;

            foreach(var item in bk)
            {
                Console.WriteLine(item.BookId + " " + item.BookName + " "+ item.Price + " " + item.YearPublished);
            }
        }

        public static void AddBooks()
        {
            Books b = new Books();
            Console.WriteLine("Enter Books Details");
            b.BookId = Convert.ToInt32(Console.ReadLine());
            b.BookName = Console.ReadLine();
            b.Price = Convert.ToDouble(Console.ReadLine());
            b.YearPublished = Convert.ToDateTime(Console.ReadLine());
            db.book.Add(b);
            db.SaveChanges();

        }
        static void Main(string[] args)
        {
            AddBooks();
            ShowAllBooks();
            Console.ReadKey();
        }
    }
}
