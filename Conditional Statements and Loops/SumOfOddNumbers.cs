using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Odd_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var current = 1;
			var sum = 0;

			for(int i = 0; i < n; i++)
			{
				Console.WriteLine(current);
				sum += current;
				current += 2;
			}
			Console.WriteLine("Sum: " + sum);
		}
	}
}
