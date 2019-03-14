using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink
{
	class Program
	{
		static void Main(string[] args)
		{
			var proffesion = Console.ReadLine().ToLower();

			if (proffesion.Equals("athlete"))
			{
				Console.WriteLine("Water");
			}
			else if(proffesion.Equals("businessman") || proffesion.Equals("businesswoman"))
			{
				Console.WriteLine("Coffee");
			}
			else if(proffesion.Equals("softuni student"))
			{
				Console.WriteLine("Beer");
			}
			else
			{
				Console.WriteLine("Tea");
			}
		}
	}
}
