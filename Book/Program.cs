using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book boek1 = new Book();
            boek1.Title = "The Shining";
            boek1.Author = "Stephen King";
            boek1.ISBN = 05848152;
            boek1.Price = 25;
            Book boek2 = new Book();
            boek2.Title = "The Haunting of Hill House";
            boek2.Author = "Shirley Jackson";
            boek2.ISBN = 05848153;
            boek2.Price = 20;
            TextBook tb = new TextBook();
            tb.Title = "Zie Scherp";
            tb.Author = "Tim Dams";
            tb.ISBN = 03449664;
            tb.Price = 15;
            tb.GradeLevel = 4;
            CoffeeTableBook ctb = new CoffeeTableBook();
            ctb.Title = "Vlaamse Primitieven";
            ctb.Author = "Johannes De Meester";
            ctb.ISBN = 01134685;
            ctb.Price = 85;

            Book omnibus = boek1 + boek2;
            Console.WriteLine(omnibus);
            Console.WriteLine(tb);
            Console.WriteLine(ctb);
            Console.WriteLine(tb.Equals(ctb));


            Console.ReadLine();
        }
    }
}
