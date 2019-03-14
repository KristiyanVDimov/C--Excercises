using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Database
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = string.Empty;
			var prices = new Dictionary<string, double>();
			var quantities = new Dictionary<string, int>();

			while((input = Console.ReadLine()) != "stocked")
			{
				var products = input.Split(' ').ToArray();

				if(!prices.ContainsKey(products[0]) && !quantities.ContainsKey(products[0]))
				{
					prices.Add(products[0], double.Parse(products[1]));
					quantities.Add(products[0], int.Parse(products[2]));
				}
				else
				{
					prices[products[0]] = double.Parse(products[1]);
					quantities[products[0]] += int.Parse(products[2]);
				}
			}
			var totalPrice = 0.0;
			foreach (var price in prices)
			{
				foreach (var quantity in quantities)
				{
					if(price.Key == quantity.Key)
					{
						var productPrice = price.Value * quantity.Value;
						totalPrice += productPrice;
						Console.WriteLine($"{price.Key}: ${price.Value:F2} * {quantity.Value} = ${productPrice:F2}");
					}
				}
			}
			Console.WriteLine(new string('-', 30));
			Console.WriteLine($"Grand Total: ${totalPrice:F2}");
		}
	}
}
