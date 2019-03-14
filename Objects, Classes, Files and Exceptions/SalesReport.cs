using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
	class Sale
	{
		public string Town { get; set; }
		public string Product { get; set; }
		public decimal Price { get; set; }
		public decimal Quantity { get; set; }

		public static Sale ReadSale()
		{
			var saleInfo = Console.ReadLine().Split(' ').ToArray();

			Sale sale = new Sale();

			sale.Town = saleInfo[0];
			sale.Product = saleInfo[1];
			sale.Price = decimal.Parse(saleInfo[2]);
			sale.Quantity = decimal.Parse(saleInfo[3]);

			return sale;
		}

		public static void PrintResult(SortedDictionary<string, decimal> salesByTown)
		{
			foreach (var sale in salesByTown)
			{
				Console.WriteLine($"{sale.Key} -> {sale.Value:F2}");
			}
		}

		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			var salesByTown = new SortedDictionary<string, decimal>();

			for (int i = 0; i < n; i++)
			{
				Sale sale = ReadSale();

				if (!salesByTown.ContainsKey(sale.Town))
				{
					salesByTown.Add(sale.Town, (sale.Price * sale.Quantity));
				}
				else
				{
					salesByTown[sale.Town] += sale.Price * sale.Quantity;
				}
			}

			PrintResult(salesByTown);
		}
	}
}
