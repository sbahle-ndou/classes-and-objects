using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

            book1.title = "Harr Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}
