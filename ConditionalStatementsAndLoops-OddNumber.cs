using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			var number = int.Parse(Console.ReadLine());

			while (true)
			{
				if(number % 2 != 0)
				{
					Console.WriteLine($"The number is: {Math.Abs(number)}");
					break;
				}
				Console.WriteLine("Please write an odd number.");
				number = int.Parse(Console.ReadLine());
			}
		}
	}
}
