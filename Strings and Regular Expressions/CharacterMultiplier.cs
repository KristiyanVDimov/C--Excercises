using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(' ').ToArray();

			var str1 = input[0];
			var str2 = input[1];
			var start = Math.Min(str1.Length, str2.Length);
			var end = Math.Max(str1.Length, str2.Length);
			var sum = 0;

			for (int i = 0; i < start; i++)
			{
				var multiplied = str1[i] * str2[i];
				sum += multiplied;
			}

			if(str1.Length > str2.Length)
			{
				for (int i = start; i < end; i++)
				{
					sum += str1[i];
				}
			}
			else
			{
				for (int i = start; i < end; i++)
				{
					sum += str2[i];
				}
			}

			Console.WriteLine(sum);
		}
	}
}
