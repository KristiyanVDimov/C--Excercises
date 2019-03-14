using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs_Aggregator
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var logs = new SortedDictionary<string, int>();
			var ips = new SortedDictionary<string, string>();
			
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ').ToList();

				if (!logs.ContainsKey(input[1]))
				{
					logs.Add(input[1], int.Parse(input[2]));
					ips.Add(input[1], input[0]);
				}
				else
				{
					logs[input[1]] += int.Parse(input[2]);
					ips[input[1]] += "|" + input[0];
				}
			}
			foreach (var user in logs)
			{
				var userIps = new List<string>();
				foreach (var ip in ips)
				{
					if(ip.Key == user.Key)
					{
						userIps = ip.Value.Split('|').ToList();
					}
				}
				var temp = userIps.Distinct().OrderBy(t => t);
				Console.WriteLine($"{user.Key}: {user.Value} [{string.Join(", ", temp)}]");
			}
		}
	}
}
