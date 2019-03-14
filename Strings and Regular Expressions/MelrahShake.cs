using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melrah_Shake
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = Console.ReadLine();

			while (true)
			{
				var leftIndex = input.IndexOf(pattern);
				var rightIndex = input.LastIndexOf(pattern);

				if(leftIndex != -1 && rightIndex != -1 && pattern.Length > 0)
				{
					Console.WriteLine("Shaked it.");
					input = input.Remove(leftIndex, pattern.Length);
					rightIndex = input.LastIndexOf(pattern);
					input = input.Remove(rightIndex, pattern.Length);
				}
				else
				{
					Console.WriteLine("No shake.");
					Console.WriteLine(input);
					break;
				}

				pattern = pattern.Remove(pattern.Length / 2, 1);
			}
		}
	}
}
