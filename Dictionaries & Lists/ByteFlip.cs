using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Flip
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(' ').ToList();

			for (int i = 0; i < input.Count; i++)
			{
				if(input[i].Length != 2)
				{
					input.Remove(input[i]);
					i--;
				}
			}

			for (int i = 0; i < input.Count; i++)
			{
				string reversed = new string(input[i].ToCharArray().Reverse().ToArray());
				input[i] = reversed;
			}

			input.Reverse();

			var result = new List<char>();

			for (int i = 0; i < input.Count; i++)
			{
				result.Add((char)(Convert.ToInt32(input[i], 16)));
			}

			Console.WriteLine(string.Join("", result));
		}
	}
}
