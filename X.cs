using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var middleSpaces = n - 2;
			var sideSpaces = 0;
			for(int i = 0; i <= n / 2 - 1; i++)
			{
				Console.WriteLine("{0}x{1}x", new string(' ', sideSpaces), new string(' ', middleSpaces));
				sideSpaces++;
				middleSpaces -= 2;
			}
			Console.WriteLine("{0}x", new string(' ', sideSpaces));
			sideSpaces--;
			middleSpaces += 2;
			for (int i = 0; i <= n / 2 - 1; i++)
			{
				Console.WriteLine("{0}x{1}x", new string(' ', sideSpaces), new string(' ', middleSpaces));
				sideSpaces--;
				middleSpaces += 2;
			}
		}
	}
}
