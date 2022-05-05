using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Class101
    {
        static void Main(string[] args)
        {


            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            while (b > 0)
            {
                result = result * a;
                --b;

            }
            Console.WriteLine(result);
        }
    }
}
