using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				if (IsPalindrom(i) && SumOfDigits(i) % 7 == 0 && ContainsEvenDigit(i))
				{
					Console.WriteLine(i);
				}
			}
		}

		private static bool ContainsEvenDigit(int number)
		{
			bool isEven = true;
			while(number > 0)
			{
				int digit = number % 10;
				if (digit % 2 == 0)
				{
					isEven = true;
					break;
				}
				else
				{
					isEven = false;
				}
				number /= 10;
			}
			return isEven;
		}

		private static int SumOfDigits(int number)
		{
			int sumOfDigits = 0;

			while(number > 0)
			{
				int digit = number % 10;
				sumOfDigits += digit;
				number /= 10;
			}

			return sumOfDigits;
		}

		private static bool IsPalindrom(int number)
		{
			int num = number;
			int reversedNumber = 0;

			while (num > 0)
			{
				int digit = num % 10;
				reversedNumber = reversedNumber * 10 + digit;
				num /= 10;
			}

			if(number == reversedNumber)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
