using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
	class P37
	{
		static void Main(string[] args)
		{

			int a = 65;
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 5; j > i; j--)
				{
					Console.Write((char)(a) + " ");
				}
				for (int k = 1; k <= i; k++)
				{
					Console.Write((char)(a + i - 1) + " ");
				}
				Console.WriteLine();
			}
		}
	}
}