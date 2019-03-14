using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int rotationCount = int.Parse(Console.ReadLine());
			int[] sumArray = new int[numbers.Length];

			for(int i = 0; i < rotationCount; i++)
			{
				RotateArray(numbers);
				
				for(int j = 0; j < numbers.Length; j++)
				{
					sumArray[j] += numbers[j];
				}
			}
			Console.WriteLine(string.Join(" ", sumArray));
			

		}

		private static void RotateArray(int[] array)
		{
			int temp = array[array.Length - 1];
			for (int i = array.Length - 1; i > 0; i--)
			{
				array[i] = array[i - 1];
			}
			array[0] = temp;
		}
	}
}
