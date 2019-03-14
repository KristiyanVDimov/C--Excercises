using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			var proffesion = Console.ReadLine();
			var quantity = int.Parse(Console.ReadLine());
			var price = 0.0;

			if (proffesion.Equals("Athlete"))
			{
				price = 0.70 * quantity;
				Console.WriteLine($"The {proffesion} has to pay {price:F2}.");
			}
			else if (proffesion.Equals("Businessman") || proffesion.Equals("Businesswoman"))
			{
				price = 1.00 * quantity;
				Console.WriteLine($"The {proffesion} has to pay {price:F2}.");
			}
			else if (proffesion.Equals("SoftUni Student"))
			{
				price = 1.70 * quantity;
				Console.WriteLine($"The {proffesion} has to pay {price:F2}.");
			}
			else
			{
				price = 1.20 * quantity;
				Console.WriteLine($"The {proffesion} has to pay {price:F2}.");
			}
		}
	}
}
