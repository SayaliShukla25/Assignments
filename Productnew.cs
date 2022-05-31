using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AccessModifier.Tprograms
{
    class Productnew
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int Price { get; set; }

    }

    class Protest
    {
        static void Main(string[] args)
        {
            List<Productnew> productlist = new List<Productnew>()
                {
                 new Productnew { Id = 2, Name = "Dell Laptop", Price = 35000 },
                 new Productnew { Id = 2, Name = "LENOVO  Laptop", Price = 36000 },
                 new Productnew { Id = 2, Name = "hp  Laptop", Price = 38000 },
                 };
            var result1 = from p in productlist
                          where p.Price < 35000
                          orderby p.Price
                          select p;
            foreach(Productnew p in result1)
            {
                Console.WriteLine($"{p.Name}{p.Price}");
            }

        }
        }
}
