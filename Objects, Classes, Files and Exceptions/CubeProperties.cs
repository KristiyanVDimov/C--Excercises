using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
	class Program
	{
		static void Main(string[] args)
		{
			double side = double.Parse(Console.ReadLine());
			string parameter = Console.ReadLine();
			double result = 0.0;

			switch (parameter)
			{
				case "face":
					result = CalculateLenghtOfFaceDiagonals(side);
					break;
				case "space":
					result = CalculateLenghtOfSpaceDiagonals(side);
					break;
				case "volume":
					result = CalculateVolume(side);
					break;
				case "area":
					result = CalculateArea(side);
					break;
			}

			Console.WriteLine($"{result:F2}");
		}

		static double CalculateArea(double side)
		{
			double result = 6 * Math.Pow(side, 2);
			return result;
		}

		static double CalculateVolume(double side)
		{
			double result = Math.Pow(side, 3);
			return result;
		}

		static double CalculateLenghtOfSpaceDiagonals(double side)
		{
			double result = Math.Sqrt(3 * Math.Pow(side, 2));
			return result;
		}

		static double CalculateLenghtOfFaceDiagonals(double side)
		{
			double result = Math.Sqrt(2 * Math.Pow(side, 2));
			return result;
		}
	}
}
