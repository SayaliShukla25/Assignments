using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Digit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 digit number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num>=100  &&  num<=999)
            {
                Console.WriteLine("given number is 3 digit number  ");
               int a= num % 10;
               int b = num / 100;

                Console.WriteLine("a+b");


            }
            else
            {
                Console.WriteLine(" please enter 3   digit number  ");

            }
        }
    }
}
