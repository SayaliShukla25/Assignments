using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Product
    {
        static void Main(string[] args)
        {
            int num, product = 1;
            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            
            while (num != 0)
            {
                product = product * (num % 10);

               
                num = num / 10;
            }

            Console.WriteLine("Product of digits = " + product);

            Console.ReadLine();
        }
    }
}
    

