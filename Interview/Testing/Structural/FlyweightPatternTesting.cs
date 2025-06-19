using Interview.Structural.Flyweight;
using Interview.Structural.Flyweight.Extrinsic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Structural
{
    public static class FlyweightPatternTesting 
    {
        public static void Run()
        {
            var bookFactory = new BookFactory();

            var bookType01 = bookFactory.GetBookType("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", "9780743273565", 1925, 180);
            var bookType02 = bookFactory.GetBookType("1984", "George Orwell", "Dystopian", "9780451524935", 1949, 328);
            var bookType03 = bookFactory.GetBookType("To Kill a Mockingbird", "Harper Lee", "Fiction", "9780061120084", 1960, 281);

            // book copies of type one
            var book01Copy01 = new Book(bookType01,10,35);
            var book01Copy02 = new Book(bookType01,18,30);

            // book new copy of type two
            var book02Copy01 = new Book(bookType02,15,40);

            // book copies of type two
            var book03Copy01 = new Book(bookType02, 20,36);


            Console.WriteLine($"[+] {book01Copy01}");
            Console.WriteLine($"[+] {book01Copy02}");
            Console.WriteLine($"[+] {book02Copy01}");
            Console.WriteLine($"[+] {book03Copy01}");
        } 
    }
}
