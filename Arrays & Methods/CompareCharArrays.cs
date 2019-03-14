using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
			char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
			int firstSum = 0;
			int secondSum = 0;

			for(int i = 0; i < firstArray.Length; i++)
			{
				firstSum += (int)firstArray[i];
			}
			for(int i = 0; i < secondArray.Length; i++)
			{
				secondSum += (int)secondArray[i];
			}
			if(firstSum >= secondSum)
			{
				Console.WriteLine(string.Join(string.Empty, secondArray));
				Console.WriteLine(string.Join(string.Empty, firstArray));
			}
			else
			{
				Console.WriteLine(string.Join(string.Empty, firstArray));
				Console.WriteLine(string.Join(string.Empty, secondArray));
			}
		}
	}
}
