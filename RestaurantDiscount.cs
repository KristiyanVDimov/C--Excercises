using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
	class Program
	{
		static void Main(string[] args)
		{
			var groupSize = int.Parse(Console.ReadLine());
			var discountType = Console.ReadLine();
			var hallName = "";
			var discount = 0.0;
			var price = 0.0;

			if (groupSize > 0 && groupSize <= 50)
			{
				hallName = "Small Hall";
				switch (discountType)
				{
					case "Normal":
						discount = (2500 + 500) * 0.05;
						price = ((2500 + 500) - discount) / groupSize;
						break;
					case "Gold":
						discount = (2500 + 750) * 0.10;
						price = ((2500 + 750) - discount) / groupSize;
						break;
					case "Platinum":
						discount = (2500 + 1000) * 0.15;
						price = ((2500 + 1000) - discount) / groupSize;
						break;
				}
				Console.WriteLine($"We can offer you the {hallName}");
				Console.WriteLine($"The price per person is {price:F2}$");
			}
			else if(groupSize > 50 && groupSize <= 100)
			{
				hallName = "Terrace";
				switch (discountType)
				{
					case "Normal":
						discount = (5000 + 500) * 0.05;
						price = ((5000 + 500) - discount) / groupSize;
						break;
					case "Gold":
						discount = (5000 + 750) * 0.10;
						price = ((5000 + 750) - discount) / groupSize;
						break;
					case "Platinum":
						discount = (5000 + 1000) * 0.15;
						price = ((5000 + 1000) - discount) / groupSize;
						break;
				}
				Console.WriteLine($"We can offer you the {hallName}");
				Console.WriteLine($"The price per person is {price:F2}$");
			}
			else if(groupSize > 100 && groupSize <= 120)
			{
				hallName = "Great Hall";
				switch (discountType)
				{
					case "Normal":
						discount = (7500 + 500) * 0.05;
						price = ((7500 + 500) - discount) / groupSize;
						break;
					case "Gold":
						discount = (7500 + 750) * 0.10;
						price = ((7500 + 750) - discount) / groupSize;
						break;
					case "Platinum":
						discount = (7500 + 1000) * 0.15;
						price = ((7500 + 1000) - discount) / groupSize;
						break;
				}
				Console.WriteLine($"We can offer you the {hallName}");
				Console.WriteLine($"The price per person is {price:F2}$");
			}
			else
			{
				Console.WriteLine("We do not have an appropriate hall.");
			}
		}
	}
}
