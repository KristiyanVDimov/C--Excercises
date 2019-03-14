using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
	class Program
	{
		static void Main(string[] args)
		{
			var ingredient = Console.ReadLine();
			var count = 0;
			while (count <= 20)
			{
				Console.WriteLine($"Adding ingredient {ingredient}.");
				ingredient = Console.ReadLine();
				count++;
				if (ingredient.Equals("Bake!"))
				{
					Console.WriteLine($"Preparing cake with {count} ingredients.");
					break;
				}
			}
		}
	}
}
