using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
	class Program
	{
		static int Fibonacci(int number)
		{
			int firstNumber = 0;
			int secondNumber = 1;
			int result = 0;
			
			if (number == 0 || number == 1)
			{
				return 1;
			}
			else
			{
				for (int i = 1; i <= number; i++)
				{
					result = firstNumber + secondNumber;
					firstNumber = secondNumber;
					secondNumber = result;
				}
			}
			
			return result;
		}

		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int fibonacciNumber = Fibonacci(number);

			Console.WriteLine(fibonacciNumber);
		}
	}
}
