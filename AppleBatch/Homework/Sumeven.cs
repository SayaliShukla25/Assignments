using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
	class Sumeven
	{
		static void Main(string[] args)
		{
			int i, num, sum = 0;
			Console.WriteLine("Enter a number :");

			num = Convert.ToInt32(Console.ReadLine());

			for (i = 2; i <= num; i++)
			{
				if (i % 2 == 0)
				{
					sum += i;
				}
			}

			Console.WriteLine("Total sum of all even numbers less than " + num + " is: " + sum);
		}
	}

}	