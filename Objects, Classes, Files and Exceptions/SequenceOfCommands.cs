using System;
using System.Linq;

public class SequenceOfCommands_broken
{
	private const char ArgumentsDelimiter = ' ';

	public static void Main()
	{
		int sizeOfArray = int.Parse(Console.ReadLine());

		long[] array = Console.ReadLine()
			.Split(ArgumentsDelimiter)
			.Select(long.Parse)
			.ToArray();

		string[] command = new string[] {string.Empty};
		
		while (!command[0].Equals("stop"))
		{
			string line = Console.ReadLine();
			command = line.Split(ArgumentsDelimiter);
			if (command[0].Equals("stop"))
			{
				break;
			}
			long[] newArray = array.Clone() as long[];
			//string line = command.Trim();
			int[] args = new int[2];

			if (command[0].Equals("add") ||
				command[0].Equals("subtract") ||
				command[0].Equals("multiply"))
			{
				string[] stringParams = command;
				args[0] = int.Parse(stringParams[1]);
				args[1] = int.Parse(stringParams[2]);

				array = PerformAction(newArray, command[0], args);
			}
			else
			{
				newArray = PerformAction(array, command[0], args);
			}
			
			PrintArray(array);
		}
	}

	static long[] PerformAction(long[] arr, string action, int[] args)
	{
		long[] array = arr.Clone() as long[];
		int pos = (int)args[0] - 1;
		int value = args[1];

		switch (action)
		{
			case "multiply":
				array[pos] = (long)arr[pos] * value;
				break;
			case "add":
				array[pos] = (long)arr[pos] + value;
				break;
			case "subtract":
				array[pos] = (long)arr[pos] - value;
				break;
			case "lshift":
				ArrayShiftLeft(arr);
				break;
			case "rshift":
				ArrayShiftRight(arr);
				break;
		}
		return array;
	}

	private static void ArrayShiftRight(long[] array)
	{
		for (int i = array.Length - 1; i >= 1; i--)
		{
			long temp = array[i];
			array[i] = array[i - 1];
			array[i - 1] = temp;
		}
	}

	private static void ArrayShiftLeft(long[] array)
	{
		for (int i = 0; i < array.Length - 1; i++)
		{
			long temp = array[i];
			array[i] = array[i + 1];
			array[i + 1] = temp;
		}
	}

	private static void PrintArray(long[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write(array[i] + " ");
		}
		Console.WriteLine();
	}
}
