using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Letters_Change_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Trim().Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var totalSum = 0.0m;

			for (int i = 0; i < input.Length; i++)
			{
				var inputTokens = input[i].ToCharArray();
				var sum = 0.0m;

				var leftLetter = inputTokens[0];
				var rightLetter = inputTokens[inputTokens.Length - 1];
				BigInteger number = GetNumber(inputTokens);

				sum = DoOperation(leftLetter, rightLetter, number);

				totalSum += sum;
			}

			Console.WriteLine($"{totalSum:f2}");
		}

		static decimal DoOperation(char leftLetter, char rightLetter, BigInteger number)
		{
			var sum = 0.0m;

			if (char.IsUpper(leftLetter))
			{
				sum = (decimal)number / GetLetterPosition(leftLetter);
			}
			else if (char.IsLower(leftLetter))
			{
				sum = (decimal)number * GetLetterPosition(leftLetter);
			}

			if (char.IsUpper(rightLetter))
			{
				sum = sum - GetLetterPosition(rightLetter);
			}
			else if (char.IsLower(rightLetter))
			{
				sum = sum + GetLetterPosition(rightLetter);
			}

			return sum;
		}

		static int GetLetterPosition(char letter)
		{
			letter = char.Parse(letter.ToString().ToLower());
			int index = letter - 96;
			return index;
		}

		static BigInteger GetNumber(char[] input)
		{
			var numberString = string.Empty;

			for (int i = 0; i < input.Length; i++)
			{
				if (char.IsDigit(input[i]))
				{
					numberString += input[i];
				}
			}

			var number = BigInteger.Parse(numberString);

			return number;
		}
	}
}
