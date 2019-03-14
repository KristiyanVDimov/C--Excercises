using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var m = int.Parse(Console.ReadLine());
			var magicalNumber = int.Parse(Console.ReadLine());
			var count = 0;
			var isTrue = false;
			for(int i = m; i >= n; i--)
			{
				for(int j = m; j >= n; j--)
				{
					count++;
					if(i + j == magicalNumber)
					{
						isTrue = true;
						Console.WriteLine($"Number found! {i} + {j} = {magicalNumber}");
						break;
					}
				}
				if (isTrue)
				{
					break;
				}
			}
			if (!isTrue)
			{
				Console.WriteLine($"{count} combinations - neither equals {magicalNumber}");
			}
			
		}
	}
}
