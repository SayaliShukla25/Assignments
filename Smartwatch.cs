using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.inherit
{
    class Smartwatch
    {
        string brand = "mi";
        readonly int cost = 3000;
        const int x = 90;
        public Smartwatch ()
        {
           
        }

        public string Brand { get => brand; set => brand = value; }

        public int Cost => cost;

        public Smartwatch(string brand, int cost)
        {
            this.Brand = brand;
            this.cost = cost;
        }

        public override string ToString()
        {
            return $"Smartwatch Brand ={brand} Cost={cost} ";

        }
        static void Main(string[] args)
        {
            Smartwatch w1 = new Smartwatch("Apple", 90000);
            Console.WriteLine(w1);
        }

    }
}

            
           
        
    

        
