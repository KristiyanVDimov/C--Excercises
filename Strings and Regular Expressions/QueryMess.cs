using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Query_Mess
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex r = new Regex(@"(\w+.*\w+=.*)");

			var matchList = new List<string>();

			var input = Console.ReadLine();
			
			while (input != "END")
			{
				var match = r.Match(input);
				var key = string.Empty;
				var value = string.Empty;
				var matchTokens = match.Value.Split(new char[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var keys = new Dictionary<string, string>();

				for (int i = 0; i < matchTokens.Length; i++)
				{
					if (matchTokens[i].Contains("="))
					{
						var tokens = matchTokens[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
						key = tokens[0];
						value = tokens[1];

						if (value.Contains("+"))
						{
							value = value.Replace("+", " ");
						}
						if (value.Contains("%20"))
						{
							value = value.Replace("%20", " ");
						}
						if (key.Contains("+"))
						{
							key = key.Replace("+", " ");
						}
						if (key.Contains("%20"))
						{
							key = key.Replace("%20", " ");
						}

						Regex rgx = new Regex(@"\s+");

						var resultKey = rgx.Replace(key, " ").Trim();
						var resultValue = rgx.Replace(value, " ").Trim();

						if (!keys.ContainsKey(resultKey))
						{
							keys.Add(resultKey, resultValue);
						}
						else
						{
							keys[resultKey] = keys[resultKey] + ", " + resultValue;
						}
					}
				}

				var listInput = string.Empty;

				foreach (var keyValue in keys)
				{
					listInput += $"{keyValue.Key}=[{keyValue.Value}]";
				}

				matchList.Add(listInput);

				input = Console.ReadLine();
			}


			foreach (var output in matchList)
			{
				Console.WriteLine(output);
			}
		}
	}
}
