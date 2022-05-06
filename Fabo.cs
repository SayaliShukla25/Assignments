using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Fabo
    {
        static void Main(string[] args)
        {


            int num1 = 0, num2 = 1, num3, number;
            
            Console.WriteLine("Enter number : ");
            
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");

            for (int i = 2; i < number; ++i)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}


