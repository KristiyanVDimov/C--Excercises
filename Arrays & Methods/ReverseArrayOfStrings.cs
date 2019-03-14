using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr = Console.ReadLine().Split(' ').ToArray();

			string[] reversedArr = arr.Reverse().ToArray();

			Console.WriteLine(string.Join(" ", reversedArr));
		}
	}
}
