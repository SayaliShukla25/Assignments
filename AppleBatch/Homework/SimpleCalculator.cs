using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Calculator");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice(1-4):");
            int ch =Convert.ToChar(Console.ReadLine());
            
            if (ch == 1)
            {
                Console.WriteLine("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine("Sum = "+ c);
            }
            else if (ch == 2)
            {
                Console.WriteLine("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a - b;
                Console.WriteLine("Difference ="+ c);
            }
            else if (ch == 3)
            {
                Console.WriteLine("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a * b;
                Console.WriteLine("Product = "+ c);
            }
            else if (ch == 4)
            {
                Console.WriteLine("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Quotient = " +c);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.ReadKey();
        }
    }
}

