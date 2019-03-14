using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr = Console.ReadLine().Split().ToArray();
			int n = int.Parse(Console.ReadLine());
			string[] newArr = new string[arr.Length];

			for (int i = 0; i < n; i++)
			{
				string[] command = Console.ReadLine().Split().ToArray();

				newArr = DoCommand(arr, command);

				arr = newArr;
			}

			Console.WriteLine(string.Join(", ", arr));
		}

		static string[] DoCommand(string[] array, string[] command)
		{
			string[] newArray = new string[array.Length];
			string com = command[0];

			switch (com)
			{
				case "Reverse":
					newArray = array.Reverse().ToArray();
					array = newArray;
					break;
				case "Distinct":
					newArray = array.Distinct().ToArray();
					array = newArray;
					break;
				case "Replace":
					int index = int.Parse(command[1]);
					string newString = command[2].ToString();
					for (int i = 0; i < array.Length; i++)
					{
						newArray[i] = array[i];
					}
					newArray[index] = newString;
					array = newArray;
					break;
			}
			return array;
		}
	}
}
