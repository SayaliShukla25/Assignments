using System;
using System.Collections;
using System.Text;

namespace AccessModifier.Tprograms
{
    class Product : IComparer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public int Compare(object x, object y)
        {
            Product prod1 = (Product)x;
            Product prod2 = (Product)y;

            if (prod1.Price > prod2.Price)
                return 1;
            else
                return 0;

        }
    }
    class Prodtest
    {
        static void Main(string[] args)
        {
            Product p1 = new Product { ID = 1, Name = "Hp Laptop", Price = 37000 };
            Product p2 = new Product { ID = 2, Name = "Dell Laptop", Price = 35000 };

            Product test = new Product();
            int result = test.Compare(p1, p2);

           
            if (result == 1)
            {
                Console.WriteLine("hp laptop has more price than dell");

            }
            else
            {
                Console.WriteLine("dell laptop has more price than hp");
            }



        }
    }
}

        


