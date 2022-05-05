using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
	class P39
	{
		static void Main(string[] args)
		{
			
			
				int a = 65;
				for (int i = 1; i <= 5; i++)
				{
					for (int j = 5; j >= i; j--)
					{
						Console.Write(" ");
					}
					for (int k = 1; k <= i; k++)
					{
						Console.Write((char)(a + k - 1) + " ");
					}
					Console.WriteLine();
				}
				for (int i = 1; i <= 5; i++)
				{
					for (int j = 0; j <= i; j++)
					{
						Console.Write(" ");
					}
					for (int k = 1; k <= 5 - i; k++)
					{
						Console.Write((char)(a + k - 1) + " ");
					}
					Console.WriteLine();
				}
			}
		}
	}


    

