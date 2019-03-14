using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
	class Program
	{
		static void Main(string[] args)
		{
			var cardHands = new Dictionary<string, string[]>();
			var handPower = new Dictionary<string, int>();

			while (true)
			{
				var input = Console.ReadLine().Split(':').ToArray();
				
				if(input[0] == "JOKER")
				{
					break;
				}
				string[] arr = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

				for (int i = 0; i < arr.Length; i++)
				{
					var type = arr[i][1];
					var power = arr[i][0];
				}

				if (!cardHands.ContainsKey(input[0]))
				{
					cardHands.Add(input[0], arr);
				}
				else
				{
					cardHands[input[0]] = cardHands[input[0]].Concat(arr).ToArray();
				}
			}

			var cards = new List<string[]>();

			foreach (var card in cardHands)
			{
				cards.Add(card.Value);
			}

			var powers = new List<List<string>>();
			var types = new List<List<string>>();

			for (int i = 0; i < cards.Count; i++)
			{
				var arr2 = cards[i].Distinct().ToArray();
				var tempPower = new List<string>();
				var tempType = new List<string>();

				for (int j = 0; j < arr2.Length; j++)
				{
					tempPower.Add(arr2[j].Substring(0, arr2[j].Length - 1));
					tempType.Add(arr2[j].Substring(arr2[j].Length - 1));
				}
				powers.Add(tempPower);
				types.Add(tempType);
			}
			var names = new List<string>();

			foreach (var name in cardHands.Keys)
			{
				names.Add(name);
			}

			for (int i = 0; i < types.Count; i++)
			{
				var temp = 0;
				temp = GetHandPower(powers[i], types[i]);

				handPower.Add(names[i], temp);

			}

			foreach (var player in handPower)
			{
				Console.WriteLine($"{player.Key}: {player.Value}");
			}
		}

		static int GetHandPower(List<string> powers, List<string> types)
		{
			int sum = 0;
			

			for (int i = 0; i < types.Count; i++)
			{
				int multiplier = 0;
				int power = 0;

				switch (types[i])
				{
					case "S": multiplier = 4; break;
					case "H": multiplier = 3; break;
					case "D": multiplier = 2; break;
					case "C": multiplier = 1; break;
				}

				switch (powers[i])
				{
					case "2": power = 2; break;
					case "3": power = 3; break;
					case "4": power = 4; break;
					case "5": power = 5; break;
					case "6": power = 6; break;
					case "7": power = 7; break;
					case "8": power = 8; break;
					case "9": power = 9; break;
					case "10": power = 10; break;
					case "J": power = 11; break;
					case "Q": power = 12; break;
					case "K": power = 13; break;
					case "A": power = 14; break;
				}

				sum += power * multiplier;
			}

			return sum;
		}
	}
}
