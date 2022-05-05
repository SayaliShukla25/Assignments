using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Table
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the Number :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", num, i, num * i);
            }
        }
    }
}
        
   
