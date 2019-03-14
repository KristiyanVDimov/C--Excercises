using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			int a;
			if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
			{
				Console.WriteLine("vowel");
			}
			else if(Int32.TryParse(input, out a))
			{
				Console.WriteLine("digit");
			}
			else
			{
				Console.WriteLine("other");
			}
		}
	}
}
