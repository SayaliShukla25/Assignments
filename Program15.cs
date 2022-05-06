using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ExepHandling
{
    class Program15
    {
        static string s;
        static void Main(string[] args)

        {

            Console.WriteLine("main strarts");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division="+a/b);
                Console.WriteLine("TRY ENDS");
                Console.WriteLine(s.ToLower());
                Console.WriteLine("sayali"[7]);

            }
            catch(FormatException obj)
            {
                Console.WriteLine("Please enter number");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divisor Cant be zero");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
            }

            for(int i=1;i<=10;i++)
                Console.WriteLine("WELCOME");
        }
    }
}
