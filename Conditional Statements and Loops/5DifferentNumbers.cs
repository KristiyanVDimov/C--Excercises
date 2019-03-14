using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Different_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			if(b - a < 5)
			{
				Console.WriteLine("No");
			}
			for (int i = a; i <= b; i++)
			{
				for(int j = a; j <= b; j++)
				{
					for(int k = a; k <= b; k++)
					{
						for(int l = a; l <= b; l++)
						{
							for(int o = a; o <= b; o++)
							{
								if(a <= i && i < j && j < k && k < l && l < o && o <= b)
								{
									Console.WriteLine($"{i} {j} {k} {l} {o}");
								}
							}
						}
					}
				}
			}
		}
	}
}
