using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Prop
{
    class Stock1
    {

        float openingprice;
        float closingprice;
        string stockname;
        public Stock1()
        {
            Console.WriteLine("in stock default constructor");
        }
        public float Openingprice
        {
            get { return openingprice; }
            set { openingprice= value; }
        }
        public float Closingprice
        {
            get { return closingprice; }
            set { closingprice= value; }

        }
        public string Stockname
        {
            get { return stockname; }
            set { stockname = value; }

        }


        static void Main(string[] args)
        {
            Stock1 s= new Stock1();
            s.Openingprice = 4.5F;
            s.Closingprice = 3.5F;
            s.Stockname = "WIPRO";


            Console.WriteLine(s.Openingprice);
            Console.WriteLine(s.Closingprice);
            Console.WriteLine(s.Stockname);

        }

    }
}


