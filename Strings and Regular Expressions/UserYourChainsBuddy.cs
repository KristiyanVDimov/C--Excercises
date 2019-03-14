using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Use_Your_Chains__Buddy
{
	class Program
	{
		static void Main(string[] args)
		{
			var regex = new Regex(@"<p>(?<message>.+?)<\/p>");

			var input = Console.ReadLine();

			var matches = regex.Matches(input).Cast<Match>().
				Select(g => g.Groups["message"].Value).ToArray();

			var output = new StringBuilder();
			
			foreach (string match in matches)
			{
				var message = match;
				message = Regex.Replace(match, @"[^a-z\d]", " ");
				message = Regex.Replace(message, @"\s+", " ");
				output.Append(Rot13(message));
			}

			Console.WriteLine(output.ToString());
		}
		
		static string Rot13(string text)
		{
			var output = new StringBuilder();

			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] >= 'a' && text[i] <= 'm')
				{
					output.Append((char)((int)text[i] + 13));
				}
				else if(text[i] >= 'n' && text[i] <= 'z')
				{
					output.Append((char)((int)text[i] - 13));
				}
				else
				{
					output.Append(text[i]);
				}
			}

			return output.ToString();
		}
	}
}
