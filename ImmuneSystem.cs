using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immune_System
{
	class Program
	{
		static void Main(string[] args)
		{
			int health = int.Parse(Console.ReadLine());
			var input = string.Empty;
			var viruses = new List<string>();
			var initialHealth = health;

			while(true)
			{
				input = Console.ReadLine();

				if (input == "end")
				{
					Console.WriteLine($"Final Health: {health}");
					break;
				}

				var sum = 0;
				for (int i = 0; i < input.Length; i++)
				{
					sum += input[i];
				}

				var time = 0;
				var strenght = sum / 3;
				
				if (viruses.Contains(input))
				{
					time = (strenght * input.Length) / 3;
				}
				else
				{
					viruses.Add(input);
					time = strenght * input.Length;
				}

				health -= time;

				if(health > 0)
				{
					Console.WriteLine($"Virus {input}: {strenght} => {time} seconds");
					Console.WriteLine($"{input} defeated in {time / 60}m " +
						$"{time % 60}s.");
					Console.WriteLine($"Remaining health: {health}");
					int increasedHealth = (int)(health * 0.2 + health);

					if (increasedHealth > initialHealth)
					{
						health = initialHealth;
					}
					else
					{
						health = increasedHealth;
					}
				}
				else
				{
					Console.WriteLine($"Virus {input}: {strenght} => {time} seconds");
					Console.WriteLine("Immune System Defeated.");
					break;
				}
			}
		}
	}
}
