using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] letters = Console.ReadLine().ToCharArray();
			int[] letterIndexes = new int[letters.Length];

			for(int i = 0; i < letters.Length; i++)
			{
				letterIndexes[i] = (int)letters[i] - 97;
			}
			for(int i = 0; i < letterIndexes.Length; i++)
			{
				Console.WriteLine($"{letters[i]} -> {letterIndexes[i]}");
			}
		}
	}
}
