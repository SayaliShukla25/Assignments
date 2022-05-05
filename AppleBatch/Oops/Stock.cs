using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Stock
    {
        float openingprice;
        float closingprice;
        string stockname;

        public void SetOpeningprice(float price )
        {
            openingprice = price;
        }
        public float GetOpeningprice()
        {
            return openingprice;
        }

        public void SetClosingprice(float pr)
        {
            closingprice = pr;
        }
        public float GetClosingprice()
        {
            return closingprice;
        }

        public void SetStockname(string name)
        {
            stockname = name;
        }
        public string GetStockname()
        {
            return stockname;
        }
        static void Main(string[] args)
        {
            Stock s1= new Stock();
            Console.WriteLine("Openingprice,closingprice,stockname");

              float price = float.Parse(Console.ReadLine());
              s1.SetOpeningprice(price);

              float pr = float.Parse(Console.ReadLine());
              s1.SetClosingprice(pr);

              string name=Console.ReadLine();
              s1.SetStockname(name);

            Console.WriteLine(s1.GetOpeningprice());
            Console.WriteLine(s1.GetClosingprice());
            Console.WriteLine(s1.GetStockname());


        }

    }
}
