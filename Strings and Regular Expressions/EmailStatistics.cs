using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Email_Statistics
{
	class Program
	{
		static void Main(string[] args)
		{
			var r = new Regex(@"\b(?<username>[a-zA-Z]{5,})@(?<domain>[a-z]{3,}\.(org|bg|com))\b");
			var n = int.Parse(Console.ReadLine());
			var emailStatistics = new Dictionary<string, List<string>>();

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine();

				if (r.IsMatch(input))
				{
					var match = r.Match(input);
					var user = match.Groups["username"].Value;
					var domain = match.Groups["domain"].Value;

					if (!emailStatistics.ContainsKey(domain))
					{
						emailStatistics[domain] = new List<string>();
					}

					if (!emailStatistics[domain].Contains(user))
					{
						emailStatistics[domain].Add(user);
					}
				}
			}

			foreach (var emailStats in emailStatistics.OrderBy(x => -x.Value.Count))
			{
				Console.WriteLine($"{emailStats.Key}:");

				foreach (var user in emailStats.Value)
				{
					Console.WriteLine($"### {user}");
				}
			}
		}
	}
}
