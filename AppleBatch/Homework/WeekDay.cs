using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class WeekDay
    {
        static void Main(string[] args)
        {
            int weeknumber;

            
            Console.WriteLine("Enter week number from 1 to 7: ");
            weeknumber = Convert.ToInt32(Console.ReadLine());

            switch (weeknumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
            Console.ReadLine();

        }
    }
}
    

