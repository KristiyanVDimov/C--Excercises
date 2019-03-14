using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Statistics
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numberArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int minValue = GetMinValueOfArray(numberArr);
			int maxValue = GetMaxValueOfArray(numberArr);
			int sum = GetSumOfArray(numberArr);
			double average = GetAverageOfArray(numberArr);

			Console.WriteLine($"Min = {minValue}\r\nMax = {maxValue}\r\nSum = {sum}\r\nAverage = {average}");
		}

		private static double GetAverageOfArray(int[] array)
		{
			int sum = 0;
			double average = 0.0;

			for(int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}
			average = (double)sum / array.Length;

			return average;
		}

		private static int GetSumOfArray(int[] array)
		{
			int sum = 0;

			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}

			return sum;
		}

		private static int GetMaxValueOfArray(int[] array)
		{
			Array.Sort(array);

			int maxValue = array[array.Length - 1];

			return maxValue;
		}

		private static int GetMinValueOfArray(int[] array)
		{
			Array.Sort(array);

			int minValue = array[0];

			return minValue;
		}
	}
}
