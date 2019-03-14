using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int difference = int.Parse(Console.ReadLine());
			int count = 0;

			for(int i = 0; i < arr.Length - 1; i++)
			{
				for(int j = i; j < arr.Length; j++)
				{
					int arrDiff = Math.Abs(arr[i] - arr[j]);
					if (arrDiff == difference && i < j)
					{
						count++;
					}
				}
			}
			Console.WriteLine(count);
		}
	}
}
