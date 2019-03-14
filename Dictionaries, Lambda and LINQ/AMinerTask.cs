using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var resourses = new Dictionary<string, int>();
			var prevInput = string.Empty;
			while(input != "stop")
			{
				var number = 0;

				if(!int.TryParse(input, out number))
				{
					if (!resourses.ContainsKey(input))
					{
						resourses[input] = 0;
					}
					prevInput = input;
				}
				else
				{
					resourses[prevInput] += int.Parse(input);
				}

				input = Console.ReadLine();
			}

			foreach (var resourse in resourses)
			{
				Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
			}
		}
	}
}
