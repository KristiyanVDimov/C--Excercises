using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Upgrade
{
	class Program
	{
		static void Main(string[] args)
		{
			var command = Console.ReadLine().Split().ToArray();
			var phoneBook = new SortedDictionary<string, string>();

			while (command[0] != "END")
			{
				DoCommand(phoneBook, command);
				command = Console.ReadLine().Split().ToArray();
			}
		}

		private static void DoCommand(SortedDictionary<string, string> phoneBook, string[] command)
		{
			var name = string.Empty;
			var names = new List<string>();
			var numbers = new List<string>();

			switch (command[0])
			{
				case "A":
					name = command[1];
					var number = command[2];
					phoneBook[name] = number;
					break;
				case "S":
					name = command[1];
					if (phoneBook.ContainsKey(name))
					{
						foreach (var pair in phoneBook)
						{
							if (pair.Key == name)
							{
								names.Add(pair.Key);
								numbers.Add(pair.Value);
							}
						}
						Console.WriteLine($"{names[0]} -> {numbers[0]}");
					}
					else
					{
						Console.WriteLine($"Contact {name} does not exist.");
					}
					break;
				case "ListAll":
					foreach (var pair in phoneBook)
					{
						Console.WriteLine(pair.Key + " -> " + pair.Value);
					}
					break;
			}
		}
	}
}
