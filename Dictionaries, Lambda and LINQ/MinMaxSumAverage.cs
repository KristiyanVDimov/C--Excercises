using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min__Max__Sum__Average
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var numbers = new int[n];

			for (int i = 0; i < n; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine($"Sum = {numbers.Sum()}\r\nMin = {numbers.Min()}\r\nMax = {numbers.Max()}" +
				$"\r\nAverage = {numbers.Average()}");
		}
	}
}
