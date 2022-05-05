using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class fac35
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("divided by 3: ");
            for (i = 1; i < 100; i++)
            {

                if (i % 3 == 0)
                    Console.Write("Red ");
            }

            Console.WriteLine("divided by 5: ");
            for (i = 1; i < 100; i++)
            {

                if (i % 5 == 0)
                    Console.Write("Blue ");
            }

            Console.WriteLine("divided by 3 & 5: ");
            for (i = 1; i < 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("Redblue");
            }
            Console.WriteLine("\n");


        }
    }
}
        
    

