using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
	class Program
	{
		static void Main(string[] args)
		{
			var peshosDamage = int.Parse(Console.ReadLine());
			var goshosDamage = int.Parse(Console.ReadLine());
			var peshosHealth = 100;
			var goshosHealth = 100;
			var count = 0;

			for (int i = 1; i <= 100; i++)
			{
				count++;
				if (i % 2 != 0)
				{
					goshosHealth -= peshosDamage;
					if (goshosHealth <= 0)
					{
						Console.WriteLine($"Pesho won in {count}th round.");
						break;
					}
					Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
				}
				else
				{
					peshosHealth -= goshosDamage;
					if (peshosHealth <= 0)
					{
						Console.WriteLine($"Gosho won in {count}th round.");
						break;
					}
					Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health."
);
				}
				if (i % 3 == 0)
				{
					goshosHealth += 10;
					peshosHealth += 10;
				}
				
			}

		}
	}
}
