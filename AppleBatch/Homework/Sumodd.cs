using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
	class Sumodd
	{
		static void Main(string[] args)
		{

			int i, n, sumOdd = 0;
			Console.WriteLine("Enter the number :");

			n = Convert.ToInt32(Console.ReadLine());

			for (i = 1; i <= n; i++)
			{
				if (i % 2 != 0)
				{
					sumOdd += i;
				}


				Console.WriteLine("Total sum: " + sumOdd);
			}
		}
	}
}