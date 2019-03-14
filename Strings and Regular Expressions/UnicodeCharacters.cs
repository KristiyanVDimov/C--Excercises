using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();


			GetUnicodeRepresentation(input);
		}

		private static void GetUnicodeRepresentation(string input)
		{
			string unicode = string.Empty;

			for (int i = 0; i < input.Length; i++)
			{
				unicode = "\\u" + ((int)input[i]).ToString("X4");
				Console.Write(unicode.ToLower());
			}
			Console.WriteLine();
		}
	}
}
