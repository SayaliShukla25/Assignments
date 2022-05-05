using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class NumWord
    {
        static void Main(string[] args)
        {
            int n, num = 0;

            // Reading a number from user
            Console.WriteLine("Enter number from 1 to 5: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                num = (num * 5) + (n % 5);
                n /= 5;
            }

            //print corresponding digit in words till num becomes 0
            while (num != 0)
            {
                switch (num % 5)
                {
                    
                   case 1:
                        Console.WriteLine("one ");
                        break;
                    case 2:
                        Console.WriteLine("two ");
                        break;
                    case 3:
                        Console.WriteLine("three ");
                        break;
                    case 4:
                        Console.WriteLine("four ");
                        break;
                    case 5:
                        Console.WriteLine("five ");
                        break;
                }
                num = num / 5;



            }
            Console.ReadLine();
        }
    }
}
    

