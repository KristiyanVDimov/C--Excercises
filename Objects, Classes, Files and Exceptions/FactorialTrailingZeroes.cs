using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int trailingZeroes = GetFactorialTrailingZeroes(number);

			Console.WriteLine(trailingZeroes);
		}

		private static int GetFactorialTrailingZeroes(int number)
		{
			BigInteger factorial = GetFactorial(number);
			int count = 0;

			while(factorial > 0)
			{
				BigInteger digit = factorial % 10;
				if (digit == 0)
				{
					count++;
				}
				else
				{
					break;
				}
				factorial /= 10;
			}

			return count;
		}

		private static BigInteger GetFactorial(int number)
		{
			BigInteger factorial = 1;

			for (int i = 1; i <= number; i++)
			{
				factorial *= i;
			}
			return factorial;
		}
	}
}
