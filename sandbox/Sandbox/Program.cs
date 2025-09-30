using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Brigham", "234");
            string name = student.GetName();
            string number = student.GetNumber();
            Console.WriteLine(name);
            Console.WriteLine(number);

            Book book1 = new Book();
            book1.SetAuthor("Smith");
            book1.SetTitle("A Great Book");

            Console.WriteLine(book1.GetBookInfo());

            PictureBook book2 = new PictureBook();
            book2.SetAuthor("Jones");
            book2.SetTitle("A Wonderful Picture Book");
            book2.SetIllustrator("Burton");

            Console.WriteLine(book2.GetBookInfo());

            Book book3 = new Book();
            Console.WriteLine(book3.GetBookInfo());
        }
    }
}