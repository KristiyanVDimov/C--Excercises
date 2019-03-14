using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_between_Points
{
	class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		static Point ReadPoint()
		{
			var pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Point point = new Point();

			point.X = pointInfo[0];
			point.Y = pointInfo[1];

			return point;
		}

		static double CalcDistance(Point p1, Point p2)
		{
			int sideA = Math.Abs(p1.X - p2.X);
			int sideB = Math.Abs(p1.Y - p2.Y);

			return Math.Sqrt(sideA * sideA + sideB * sideB);
		}

		static void Main()
		{
			Point p1 = ReadPoint();
			Point p2 = ReadPoint();

			Console.WriteLine($"{CalcDistance(p1, p2):F3}");
		}
	}
}
