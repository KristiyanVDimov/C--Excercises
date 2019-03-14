using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_Sequences
{
	class Program
	{
		static void Main(string[] args)
		{
			var matchSum = int.Parse(Console.ReadLine());
			var a = 'A';
			var c = 'C';
			var g = 'G';
			var t = 'T';

			for(char i = a; i <= t; i++)
			{
				for(char j = a; j <= t; j++)
				{
					for(char k = a; k <= t; k++)
					{
						if(i == 'A' || i == 'C' || i == 'G' || i == 'T')
						{
							if(j == 'A' || j == 'C' || j == 'G' || j == 'T')
							{
								if(k == 'A' || k == 'C' || k == 'G' || k == 'T')
								{
									var sum = 0;
									switch (i)
									{
										case 'A': sum++; break;
										case 'C': sum += 2; break;
										case 'G': sum += 3; break;
										case 'T': sum += 4; break;
									}
									switch (j)
									{
										case 'A': sum++; break;
										case 'C': sum += 2; break;
										case 'G': sum += 3; break;
										case 'T': sum += 4; break;
									}
									switch (k)
									{
										case 'A': sum++; break;
										case 'C': sum += 2; break;
										case 'G': sum += 3; break;
										case 'T': sum += 4; break;
									}
									if(sum >= matchSum)
									{
										Console.Write("O{0}{1}{2}O ", i, j, k);
									}
									else
									{
										Console.Write("X{0}{1}{2}X ", i, j, k);
									}
									if(k == 'T')
									{
										Console.WriteLine();
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
