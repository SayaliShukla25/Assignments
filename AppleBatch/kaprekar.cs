using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class kaprekar
    {
        static void Main(string[] args)
        {

            int num, temp, sqr, sum = 0, a = 0, b = 0, c = 1;
            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            sqr = num * num;
            temp = num;
            while (temp != 0)
            {
                c = c * 10;
                temp = temp / 10;
            }
            a = sqr % c;
            b = sqr / c;
            sum = a + b;

            if (sum == num)
                Console.WriteLine("number is kaprekar number");
            else
                Console.WriteLine("number is not kaprikar number");
        }
    }
}





