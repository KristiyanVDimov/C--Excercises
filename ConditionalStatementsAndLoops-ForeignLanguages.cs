using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreign_Languages
{
	class Program
	{
		static void Main(string[] args)
		{
			var country = Console.ReadLine().ToLower();

			if (country.Equals("england") || country.Equals("usa"))
			{
				Console.WriteLine("English");
			}
			else if(country.Equals("spain") || country.Equals("argentina") || country.Equals("mexico"))
			{
				Console.WriteLine("Spanish");
			}
			else
			{
				Console.WriteLine("unknown");
			}
		}
	}
}
