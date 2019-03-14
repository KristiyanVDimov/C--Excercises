using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_floats
{
	class Program
	{
		public static void Main(string[] args)
		{
			double a = Math.Abs(double.Parse(Console.ReadLine()));
			double b = Math.Abs(double.Parse(Console.ReadLine()));
			double diff = Math.Abs(a - b);
			double eps = 0.000001;
			bool isEqual = true;
			if(diff < eps)
			{
				isEqual = true;
			}
			else if(diff >= eps)
			{
				isEqual = false;
			}

			Console.WriteLine(isEqual);

		}
		//public static bool NearlyEqual(double a, double b, double epsilon)
		//{
		//	double absA = Math.Abs(a);
		//	double absB = Math.Abs(b);
		//	double diff = Math.Abs(a - b);

		//	if (a == b)
		//	{
		//		return true;
		//	}
		//	else if (a == 0 || b == 0 || diff < Double.Epsilon)
		//	{
		//		return diff < epsilon;
		//	}
		//	else
		//	{
		//		return diff / (absA + absB) < epsilon;
		//	}
		//}
		//static void Main(string[] args)
		//{
		//	double a = double.Parse(Console.ReadLine());
		//	double b = double.Parse(Console.ReadLine());
		//	double eps = 0.000001;

		//	bool isEqual = NearlyEqual(a, b, eps);

		//	Console.WriteLine(isEqual);
			
		//}
	}
}
