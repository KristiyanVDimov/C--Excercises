using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var strength = 0;
			var index = 0;

			for (int i = 0; i < input.Length; i++)
			{
				if(input[i] == '>')
				{
					strength += int.Parse(input[i + 1].ToString());
					i++;

					while(i < input.Length && strength > 0)
					{
						if (input[i] == '>')
						{
							break;
						}
						input = input.Remove(i, 1);
						strength--;
					}
					i--;
				}
			}
			Console.WriteLine(input);
		}
	}
}
