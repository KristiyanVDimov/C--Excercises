using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Censorship
{
	class Program
	{
		static void Main(string[] args)
		{
			var r = new Regex(Console.ReadLine());

			var input = Console.ReadLine();

			input = r.Replace(input, new string('*', r.ToString().Length));

			Console.WriteLine(input);
		}
	}
}
