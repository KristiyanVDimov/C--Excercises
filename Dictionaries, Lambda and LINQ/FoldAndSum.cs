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
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var k = numbers.Length / 4;

			var leftRow1 = numbers.Take(k).Reverse().ToArray();
			var rightRow1 = numbers.Reverse().Take(k).ToArray();
			var row1 = leftRow1.Concat(rightRow1).ToArray();
			var row2 = numbers.Skip(k).Take(k * 2).ToArray();


			var result = new int[k * 2];

			for(int i = 0; i < result.Length; i++) // same as var result = row1.Select((x, index) => x + row2[index]);
			{
				result[i] = row1[i] + row2[i];
			}

			Console.WriteLine(String.Join(" ", result));
		}
	}
}
