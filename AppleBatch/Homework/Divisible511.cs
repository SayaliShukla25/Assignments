using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Divisible511
    {
        static void Main(string[] args)
        {

        
		int number;


            Console.WriteLine(" Enter any Number  : ");
		number = Convert.ToInt32(Console.ReadLine());

			if ((number % 5 == 0) && (number % 11 == 0))
		{
				Console.WriteLine("\n Given number " + number + " is Divisible by 5 and 11");
	}
		else
		{
				Console.WriteLine("\n Given number " + number + " is Not Divisible by 5 and 11");
}	
	}
}
    }

