using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Program2
    {
        static void Main(string[] args)
        {

            int num, n, temp, r;
          
            for (num = 100; num <= 500; num++)
            {
                temp = 0;
                n = num;
                while (n != 0)
                {
                    r = n % 10;
                    temp = temp * 10 + r;
                    n = n / 10;
                }
                if (num == temp)
                    Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}

