using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_chars
{
	class Program
	{
		static void Main(string[] args)
		{
			char chr1 = char.Parse(Console.ReadLine());
			char chr2 = char.Parse(Console.ReadLine());
			char chr3 = char.Parse(Console.ReadLine());

			Console.WriteLine($"{chr3}{chr2}{chr1}");
		}
	}
}
