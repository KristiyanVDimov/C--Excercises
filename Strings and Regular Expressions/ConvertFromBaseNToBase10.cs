using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Convert_from_base_N_to_base_10
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(' ').ToArray();
			var nBase = int.Parse(input[0]);
			var number = input[1].ToCharArray();

			var output = ConvertToBase10(number, nBase);

			Console.WriteLine(output);
		}

		static BigInteger ConvertToBase10(char[] number, int nBase)
		{
			BigInteger output = new BigInteger(0);

			for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
			{
				BigInteger numChar = new BigInteger(char.GetNumericValue(number[n]));
				BigInteger sum = BigInteger.Multiply(numChar, BigInteger.Pow(new BigInteger(nBase), i));
				
				output += sum;
			}

			return output;
		}
	}
}
