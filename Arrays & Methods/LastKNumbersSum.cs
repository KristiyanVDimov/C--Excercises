using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums
{
	class Program
	{
		static void Main(string[] args)
		{
			long n = long.Parse(Console.ReadLine());
			long k = long.Parse(Console.ReadLine());
			long[] seq = new long[n];
			seq[0] = 1;
			long sum = 0;

			for (long i = 1; i < n; i++)
			{
				if (i < k)
				{
					sum += seq[i - 1];
					seq[i] = sum;
				}
				else
				{
					sum = 0;
					for (long j = i - k; j <= i - 1; j++)
					{
						sum += seq[j];
						seq[i] = sum;
					}
				}
				
			}
			Console.WriteLine(String.Join(" ", seq));
		}
	}
}
