using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class krishnamurthy
    {
        public static bool IsKrishnamurthy(int number)
        {
            
            int sum = 0, lastDigit = 0;
            int tempNum = number;
            
            while (tempNum != 0)
            {
                lastDigit = tempNum % 10;
                sum += Convert.ToInt32(Factorial(lastDigit));
                tempNum /= 10;
            }

             
            if (sum == number)
                return true;
            return false;
        }
       
        public static long Factorial(int number)
        {
            long fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
        
        public static void Main()
        {
             
            Console.WriteLine("Enter an integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            
            bool result = IsKrishnamurthy(number);
            if (result)
                Console.WriteLine(number + " Is a Krishnamurthy Number.");
            else
                Console.WriteLine(number + " Is not a Krishnamurthy Number.");
            Console.ReadLine();
        }
    }
}

