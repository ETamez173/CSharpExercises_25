using System;

namespace CSharpExercises_25
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object - instance of the class

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord Of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;



            Console.WriteLine("Title is " + book1.title);
            Console.WriteLine("Author is " + book1.author);
            Console.WriteLine("Pages in book is "  + book1.pages);

            Console.WriteLine("Title is " + book2.title);
            Console.WriteLine("Author is " + book2.author);
            Console.WriteLine("Pages in book is " + book2.pages);

            Console.ReadLine();
        }
    }
}
