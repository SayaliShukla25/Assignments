using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
	class P36
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 5; j > i; j--)
				{
					Console.Write(1 + " ");
				}
				for (int k = 1; k <= i; k++)
				{
					Console.Write(i + " ");
				}
				Console.WriteLine();
			}

		}
	}
}

