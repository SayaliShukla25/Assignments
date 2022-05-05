using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
	class SortA
	{
		static void Main(string[] args)
		{
			int temp;
			int[] arr = new int[5];

			Console.Write("Enter five numbers:");
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 1 + i; j < arr.Length; j++)
				{
					if (arr[i] > arr[j])
					{
						temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}

			Console.Write("Array list after sorting:");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}
}
