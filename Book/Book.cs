using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        private double price;
        public virtual double Price
        {
            get { return price; }
            set { price = value; }
        }
        public static Book operator +(Book a, Book b)
        {
            Book omnibus = new Book();
            omnibus.ISBN = a.ISBN + b.ISBN;
            omnibus.Price = (a.Price + b.Price) / 2;
            omnibus.Title = $"Omnibus van [{a.Author}, {b.Author}]";
            return omnibus;
        }
        public override string ToString()
        {
            return $"{Title} - {Author} ({ISBN}) {Price}";
        }
        public override bool Equals(object obj)
        {
            Book temp = (Book)obj;
            return (ISBN == temp.ISBN);
        }
        public override int GetHashCode()
        {
            return ISBN;
        }

    }
    class TextBook : Book
    {
        public int GradeLevel { get; set; }
        public override double Price
        {
            get { return base.Price; }
            set
            {
                if (value >= 20 && value <= 80)
                    base.Price = value;
                else
                    base.Price = 0;
            }
        }
        public override string ToString()
        {
            return $"{Title} - {Author} ({ISBN}) (Grade Level {GradeLevel} {Price}";
        }

    }
    class CoffeeTableBook : Book
    {
        public override double Price
        {
            get { return base.Price; }
            set
            {
                if (value >= 35 && value <= 100)
                    base.Price = value;
                else
                    base.Price = 0;
            }
        }
    }
}
}
