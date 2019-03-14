using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Times
{
	class Program
	{
		static void Main(string[] args)
		{
			List<DateTime> input = Console.ReadLine().Split(' ').Select(DateTime.Parse).ToList();
			input.Sort();

			foreach (var time in input)
			{
				if (time.Equals(input.Last()))
				{
					Console.WriteLine($"{time.Hour:D2}:{time.Minute:D2}");
					break;
				}

				Console.Write($"{time.Hour:D2}:{time.Minute:D2}, ");
			}
		}
	}
}
