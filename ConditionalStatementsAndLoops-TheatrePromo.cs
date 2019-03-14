using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Promotions
{
	class Program
	{
		static void Main(string[] args)
		{
			var dayType = Console.ReadLine().ToLower();
			var age = int.Parse(Console.ReadLine());
			var price = 0;

			switch (dayType)
			{
				case "weekday":
					if (age >= 0 && age <= 18)
					{
						price = 12;
						Console.WriteLine($"{price}$");
					}
					else if(age > 18 && age <= 64)
					{
						price = 18;
						Console.WriteLine($"{price}$");
					}
					else if (age > 64 && age <= 122)
					{
						price = 12;
						Console.WriteLine($"{price}$");
					}
					else
					{
						Console.WriteLine("Error!");
					}
					break;
				case "weekend":
					if (age >= 0 && age <= 18)
					{
						price = 15;
						Console.WriteLine($"{price}$");
					}
					else if (age > 18 && age <= 64)
					{
						price = 20;
						Console.WriteLine($"{price}$");
					}
					else if (age > 64 && age <= 122)
					{
						price = 15;
						Console.WriteLine($"{price}$");
					}
					else
					{
						Console.WriteLine("Error!");
					}
					break;
				case "holiday":
					if (age >= 0 && age <= 18)
					{
						price = 5;
						Console.WriteLine($"{price}$");
					}
					else if (age > 18 && age <= 64)
					{
						price = 12;
						Console.WriteLine($"{price}$");
					}
					else if(age > 64 && age <= 122)
					{
						price = 10;
						Console.WriteLine($"{price}$");
					}
					else
					{
						Console.WriteLine("Error!");
					}
					break;
			}
			
		}
	}
}
