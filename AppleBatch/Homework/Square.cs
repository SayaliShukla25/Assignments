using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Square
    {
        static void Main(string[] args)
		{ 

			
                int i, N;

				Console.WriteLine("Enter N : ");
				N = Convert.ToInt32(Console.ReadLine());

				for (i = 1; i <= N; i++)
				{
					Console.WriteLine( i * i);

				}

			}
		}
	}


    

