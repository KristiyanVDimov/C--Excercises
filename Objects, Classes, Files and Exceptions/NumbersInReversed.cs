using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
	class Program
	{
		static double GetNumberInReverse(string number)
		{
			char[] num = number.ToCharArray();
			string reversedNumber = string.Empty;
			
			for(int i = number.Length - 1; i > -1; i--)
			{
				reversedNumber += num[i];
			}
			return Convert.ToDouble(reversedNumber);
		}

		static void Main(string[] args)
		{
			string number = Console.ReadLine();

			double reverseNumber = GetNumberInReverse(number);

			Console.WriteLine(reverseNumber);
		}
	}
}
