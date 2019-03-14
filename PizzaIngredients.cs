using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ingredients
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr = Console.ReadLine().Split().ToArray();
			int ingredientLenght = int.Parse(Console.ReadLine());
			List<string> ingredients = new List<string>();

			for(int i = 0; i < arr.Length; i++)
			{
				if(arr[i].Length == ingredientLenght)
				{
					ingredients.Add(arr[i]);
				}
				if(ingredients.Count == 10)
				{
					break;
				}
			}
			for(int i = 0; i < ingredients.Count; i++)
			{
				Console.WriteLine($"Adding {ingredients[i]}.");
			}
			Console.WriteLine($"Made pizza with total of {ingredients.Count} ingredients.");
			Console.WriteLine($"The ingredients are: {string.Join(", ", ingredients)}.");
		}
	}
}
