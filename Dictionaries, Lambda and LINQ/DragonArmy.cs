using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Army
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ').ToList();
				var dragonType = string.Empty;
				var dragonName = string.Empty;
				var damage = 45;
				var health = 250;
				var armor = 10;

				dragonType = input[0];
				dragonName = input[1];

				if(input[2] != "null")
				{
					damage = int.Parse(input[2]);
				}
				if(input[3] != "null")
				{
					health = int.Parse(input[3]);
				}
				if(input[4] != "null")
				{
					armor = int.Parse(input[4]);
				}

				var stats = new List<int>
				{
					damage,
					health,
					armor
				};

				if (!dragons.ContainsKey(dragonType))
				{
					dragons[dragonType] = new SortedDictionary<string, List<int>>();
				}
				if (!dragons[dragonType].ContainsKey(dragonName))
				{
					dragons[dragonType][dragonName] = stats;
				}
				else
				{
					for (int j = 0; j < dragons[dragonType][dragonName].Count; j++)
					{
						dragons[dragonType][dragonName][j] = stats[j];
					}
				}
			}
			

			foreach (var dragon in dragons)
			{
				var avgDamage = 0.0;
				var avgHealth = 0.0;
				var avgArmor = 0.0;

				foreach (var stats in dragon.Value)
				{
					avgDamage += stats.Value[0];
					avgHealth += stats.Value[1];
					avgArmor += stats.Value[2];
				}

				Console.WriteLine($"{dragon.Key}::({((double)avgDamage /dragon.Value.Count):F2}/" +
					$"{((double)avgHealth /dragon.Value.Count):F2}/" +
					$"{((double)avgArmor / dragon.Value.Count):F2})");

				foreach (var stats in dragon.Value)
				{
					Console.WriteLine($"-{stats.Key} -> damage: {stats.Value[0]}, " +
						$"health: {stats.Value[1]}, " +
						$"armor: {stats.Value[2]}");
				}
			}
		}
	}
}
