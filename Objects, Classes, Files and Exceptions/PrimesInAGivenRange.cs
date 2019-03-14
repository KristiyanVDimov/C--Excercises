using System;
using System.Collections.Generic;

namespace Primes_in_Given_Range
{
	class Program
	{
		static List<int> FindPrimesInRange(int startNum, int endNum)
		{
			List<int> primeNumbers = new List<int>();

			for (int num = startNum; num <= endNum; num++)
			{
				if (IsPrime(num))
				{
					primeNumbers.Add(num);
				}
			}

			return primeNumbers;
		}

		private static bool IsPrime(int num)
		{
			if (num == 0 || num == 1)
			{
				return false;
			}
			if (num == 2)
			{
				return true;
			}

			for (int j = 2; j <= Math.Sqrt(num); ++j)
			{
				if (num % j == 0)
				{
					return false;
				}
			}

			return true;
		}

		static void Main(string[] args)
		{
			int startNum = int.Parse(Console.ReadLine());
			int endNum = int.Parse(Console.ReadLine());

			List<int> primeNumbers = new List<int>();

			primeNumbers = FindPrimesInRange(startNum, endNum);

			Console.WriteLine(string.Join(", ", primeNumbers));

			Console.WriteLine();
		}
	}
}
