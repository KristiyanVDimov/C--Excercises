using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string figureType = Console.ReadLine();
			double area = 0.0;
			double side = 0.0;
			double height = 0.0;

			switch (figureType)
			{
				case "triangle":
					side = double.Parse(Console.ReadLine());
					height = double.Parse(Console.ReadLine());
					area = CalculateTriangleArea(side, height);
					break;
				case "square":
					side = double.Parse(Console.ReadLine());
					area = CalculateSquareArea(side);
					break;
				case "rectangle":
					double width = double.Parse(Console.ReadLine());
					height = double.Parse(Console.ReadLine());
					area = CalculateRectangleArea(width, height);
					break;
				case "circle":
					double radius = double.Parse(Console.ReadLine());
					area = CalculateCircleArea(radius);
					break;
			}

			Console.WriteLine($"{area:F2}");
		}

		private static double CalculateCircleArea(double radius)
		{
			double area = Math.PI * Math.Pow(radius, 2);
			return area;
		}

		private static double CalculateRectangleArea(double width, double height)
		{
			double area = width * height;
			return area;
		}

		private static double CalculateSquareArea(double side)
		{
			double area = Math.Pow(side, 2);
			return area;
		}

		private static double CalculateTriangleArea(double side, double height)
		{
			double area = (side * height) / 2;
			return area;
		}
	}
}
