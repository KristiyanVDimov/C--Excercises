using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			var words = Console.ReadLine().ToLower().Split().ToArray();
			var occurrences = new Dictionary<string, int>();

			foreach (var word in words)
			{
				if (occurrences.ContainsKey(word))
				{
					occurrences[word]++;
				}
				else
				{
					occurrences[word] = 1;
				}
			}

			var result = new List<string>();

			foreach (var count in occurrences)
			{
				if(count.Value % 2 != 0)
				{
					result.Add(count.Key);
				}
			}

			Console.WriteLine(String.Join(", ", result));
		}
	}
}
