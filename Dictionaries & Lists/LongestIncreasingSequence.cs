using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var LongestIncreasingSubsequence = GetLongestIncreasingSequence(numbers);

			Console.WriteLine(String.Join(" ", LongestIncreasingSubsequence));
		}

		static int[] GetLongestIncreasingSequence(int[] arr)
		{
			var lenghts = new int[arr.Length];
			var prev = new int[arr.Length];

			var bestLenght = 0;
			var lastIndex = -1;

			for (int i = 0; i < arr.Length; i++)
			{
				lenghts[i] = 1;
				prev[i] = -1;

				var anchorNumber = arr[i];

				for (int j = 0; j < i; j++)
				{
					var currentNumber = arr[j];
					
					if(currentNumber < anchorNumber && lenghts[j] + 1 > lenghts[i])
					{
						lenghts[i] = lenghts[j] + 1;
						prev[i] = j;
					}
				}

				if(lenghts[i] > bestLenght)
				{
					bestLenght = lenghts[i];
					lastIndex = i;
				}
			}
			var LongestIncreasingSubsequence = new List<int>();

			while (lastIndex != -1)
			{
				LongestIncreasingSubsequence.Add(arr[lastIndex]);
				lastIndex = prev[lastIndex];
			}
			LongestIncreasingSubsequence.Reverse();

			return LongestIncreasingSubsequence.ToArray();
		}
	}
}
