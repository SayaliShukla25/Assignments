﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
	class P30
	{
		static void Main(string[] args)
		{
			for (int i = 5; i >= 1; i--)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write((char)(65 + j - 1) + " ");
				}
				Console.WriteLine();
			}
			for (int i = 2; i <= 5; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write((char)(65 + j - 1) + " ");
				}
				Console.WriteLine();
			}

		}
	}
}


    

