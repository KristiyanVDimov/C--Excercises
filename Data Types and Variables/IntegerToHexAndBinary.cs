using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string hexadecimal = Convert.ToString(n, 16);
			string binary = Convert.ToString(n, 2);

			Console.WriteLine($"{hexadecimal.ToUpper()}\r\n{binary}");
		}
	}
}
