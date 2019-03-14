using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hideout
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var search = Console.ReadLine().Split(' ').ToArray();

			var index = 0;
			var length = 0;

			while (true)
			{
				var searchedChar = search[0];
				var count = int.Parse(search[1]);
				var regex = new Regex(Regex.Escape(searchedChar) + "{" + count + "}");

				if (!regex.IsMatch(input))
				{
					search = Console.ReadLine().Split(' ').ToArray();
				}
				else
				{
					var match = regex.Match(input);

					index = input.IndexOf(match.Value);
					
					for (int i = index; i < input.Length; i++)
					{
						if (input[i] != char.Parse(searchedChar))
						{
							break;
						}
						else
						{
							length++;
						}
					}
					break;
				}
			}

			Console.WriteLine($"Hideout found at index {index} and it is with size {length}!");
		}
	}
}
