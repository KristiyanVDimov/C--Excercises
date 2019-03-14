using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logs
{
	class User_Logs
	{
		static void Main()
		{
			var input = Console.ReadLine();
			var logs = new SortedDictionary<string, Dictionary<string, int>>();
			

			while (input != "end")
			{
				var userLog = input.Split(' ').ToArray();
				var ipData = userLog[0].Split('=').ToArray();
				var userData = userLog[2].Split('=').ToArray();
				var ip = ipData[1];
				var user = userData[1];
				var count = 1;

				if (!logs.ContainsKey(user))
				{
					logs[user] = new Dictionary<string, int>();
				}

				if (!logs[user].ContainsKey(ip))
				{
					logs[user][ip] = count;
				}
				else
				{
					logs[user][ip] += count;
				}

				input = Console.ReadLine();
			}

			foreach (var user in logs)
			{
				Console.WriteLine($"{user.Key}:");
				foreach (var ip in user.Value)
				{
					if (ip.Equals(user.Value.Last()))
					{
						Console.WriteLine($"{ip.Key} => {ip.Value}.");
					}
					else
					{
						Console.Write($"{ip.Key} => {ip.Value}, ");
					}
				}
			}
		}
	}
}
