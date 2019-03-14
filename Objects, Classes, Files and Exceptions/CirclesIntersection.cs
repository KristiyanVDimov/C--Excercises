using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles_Intersection
{
	class Point
	{
		public double X { get; set; }
		public double Y { get; set; }

		
	}

	class Circle
	{
		public Point Center { get; set; }
		public double Radius { get; set; }

		public static double CalcDistance(Point p1, Point p2)
		{
			double sideA = Math.Abs(p1.X - p2.X);
			double sideB = Math.Abs(p1.Y - p2.Y);

			return Math.Sqrt(sideA * sideA + sideB * sideB);
		}

		public static Circle ReadCircle()
		{
			var circleInfo = Console.ReadLine().Split(' ').ToArray();
			Circle circle = new Circle();
			Point point = new Point();
			point.X = double.Parse(circleInfo[0]);
			point.Y = double.Parse(circleInfo[1]);
			circle.Center = point;
			circle.Radius = double.Parse(circleInfo[2]);

			return circle;
		}

		public static bool Intersect(Circle c1, Circle c2)
		{
			if(CalcDistance(c1.Center, c2.Center) <= (c1.Radius + c2.Radius))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	class Program : Circle
	{
		static void Main()
		{
			Circle c1 = ReadCircle();
			Circle c2 = ReadCircle();

			bool doIntersect = Intersect(c1, c2);

			if (doIntersect)
			{
				Console.WriteLine("Yes");
				return;
			}
			Console.WriteLine("No");
		}
	}
}
