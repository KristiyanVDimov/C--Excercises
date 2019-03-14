using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			listOfNumbers.RemoveRange(0, numbers[1]);

			if (listOfNumbers.Contains(numbers[2]))
			{
				Console.WriteLine("YES!");
			}
			else
			{
				Console.WriteLine("NO!");
			}
		}
	}
}
