using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var words = input.Split(' ').ToArray();
			Random rnd = new Random();

			for(int i = 0; i < words.Length; i++)
			{
				var pos = rnd.Next(words.Length);

				var temp = words[i];
				words[i] = words[pos];
				words[pos] = temp;
			}

			Console.WriteLine(string.Join("\r\n", words));
		}
	}
}
