using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr1 = Console.ReadLine().Split(' ').ToArray();
			string[] arr2 = Console.ReadLine().Split(' ').ToArray();

			int minLenght = Math.Min(arr1.Length, arr2.Length);
			int leftCounter = 0;
			int rightCounter = 0;

			for(int i = 0; i < minLenght; i++)
			{
				if(arr1[i] == arr2[i])
				{
					leftCounter++;
				}
			}

			Array.Reverse(arr1);
			Array.Reverse(arr2);

			for(int i = 0; i < minLenght; i++)
			{
				if(arr1[i] == arr2[i])
				{
					rightCounter++;
				}
			}

			if(leftCounter > rightCounter)
			{
				Console.WriteLine(leftCounter);
			}
			else
			{
				Console.WriteLine(rightCounter);
			}
		}
	}
}
