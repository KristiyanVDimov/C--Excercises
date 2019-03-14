using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = 10;
			int c = a;
			Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
			a = b;
			b = c;
			Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
		}
	}
}
