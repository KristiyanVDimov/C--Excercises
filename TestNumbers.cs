using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var m = int.Parse(Console.ReadLine());
			var boundary = int.Parse(Console.ReadLine());
			var count = 0;
			var sum = 0;
			
			for (int i = n; i >= 1; i--)
			{
				for(int j = 1; j <= m; j++)
				{
					if (sum >= boundary)
					{
						break;
					}
					sum = sum + (3 * (i * j));
					count++;
					
				}
			}
			if (sum >= boundary)
			{
				Console.WriteLine($"{count} combinations");
				Console.WriteLine($"Sum: {sum} >= {boundary}");
			}
			else
			{
				Console.WriteLine($"{count} combinations");
				Console.WriteLine($"Sum: {sum}");
			}
		}
	}
}
