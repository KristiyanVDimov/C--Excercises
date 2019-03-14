using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			var special = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int bomb = special[0];
			int power = special[1];

			for(int i = 0; i < numbers.Count; i++)
			{
				if(numbers[i] == bomb)
				{
					int leftIndex = Math.Max(i - power, 0);
					int rightIndex = Math.Min(i + power, numbers.Count - 1);

					numbers.RemoveRange(i, rightIndex - i);
					numbers.RemoveAt(i);
					numbers.RemoveRange(leftIndex, i - leftIndex);

					i = 0;
				}
			}
			Console.WriteLine(numbers.Sum());

			//for(int i = 0; i < numbers.Count; i++)
			//{
			//	if(numbers[i] == special[0])
			//	{
			//		int leftIndex = Math.Max(i - special[1], 0);
			//		int rightIndex = Math.Min(i + special[1], numbers.Count - 1);

			//		numbers.RemoveRange(i, rightIndex - i);
			//		numbers.RemoveAt(i);
			//		numbers.RemoveRange(i, i - leftIndex);

			//		i = 0;
			//	}
			//}
			//Console.WriteLine(numbers.Sum());
		}
	}
}
