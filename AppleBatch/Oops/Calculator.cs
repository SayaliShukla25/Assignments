using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Calculator
    {
        public void add(int a, int b,int c)
        {
            c = a + b+c;
            Console.WriteLine("Sum="+c);
           
            
        }
        public int factorial(int n)
        {
            int i, fact = 1;
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public bool isprime(int n)
        {
            int flag = 0, i;

            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                return true;
            else
                return false;
        }

        public string greet(String nm)
        {
            return "Good Afternoon" + nm;
        }
    

        static void Main(string[] args)
        {
        Calculator c = new Calculator();
        c.add(29,30,5);
        int result = c.factorial(8);
        Console.WriteLine(result);
        c.isprime(4);
        c.ToString();
        }
    }
}
