using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
	class Program
	{
		static void Main(string[] args)
		{
			var damageRegex = new Regex(@"\-?\d+(\.\d+)?");
			var multiplyRegex = new Regex(@"\*");
			var divideRegex = new Regex(@"\/");
			var notHealthChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*', '/', '.' };
			var demons = new SortedDictionary<string, Dictionary<int, double>>();

			var demonsInput = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => y.Trim()).ToArray();

			for (int i = 0; i < demonsInput.Length; i++)
			{
				var health = 0;
				var damage = 0.0;

				for (int j = 0; j < demonsInput[i].Length; j++)
				{
					if (!notHealthChars.Contains(demonsInput[i][j]))
					{
						health += (int)demonsInput[i][j];
					}
				}

				var damageMatches = damageRegex.Matches(demonsInput[i]).Cast<Match>().Select(x => double.Parse(x.ToString())).ToArray();

				for (int j = 0; j < damageMatches.Length; j++)
				{
					damage += damageMatches[j];
				}

				var multiplyMatches = multiplyRegex.Matches(demonsInput[i]).Cast<Match>().ToArray();
				var divideMatches = divideRegex.Matches(demonsInput[i]).Cast<Match>().ToArray();

				if(multiplyMatches.Length > 0)
				{
					for (int j = 0; j < multiplyMatches.Length; j++)
					{
						damage *= 2;
					}
				}
				if(divideMatches.Length > 0)
				{
					for (int j = 0; j < divideMatches.Length; j++)
					{
						damage /= 2;
					}
				}

				demons[demonsInput[i]] = new Dictionary<int, double>();

				demons[demonsInput[i]].Add(health, damage);
			}

			foreach (var demon in demons)
			{
				foreach (var attributes in demon.Value)
				{
					Console.WriteLine($"{demon.Key} - {attributes.Key} health, {attributes.Value:f2} damage");
				}
			}
		}
	}
}
