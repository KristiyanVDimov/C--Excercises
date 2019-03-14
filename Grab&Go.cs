using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grab_and_Go
{
	class Program
	{
		static void Main(string[] args)
		{
			long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
			long number = int.Parse(Console.ReadLine());
			long sum = 0;

			//long[] newArr = arr.Distinct().ToArray();
			//arr = newArr;
			//bool isContained = false;
			for(int i = 0; i < Array.LastIndexOf(arr, number); i++)
			{
				sum += arr[i];
			}
			if (arr.Contains(number))
			{
				Console.WriteLine(sum);
			}
			else
			{
				Console.WriteLine("No occurrences were found!");
			}
			//for(int i = 0; i < arr.Length; i++)
			//{
			//	sum += arr[i];
			//	if(arr[i] == number)
			//	{
			//		isContained = true;
			//	}
			//}

			//if (isContained)
			//{
			//	Console.WriteLine(sum);
			//}
			//else
			//{
			//	Console.WriteLine("No occurrences were found!");
			//}

		}
	}
}
