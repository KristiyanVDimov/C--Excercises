using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			var count = 0;
			try
			{
				while (count <= 100)
				{
					var input = int.Parse(Console.ReadLine());
					count++;
				}
			}
			catch
			{
				Console.WriteLine(count);
				return;
			}
		}
	}
}
