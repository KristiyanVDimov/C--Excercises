using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstNumber = int.Parse(Console.ReadLine());
			var secondNumber = int.Parse(Console.ReadLine());

			if(firstNumber < secondNumber)
			{
				for(int i = firstNumber; i <= secondNumber; i++)
				{
					Console.WriteLine(i);
				}
			}
			else
			{
				for(int i = secondNumber; i <= firstNumber; i++)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
