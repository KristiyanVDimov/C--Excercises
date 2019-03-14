using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Around
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int index = 0;
			long sum = 0L;

			while (true)
			{
				int temp = index;
				sum += numbers[index];
				index += numbers[index];
				if(index >= numbers.Length)
				{
					index = temp - numbers[temp];
					if(index < 0)
					{
						break;
					}
				}
			}
			Console.WriteLine(sum);
		}
	}
}
