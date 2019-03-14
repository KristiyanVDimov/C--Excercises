using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legendary_Farming
{
	class Legendary_Farming
	{
		static void Main()
		{
			var collectables = new SortedDictionary<string, int>
			{
				{"shards", 0 },
				{"motes", 0 },
				{"fragments", 0 }
			};

			var junks = new SortedDictionary<string, int>();

			var shardsQuantity = 0;
			var motesQuantity = 0;
			var fragmentsQuantity = 0;

			var isFarmed = false;

			while (true)
			{
				var input = Console.ReadLine().ToLower();
				var materials = input.Split(' ').ToArray();
				var material = string.Empty;
				var quantity = 0;
				var collectable = string.Empty;

				for (int i = 0; i < materials.Length; i += 2)
				{
					quantity = int.Parse(materials[i]);
					material = materials[i + 1];

					switch (material)
					{
						case "shards": collectables[material] += quantity;
							shardsQuantity += quantity;
							break;
						case "fragments": collectables[material] += quantity;
							fragmentsQuantity += quantity;
							break;
						case "motes": collectables[material] += quantity;
							motesQuantity += quantity;
							break;
						default:
							if (!junks.ContainsKey(material))
							{
								junks.Add(material, quantity);
							}
							else
							{
								junks[material] += quantity;
							}
							break;
					}

					if(shardsQuantity >= 250)
					{
						collectable = "shards";
						isFarmed = true;
						PrintLegendary(collectable, collectables, junks);
						break;
					}
					if(motesQuantity >= 250)
					{
						collectable = "motes";
						isFarmed = true;
						PrintLegendary(collectable, collectables, junks);
						break;
					}
					if(fragmentsQuantity >= 250)
					{
						collectable = "fragments";
						isFarmed = true;
						PrintLegendary(collectable, collectables, junks);
						break;
					}
				}

				if (isFarmed)
				{
					break;
				}
			}
		}

		static void PrintLegendary(string collectable,
			SortedDictionary<string, int> collectables,
			SortedDictionary<string, int> junks)
		{
			collectables[collectable] -= 250;

			switch (collectable)
			{
				case "shards":
					Console.WriteLine("Shadowmourne obtained!");
					foreach (var material in collectables.OrderBy(t => -t.Value))
					{
						Console.WriteLine($"{material.Key}: {material.Value}");
					}
					foreach (var junk in junks)
					{
						Console.WriteLine($"{junk.Key}: {junk.Value}");
					}
					break;
				case "fragments":
					Console.WriteLine("Valanyr obtained!");
					foreach (var material in collectables.OrderBy(t => -t.Value))
					{
						Console.WriteLine($"{material.Key}: {material.Value}");
					}
					foreach (var junk in junks)
					{
						Console.WriteLine($"{junk.Key}: {junk.Value}");
					}
					break;
				case "motes":
					Console.WriteLine("Dragonwrath obtained!");
					foreach (var material in collectables.OrderBy(t => -t.Value))
					{
						Console.WriteLine($"{material.Key}: {material.Value}");
					}
					foreach (var junk in junks)
					{
						Console.WriteLine($"{junk.Key}: {junk.Value}");
					}
					break;
			}
		}
	}
}
