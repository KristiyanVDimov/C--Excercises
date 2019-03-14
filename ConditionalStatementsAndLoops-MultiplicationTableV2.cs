using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var times = int.Parse(Console.ReadLine());
			var result = 0;

			if(times > 10)
			{
				result = n * times;
				Console.WriteLine($"{n} X {times} = {result}");
			}
			else
			{
				for(int i = times; i <= 10; i++)
				{
					result = n * i;
					Console.WriteLine($"{n} X {i} = {result}");
				}
			}
		}
	}
}
