using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Mike"); // Create a book object! Instace of this class // Calling constructor method
            book1.title = "Harry Potter";
            book1.author = "J.K.Rowling";
            book1.pages = 347;

            Book book2 = new Book("John"); // Create a book object! Instace of this class
            book1.title = "The Lord of the rings";
            book1.author = "Tolkien";
            book1.pages = 1238;

            Console.WriteLine(book2.author);

            Console.ReadLine();
        }
    }
}
