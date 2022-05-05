using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Prop
{
    class Pen1
    {
        
        string brand;
        string colour;
        int price;
        public Pen1()
        {
            Console.WriteLine("in pen default constructor");
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }

        }
        public int Price
        {
            get { return price; }
            set { price = value; }

        }


        static void Main(string[] args)
        {
            Pen1 c = new Pen1();
            c.Brand = "trimax";
            c.Colour = "blue";
            c.Price = 15;


            Console.WriteLine(c.Brand);
            Console.WriteLine(c.Colour);
            Console.WriteLine(c.Price);

        }

    }
}
