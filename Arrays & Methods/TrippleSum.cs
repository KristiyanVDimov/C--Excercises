using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var sum = 0;
			var a = 0;
			var b = 0;
			bool isTrue = true;
			for(int i = 0; i < arr.Length; i++)
			{
				for(int j = i + 1; j < arr.Length; j++)
				{
					sum = arr[i] + arr[j];
					a = arr[i];
					b = arr[j];
					if (arr.Contains(sum))
					{
						Console.WriteLine($"{a} + {b} == {sum}");
						isTrue = false;
					}
				}
			}
			if (isTrue)
			{
				Console.WriteLine("No");
			}
		}
	}
}
