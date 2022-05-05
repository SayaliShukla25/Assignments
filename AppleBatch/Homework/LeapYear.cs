using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            
            Console.WriteLine("Enter a Year  : ");
            year = Convert.ToInt32(Console.ReadLine());

           if((year % 4) == 0)
                Console.WriteLine(" is a leap year.\n", year);
            else
                Console.WriteLine(" is not a leap year.\n", year);
        }
    }
}
    

