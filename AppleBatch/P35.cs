using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
	class P35
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 1; j < i; j++)
				{
					Console.Write("0 ");
				}
				Console.Write(i + " ");
				for (int k = i; k < 5; k++)
				{
					Console.Write("0 ");
				}
				Console.WriteLine();
			}
		}
	}
}
	

    

