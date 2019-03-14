using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
			var command = Console.ReadLine();

			while(command != "Odd" && command != "Even")
			{
				DoCommand(numbers, command);

				command = Console.ReadLine();
			}

			PrintList(numbers, command);
		}

		private static void PrintList(List<int> numbers, string command)
		{
			var temp = new List<int>();

			if (command == "Odd")
			{
				for (int i = 0; i < numbers.Count; i++)
				{
					if (numbers[i] % 2 != 0)
					{
						temp.Add(numbers[i]);
					}
				}
			}
			if (command == "Even")
			{
				for (int i = 0; i < numbers.Count; i++)
				{
					if(numbers[i] % 2 == 0)
					{
						temp.Add(numbers[i]);
					}
				}
			}

			Console.WriteLine(string.Join(" ", temp));
		}

		static void DoCommand(List<int> numbers, string input)
		{
			var commandTokens = input.Split(' ').ToArray();
			var command = commandTokens[0];
			var element = 0;
			var index = 0;

			switch (command)
			{
				case "Delete":
					element = int.Parse(commandTokens[1]);
					numbers.RemoveAll(x => x == element);
					break;
				case "Insert":
					element = int.Parse(commandTokens[1]);
					index = int.Parse(commandTokens[2]);
					numbers.Insert(index, element);
					break;
			}
		}
	}
}
