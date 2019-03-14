using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
{
	class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public static Point ReadPoint()
		{
			var pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Point point = new Point();

			point.X = pointInfo[0];
			point.Y = pointInfo[1];

			return point;
		}

		public static double CalcDistance(Point p1, Point p2)
		{
			int sideA = Math.Abs(p1.X - p2.X);
			int sideB = Math.Abs(p1.Y - p2.Y);

			return Math.Sqrt(sideA * sideA + sideB * sideB);
		}

		public static Point[] ReadPoints()
		{
			int n = int.Parse(Console.ReadLine());

			Point[] points = new Point[n];

			for (int i = 0; i < n; i++)
			{
				points[i] = ReadPoint();
			}

			return points;
		}

		public static Point[] FindClosestPoints(Point[] points)
		{
			double minDist = double.MaxValue;
			Point[] closestPoints = null;

			for (int point1 = 0; point1 < points.Length; point1++)
			{
				for(int point2 = point1 + 1; point2 < points.Length; point2++)
				{
					double distance = CalcDistance(points[point1], points[point2]);
					if(minDist > distance)
					{
						minDist = distance;
						closestPoints = new Point[] { points[point1], points[point2] };
					}
				}
			}

			return closestPoints;
		}

		public static void PrintPoint(Point point)
		{
			Console.WriteLine($"({point.X}, {point.Y})");
		}

		public static void PrintDistance(Point[] points)
		{
			double distance = CalcDistance(points[0], points[1]);

			Console.WriteLine($"{distance:F3}");
		}
	}

	class ClosestTwoPoints : Point
	{
		static void Main()
		{
			Point[] points = ReadPoints();
			Point[] closestPoints = FindClosestPoints(points);

			PrintDistance(closestPoints);

			PrintPoint(closestPoints[0]);
			PrintPoint(closestPoints[1]);
		}
	}
	
}
