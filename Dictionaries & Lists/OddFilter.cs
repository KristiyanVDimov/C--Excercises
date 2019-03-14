using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Filter
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			for (int i = 0; i < input.Count; i++)
			{
				if(input[i] % 2 != 0)
				{
					input.Remove(input[i]);
					i--;
				}
			}
			var average = input.Average();

			for (int i = 0; i < input.Count; i++)
			{
				if(input[i] > average)
				{
					input[i] += 1;
				}
				else
				{
					input[i] -= 1;
				}
			}

			Console.WriteLine(string.Join(" ", input));
		}
	}
}
