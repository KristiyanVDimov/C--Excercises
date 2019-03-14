using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgraded_Matcher
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] productsNames = Console.ReadLine().Split().ToArray();
			long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
			decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
			string product = Console.ReadLine();
			List<long> quantitiesFromArray = new List<long>();

			for(int i = 0; i < quantities.Length; i++)
			{
				quantitiesFromArray.Add(quantities[i]);
			}
			for(int i = quantities.Length; i < productsNames.Length; i++)
			{
				quantitiesFromArray.Add(0);
			}

			while (!product.Equals("done"))
			{
				string[] name = product.Split().ToArray();
				long quantity1 = long.Parse(name[1]);
				decimal price = 0.0m;

				if(quantitiesFromArray[Array.IndexOf(productsNames, name[0])] < quantity1)
				{
					Console.WriteLine($"We do not have enough {name[0]}");
				}
				else
				{
					price = prices[Array.IndexOf(productsNames, name[0])] * quantity1;
					quantitiesFromArray[Array.IndexOf(productsNames, name[0])] -= quantity1;
					Console.WriteLine($"{productsNames[Array.IndexOf(productsNames, name[0])]} x {quantity1}" +
						$" costs {price:F2}");
				}
				product = Console.ReadLine();
			}
		}
	}
}
