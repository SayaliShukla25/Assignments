using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
	class Search
	{
		static void Main(string[] args)
		{
		

			int i, n, f = 0;
			int[] arr = new int[5];

			Console.Write("Enter five elements:");
			for (i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.Write("Enter a number for search:");
			n = Convert.ToInt32(Console.ReadLine());

			for (i = 0; i < 5; i++)
			{
				if (arr[i] == n)
				{
					f = 1;
				}
			}

			if (f == 1)
			{
				Console.WriteLine("Number found:" + n);
			}
			else
			{
				Console.WriteLine("Number not found:" + n);
			}
		}
	}
}