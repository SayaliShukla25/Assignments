using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
	class Patt
	{
		static void Main(string[] args)
		{

			for (int i = 5; i > 1; i--)

			{
				char k = 'A';
				for (int j = 1; j <= i; j++)
				{
					if (i % 2 != 0)

					{
						Console.Write(j);
					}
					else
					{
						Console.Write(k);
						k++;

					}

				}
				Console.WriteLine();
			}
			for (int i = 1; i <= 5; i++)
			{
				char k = 'A';
				for (int j = 1; j <= i; j++)
				{
					if (i % 2 != 0)
					{
						Console.Write(j);
					}
					else
					{
						Console.Write(k);
						k++;
					}

				}
				Console.WriteLine();


			}
		}
	}
}


