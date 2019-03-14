using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
	class Program
	{
		static void Main(string[] args)
		{
			var cash = decimal.Parse(Console.ReadLine());
			var guests = int.Parse(Console.ReadLine());
			var bananaUnitPrice = decimal.Parse(Console.ReadLine());
			var eggsUnitPrice = decimal.Parse(Console.ReadLine());
			var berryPriceForKilo = decimal.Parse(Console.ReadLine());

			var sets = Math.Ceiling(guests / 6.0m);

			var productsPrice = sets * (2.0m * bananaUnitPrice) + sets * (4.0m * eggsUnitPrice) + sets * (0.2m * berryPriceForKilo);

			if(cash >= productsPrice)
			{
				Console.WriteLine($"Ivancho has enough money - it would cost {productsPrice:f2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivancho will have to withdraw money - he will need {(productsPrice - cash):f2}lv more.");
			}
		}
	}
}
