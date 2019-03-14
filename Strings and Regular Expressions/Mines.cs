using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mines
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex r = new Regex(@"<(?<mine>[a-zA-Z]{2})>");
			var input = Console.ReadLine();

			var matches = r.Matches(input);

			foreach (Match match in matches)
			{
				var startIndex = input.IndexOf(match.Value);
				var endIndex = input.IndexOf(match.Value) + 3;
				var mine = match.Groups["mine"].Value;
				var minePower = Math.Abs((int)mine[0] - (int)mine[1]);

				var leftIndex = Math.Max(0, startIndex - minePower);
				var rightIndex = Math.Min(input.Length - 1, endIndex + minePower);

				StringBuilder sb = new StringBuilder(input);

				for (int i = leftIndex; i <= rightIndex; i++)
				{
					sb[i] = '_';
				}

				input = sb.ToString();
			}

			Console.WriteLine(input);
		}
	}
}
