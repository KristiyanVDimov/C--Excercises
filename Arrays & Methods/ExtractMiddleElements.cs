using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			ExtractArrayElements(arr);
		}

		private static void ExtractArrayElements(int[] arr)
		{
			char openningBracket = '{';
			char closingBracket = '}';

			if(arr.Length == 1)
			{
				Console.WriteLine($"{openningBracket} {arr[0]} {closingBracket}");
			}
			else if(arr.Length % 2 == 0)
			{
				Console.WriteLine($"{openningBracket} {arr[arr.Length / 2 - 1]}," +
					$" {arr[arr.Length / 2]} {closingBracket}");
			}
			else
			{
				Console.WriteLine($"{openningBracket} {arr[arr.Length / 2 - 1]}," +
					$" {arr[arr.Length / 2]}, {arr[arr.Length / 2 + 1]} {closingBracket}");
			}
		}
	}
}
