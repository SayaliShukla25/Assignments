using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
	class P10
	{
		static void Main(string[] args)
		{
		
		
			for (int i = 5; i >= 1; i--)
				{
					for (int j = 1; j <= i; j++)
					{
						Console.Write(" ");
					}
					for (int k = i; k <= 5; k++)
					{
						Console.Write((char)(65 + k - 1) + " ");
					}
					Console.WriteLine();
				}
			}
		}
	}

