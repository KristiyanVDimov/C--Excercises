using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Morse_Code_Upgraded
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var messageTokens = input.Trim().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var message = string.Empty;

			for (int i = 0; i < messageTokens.Length; i++)
			{
				var letter = GetLetter(messageTokens[i]);
				message += letter;
			}

			Console.WriteLine(message);
		}

		private static char GetLetter(string str)
		{
			var sum = 0;
			var onesCounter = 0;
			var zerosCounter = 0;

			Regex one = new Regex(@"1+");
			Regex zero = new Regex(@"0+");

			var onesMatches = one.Matches(str);
			var zeroesMatches = zero.Matches(str);

			var onesSeq = 0;
			var zeroesSeq = 0;

			foreach (Match ones in onesMatches)
			{
				if(ones.Value.Length > 1)
				{
					onesSeq += ones.Value.Length;
				}
			}

			foreach (Match zeroes in zeroesMatches)
			{
				if(zeroes.Value.Length > 1)
				{
					zeroesSeq += zeroes.Value.Length;
				}
			}

			for (int i = 0; i < str.Length; i++)
			{
				if(str[i] == '1')
				{
					onesCounter++;
				}
				if(str[i] == '0')
				{
					zerosCounter++;
				}
			}

			sum += onesCounter * 5 + zerosCounter * 3 + onesSeq + zeroesSeq;

			return (char)sum;
		}
	}
}
