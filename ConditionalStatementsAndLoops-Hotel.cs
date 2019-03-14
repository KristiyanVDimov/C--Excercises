using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			var month = Console.ReadLine();
			var nightsCount = int.Parse(Console.ReadLine());
			var studioPrice = 0.0;
			var doublePrice = 0.0;
			var suitePrice = 0.0;

			if(month.Equals("May") || month.Equals("October"))
			{
				studioPrice = 50 * nightsCount;
				doublePrice = 65 * nightsCount;
				suitePrice = 75 * nightsCount;
				if (month.Equals("October") && nightsCount > 7)
				{
					studioPrice = studioPrice - 50;
				}
				if (nightsCount > 7)
				{
					studioPrice = studioPrice * 0.95;
				}
			}
			else if(month.Equals("June") || month.Equals("September"))
			{
				studioPrice = 60 * nightsCount;
				doublePrice = 72 * nightsCount;
				suitePrice = 82 * nightsCount;
				if (month.Equals("September") && nightsCount > 7)
				{
					studioPrice = studioPrice - 60;
				}
				if (nightsCount >= 14)
				{
					doublePrice = doublePrice * 0.90;
				}
			}
			else if(month.Equals("July") || month.Equals("August") || month.Equals("December"))
			{
				studioPrice = 68 * nightsCount;
				doublePrice = 77 * nightsCount;
				suitePrice = 89 * nightsCount;
				if(nightsCount > 14)
				{
					suitePrice = suitePrice * 0.85;
				}
			}
			Console.WriteLine($"Studio: {studioPrice:F2} lv.");
			Console.WriteLine($"Double: {doublePrice:F2} lv.");
			Console.WriteLine($"Suite: {suitePrice:F2} lv.");

		}
	}
}
