using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int start = 0;
			int len = 1;
			int bestStart = 0;
			int bestLen = 1;

			for (int pos = 1; pos <= arr.Length - 1; pos++)
			{
				if (arr[start] == arr[pos])
				{
					len++;
					if(len > bestLen)
					{
						bestStart = start;
						bestLen = len;
					}
				}
				else
				{
					start = pos;
					len = 1;
				}
			}
			for (int i = bestStart; i < bestStart + bestLen; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}
}
