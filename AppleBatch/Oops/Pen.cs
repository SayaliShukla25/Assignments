using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Pen
    {
        string brand;
        string colour;
        int price;
        public Pen()
        {
            Console.WriteLine(" pen default constructor");
        }
        public void SetBrand(string br)
        {
            brand = br;
        }
        public string GetBrand()
        {
            return brand;
        }

        public void SetColour(string cr)
        {
            colour = cr;
        }
        public string GetColour()
        {
            return colour;
        }

        public void SetPrice(int pr)
        {
            price = pr;
        }
        public int GetPrice()
        {
            return price;
        }


        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            Console.WriteLine("enter brand,colour,price");

            string br = Console.ReadLine();

            p1.SetBrand(br);

            string cr = Console.ReadLine();
            p1.SetColour(cr);

            int pr = Convert.ToInt32(Console.ReadLine());
            p1.SetPrice(pr);

            Console.WriteLine(p1.GetBrand());
            Console.WriteLine(p1.GetColour());
            Console.WriteLine(p1.GetPrice());

            


        }
    }
}