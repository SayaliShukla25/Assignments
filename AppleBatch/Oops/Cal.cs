using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Cal
    {
        void add(int a, int b)
        {
            Console.WriteLine("Sum=" + (a + b));
        }

        void add(double a, double b)
        {
            Console.WriteLine("Sum=" + (a + b));
        }

        void add(int a, float b)
        {
            Console.WriteLine("Sum=" + (a + b));
        }

        void add(int a, int b,int c)
        {
            Console.WriteLine("Sum=" + (a + b + c));
        }

        static void Main(string[] args)
        {
            Cal c1 = new Cal();
            c1.add(4, 5);
            c1.add(2.5, 2.5);
            c1.add(4, 3.5);
            c1.add(8, 22, 89);

        }
    }
}
