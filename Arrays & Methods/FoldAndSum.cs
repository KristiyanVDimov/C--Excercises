using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int k = numbers.Length / 4;
			int[] row1 = new int[numbers.Length / 2];
			int[] row2 = new int[numbers.Length / 2];
			int[] finalRow = new int[numbers.Length / 2];

			int count = k - 1;

			for(int i = 0; i < k; i++)
			{
				row1[i] = numbers[count];
				count--;
			}
			count = k;
			int count2 = numbers.Length - 1;
			for (int i = numbers.Length - k; i < numbers.Length; i++)
			{
				row1[count] = numbers[count2];
				count2--;
				count++;
			}
			count = 0;
			for(int i = k; i < numbers.Length - k; i++)
			{
				row2[count] = numbers[i];
				count++;
			}

			for(int i = 0; i < row1.Length; i++)
			{
				finalRow[i] = row1[i] + row2[i];
			}
			Console.WriteLine(string.Join(" ", finalRow));
		}
	}
}
