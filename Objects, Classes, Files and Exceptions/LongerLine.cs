using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
	class Program
	{
		static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			double x3 = double.Parse(Console.ReadLine());
			double y3 = double.Parse(Console.ReadLine());
			double x4 = double.Parse(Console.ReadLine());
			double y4 = double.Parse(Console.ReadLine());

			CheckIsLine1LongerThanLine2AndPrint(x1, y1, x2, y2, x3, y3, x4, y4);
		}

		static void CheckIsLine1LongerThanLine2AndPrint(double x1, double y1, double x2, double y2,
			double x3, double y3, double x4, double y4)
		{ 
			double line1Distance = CalculateDistanceBetweenTwoLines(x1, y1, x2, y2);
			double line2Distance = CalculateDistanceBetweenTwoLines(x3, y3, x4, y4);

			if(line1Distance >= line2Distance)
			{
				IsPoint1CloserThanPoint2AndPrint(x1, y1, x2, y2);
			}
			else
			{
				IsPoint1CloserThanPoint2AndPrint(x3, y3, x4, y4);
			}
		}

		static void IsPoint1CloserThanPoint2AndPrint(double x1, double y1, double x2, double y2)
		{
			double distance1 = CalculateDistanceBetweenTwoPoints(x1, y1, 0, 0);
			double distance2 = CalculateDistanceBetweenTwoPoints(x2, y2, 0, 0);

			if (distance1 > distance2)
			{
				Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
			}
			else
			{
				Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
			}
		}

		static double CalculateDistanceBetweenTwoPoints(double x1, double y1, int x2, int y2)
		{
			double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

			return distance;
		}

		static double CalculateDistanceBetweenTwoLines(double x1, double y1, double x2, double y2)
		{
			double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

			return distance;
		}
	}
}
