using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int condensedNumber = CondenseArrayToNumber(nums);

			Console.WriteLine(condensedNumber);
		}

		private static int CondenseArrayToNumber(int[] nums)
		{
			int condensedNumber = 0;
			if(nums.Length == 0)
			{
				return nums[0];
			}
			else
			{
				while (nums.Length > 1)
				{
					int[] condensed = new int[nums.Length - 1];
					for (int i = 0; i < condensed.Length; i++)
					{
						condensed[i] = nums[i] + nums[i + 1];
					}
					nums = condensed;
				}
				condensedNumber = nums[0];
				return condensedNumber;
			}
		}
	}
}
