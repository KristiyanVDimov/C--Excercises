using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Сръбско_Unleashed
{
	class Program
	{
		static void Main(string[] args)
		{
			string pattern = @"(.*?) @(.*?) (\d+) (\d+)";
			var input = Console.ReadLine();

			var concert = new Dictionary<string, Dictionary<string, long>>();

			while (input != "End")
			{
				if (!Regex.IsMatch(input, pattern))
				{
					input = Console.ReadLine();
					continue;
				}

				var data = input.Split(new[] { " @" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var singerData = data[1].Split(' ').ToArray();
				var singerName = data[0];
				var ticketsData = new List<long>();
				var venueData = new List<string>();
				var ticketsCount = 0l;
				var ticketsPrice = 0l;

				for (int i = 0; i < singerData.Length; i++)
				{
					if (long.TryParse(singerData[i], out ticketsPrice))
					{
						ticketsData.Add(long.Parse(singerData[i]));
					}
					else
					{
						venueData.Add(singerData[i]);
					}
				}
				ticketsPrice = ticketsData[0];
				ticketsCount = ticketsData[1];

				var venue = string.Join(" ", venueData);

				if (!concert.ContainsKey(venue))
				{
					concert[venue] = new Dictionary<string, long>();
				}
				if (!concert[venue].ContainsKey(singerName))
				{
					concert[venue][singerName] = ticketsPrice * ticketsCount;
				}
				else
				{
					concert[venue][singerName] += ticketsPrice * ticketsCount;
				}

				input = Console.ReadLine();
			}

			foreach (var venue in concert)
			{
				Console.WriteLine(venue.Key);

				foreach (var singer in venue.Value.OrderBy(s => -s.Value))
				{
					Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
				}
			}
		}
	}
}
