using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			var budget = double.Parse(Console.ReadLine());
			var numberOfItems = int.Parse(Console.ReadLine());
			var subTotal = 0.0;
			for(int i = 1; i <= numberOfItems; i++)
			{
				var itemName = Console.ReadLine();
				var itemPrice = double.Parse(Console.ReadLine());
				var itemsCount = int.Parse(Console.ReadLine());
				if(itemsCount > 1)
				{
					Console.WriteLine($"Adding {itemsCount} {itemName}s to cart.");
				}
				else
				{
					Console.WriteLine($"Adding {itemsCount} {itemName} to cart.");
				}
				subTotal += itemPrice * itemsCount;
			}
			Console.WriteLine($"Subtotal: ${subTotal:F2}");
			if(budget >= subTotal)
			{
				Console.WriteLine($"Money left: ${(budget - subTotal):F2}");
			}
			else
			{
				Console.WriteLine($"Not enough. We need ${(subTotal - budget):F2} more.");
			}
		}
	}
}
