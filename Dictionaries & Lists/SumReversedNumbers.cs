using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			
			for(int i = 0; i < numbers.Count; i++)
			{
				numbers[i] = ReverseNumber(numbers[i]);
			}

			Console.WriteLine(numbers.Sum());
		}

		static int ReverseNumber(int number)
		{
			char[] num = number.ToString().ToCharArray();
			num = num.Reverse().ToArray();
			number = int.Parse(string.Join("", num));
			return number;
		}
	}
}
