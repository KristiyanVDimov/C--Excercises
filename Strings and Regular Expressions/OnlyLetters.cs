using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Only_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var regex = new Regex(@"(\d+)([a-zA-Z])");
			var matches = regex.Matches(input);

			foreach (Match match in matches)
			{
				var number = match.Groups[1].Value;
				var letter = match.Groups[2].Value;

				input = input.Replace(number, letter);
			}

			Console.WriteLine(input);
		}
	}
}
