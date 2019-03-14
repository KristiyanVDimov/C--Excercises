using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_Of_ASCII_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			int startIndex = int.Parse(Console.ReadLine());
			int finishIndex = int.Parse(Console.ReadLine());

			char startChar = (char)startIndex;
			char finishChar = (char)finishIndex;
			for(char i = startChar; i <= finishChar; i++)
			{
				Console.Write(i + " ");
			}
		}
	}
}
