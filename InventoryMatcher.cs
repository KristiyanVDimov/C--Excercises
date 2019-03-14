using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Matcher
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] productsNames = Console.ReadLine().Split().ToArray();
			long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
			decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
			string product = Console.ReadLine();

			while (!product.Equals("done"))
			{
				Console.WriteLine($"{productsNames[Array.IndexOf(productsNames, product)]} costs:" +
					$" {prices[Array.IndexOf(productsNames, product)]}; Available quantity:" +
					$" {quantities[Array.IndexOf(productsNames, product)]}");
				product = Console.ReadLine();
			}
		}
	}
}
