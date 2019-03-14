using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

			while (true)
			{
				var command = Console.ReadLine().Split().ToArray();
				numbers = DoCommand(numbers, command);

				if (command[0] == "print")
				{
					break;
				}
			}

		}

		private static List<int> DoCommand(List<int> numbers, string[] command)
		{
			switch (command[0])
			{
				case "add":
					numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
					break;

				case "addMany":
					List<int> list = new List<int>();
					int index = int.Parse(command[1]);

					for(int i = 2; i < command.Length; i++)
					{
						list.Add(int.Parse(command[i]));
					}

					numbers.InsertRange(index, list);
					break;

				case "contains":
					if (numbers.Contains(int.Parse(command[1])))
					{
						Console.WriteLine(numbers.IndexOf(int.Parse(command[1])));
					}
					else
					{
						Console.WriteLine(-1);
					}
					break;

				case "remove":
					numbers.RemoveAt(int.Parse(command[1]));
					break;

				case "sumPairs":
					List<int> temp = new List<int>();

					for (int i = 0; i < numbers.Count; i += 2)
					{
						int current = numbers[i];
						int next = 0;

						if(i < numbers.Count - 1)
						{
							next = numbers[i + 1];
						}

						int sum = current + next;
						
						temp.Add(sum);
					}
					numbers = temp;
					break;

				case "shift":
					ShiftElements(numbers, int.Parse(command[1]));
					break;

				case "print":
					Console.WriteLine($"[{string.Join(", ", numbers)}]");
					break;
			}
			return numbers;
		}
		
		static void ShiftElements(List<int> numbers, int position)
		{
			for(int i = 0; i < position; i++)
			{
				for(int j = 0; j < numbers.Count - 1; j++)
				{
					int temp = numbers[j];
					numbers[j] = numbers[j + 1];
					numbers[j + 1] = temp;
				}
			}
		}
	}
}
