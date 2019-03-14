using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Convert_from_base_10_to_base_N
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(' ').ToArray();

			var nBase = int.Parse(input[0]);
			var number = BigInteger.Parse(input[1]);

			var output = string.Empty;

			if(nBase >= 2 && nBase <= 10)
			{
				output = ConvertToNBase(number, nBase);
			}

			Console.WriteLine(output);
		}

		static string ConvertToNBase(BigInteger number, int nBase)
		{
			var digits = "0123456789ABCDEF";

			var tempStack = new Stack<BigInteger>();

			while (number > 0)
			{
				var temp = number % nBase;
				tempStack.Push(temp);
				number = number / nBase;
			}

			var output = string.Empty;

			while(tempStack.Count > 0)
			{
				output = output + digits[(int)tempStack.Pop()];
			}

			return output;
		}
	}
}
