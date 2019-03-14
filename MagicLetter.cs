using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstLetter = Console.ReadLine();
			var secondLetter = Console.ReadLine();
			var thirdLetter = Console.ReadLine();

			for(char i = firstLetter.ToCharArray()[0]; i <= secondLetter.ToCharArray()[0]; i++)
			{
				for (char j = firstLetter.ToCharArray()[0]; j <= secondLetter.ToCharArray()[0]; j++)
				{
					for (char k = firstLetter.ToCharArray()[0]; k <= secondLetter.ToCharArray()[0]; k++)
					{
						if (i == thirdLetter.ToCharArray()[0] || j == thirdLetter.ToCharArray()[0] || k == thirdLetter.ToCharArray()[0])
						{

						}
						else
						{
							string sumOfChars = (i + "" + j + "" + k).ToString();
							Console.Write(sumOfChars + " ");
						}
					}
				}
			}
		}
	}
}
