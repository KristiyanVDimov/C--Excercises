using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			
			var totalCaloriesAmount = 0;

			for(int i = 0; i < n; i++)
			{
				var ingredient = Console.ReadLine().ToLower();
				if (ingredient.Equals("cheese"))
				{
					totalCaloriesAmount += 500;
				}
				else if(ingredient.Equals("tomato sauce"))
				{
					totalCaloriesAmount += 150;
				}
				else if (ingredient.Equals("salami"))
				{
					totalCaloriesAmount += 600;
				}
				else if (ingredient.Equals("pepper"))
				{
					totalCaloriesAmount += 50;
				}
			}
			Console.WriteLine($"Total calories: {totalCaloriesAmount}");
		}
	}
}
