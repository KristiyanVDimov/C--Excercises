using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int frequency = 1;
			int mostFrequentNumber = arr[0];
			int bestFrequency = 1;

			for (int i = 0; i < arr.Length - 1; i++)
			{
				for(int j = 1; j < arr.Length - i; j++)
				{
					if (arr[i] == arr[i + j])
					{
						frequency++;
					}

					if (frequency > bestFrequency)
					{
						mostFrequentNumber = arr[i];
						bestFrequency = frequency;
					}
				}

				frequency = 1;
			}

			Console.WriteLine(mostFrequentNumber);
		}
	}
}
