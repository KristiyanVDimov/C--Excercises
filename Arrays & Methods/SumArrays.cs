using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int[] sumArray = GetSumOfTwoArrays(firstArray, secondArray);

			Console.WriteLine(string.Join(" ", sumArray));
		}

		private static int[] GetSumOfTwoArrays(int[] firstArray, int[] secondArray)
		{
			int[] sum = new int[Math.Max(firstArray.Length, secondArray.Length)];

			for(int i = 0; i < sum.Length; i++)
			{
				sum[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
			}
			return sum;
		}
	}
}
