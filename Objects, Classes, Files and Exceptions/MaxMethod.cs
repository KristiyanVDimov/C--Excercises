using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
	class Program
	{
		static int GetMax(int a, int b, int c)
		{
			if (a > b && a > c)
			{
				return a;
			}
			else if (b > a && b > c)
			{
				return b;
			}
			else
			{
				return c;
			}
		}
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());

			int max = GetMax(firstNumber, secondNumber, thirdNumber);

			Console.WriteLine(max);
		}
	}
}
