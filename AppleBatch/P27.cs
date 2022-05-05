using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class P27
    {
        static void Main(string[] args)
        {

			for (int i = 1; i <= 5; i++)
			{
				for (int j = 5; j > i; j--)
				{
					Console.Write("  ");
				}
				for (int k = 1; k <= i; k++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}

			for (int i = 1; i <= 5 - 1; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(" ");
				}
				for (int k = 5 - 1; k >= i; k--)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}
	}
}
    

