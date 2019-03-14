using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_in_Plural
{
	class Program
	{
		static void Main(string[] args)
		{
			var word = Console.ReadLine();
			var pluralWord = "";
			if (word.EndsWith("y"))
			{
				pluralWord = word.Remove(word.Length - 1, 1);
				word = pluralWord + "ies";
			}
			else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") ||
				word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
			{
				word = word + "es";
			}
			else
			{
				pluralWord = word.Insert(word.Length, "s");
				word = pluralWord;
			}
			Console.WriteLine(word);
		}
	}
}
