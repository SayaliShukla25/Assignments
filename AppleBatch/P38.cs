using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class P38
    {
        static void Main(string[] args)
        {
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 5; j > i; j--)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= i; k++)
				{
					Console.Write(k + " ");
				}
				Console.WriteLine();
			}
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= 5- i; k++)
				{
					Console.Write(k + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
    

