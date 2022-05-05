using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class P17
    {
        static void Main(string[] args)
        {
			int N = 1;
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(N + " ");
					N++;
				}
				Console.WriteLine();
			}
		}
	}
}
    

