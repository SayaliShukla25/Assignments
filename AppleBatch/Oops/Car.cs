using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Car
    {
        string model ;
        int price;
        string colour;
        long number;

        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.model = "tata";
            c1.price = 800000;
            c1.colour = "Black";
            c1.number = 7885;
            
            Car c2 = new Car();
            c2.model = "Maruti";
            c2.price = 700000;
            c2.colour = "Black";
            c2.number = 7885;

            Console.WriteLine($"name={c1.model} ");

        }
    }
}
