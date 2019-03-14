using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int leftSum = 0;
			int rightSum = 0;
			int elementIndex = 0;
			bool isEqual = false;

			for(int i = 0; i < arr.Length; i++)
			{
				for(int leftIndex = 0; leftIndex < i; leftIndex++)
				{
					leftSum += arr[leftIndex];
				}
				for(int rightIndex = i + 1; rightIndex < arr.Length; rightIndex++)
				{
					rightSum += arr[rightIndex];
				}
				if(leftSum == rightSum)
				{
					elementIndex = i;
					isEqual = true;
				}
				leftSum = 0;
				rightSum = 0;
			}

			if (isEqual)
			{
				Console.WriteLine(elementIndex);
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}
