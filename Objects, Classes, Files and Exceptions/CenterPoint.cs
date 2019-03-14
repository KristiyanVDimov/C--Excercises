using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
	class Program
	{
		static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());

			if (IsPoint1ShorterThanPoint2(x1, y1, x2, y2))
			{
				Console.WriteLine($"({x1}, {y1})");
			}
			else
			{
				Console.WriteLine($"({x2}, {y2})");
			}
		}

		private static bool IsPoint1ShorterThanPoint2(double x1, double y1, double x2, double y2)
		{
			var distance1 = CalculateDistanceBetweenTwoPoints(x1, y1, 0, 0);
			var distance2 = CalculateDistanceBetweenTwoPoints(x2, y2, 0, 0);

			if (distance1 < distance2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private static double CalculateDistanceBetweenTwoPoints(double x1, double y1, int x2, int y2)
		{
			var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

			return distance;
		}
	}
}
