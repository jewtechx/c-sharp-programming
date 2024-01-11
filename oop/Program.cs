using System;

namespace Tutorials {
    class Program 
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("How to win and make friends","Dale Carnegie",356);
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.easyToRead());

            Book book2 = new Book("Diehard Desire","Dale Carnegie",356);
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.easyToRead());
            Console.WriteLine(book2.CopyRightKey);

            book2.CopyRightKey = "floreat123";
            Console.WriteLine(book2.CopyRightKey);
        }
    }
}