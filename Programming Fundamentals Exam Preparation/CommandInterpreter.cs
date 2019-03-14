using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Regex.Split(Console.ReadLine(), @"\s+").ToArray();

            var command = Console.ReadLine();

            while(command != "end")
            {
                DoCommand(input, command);

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        private static void DoCommand(string[] input, string command)
        {
            var commandTokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var commandToDo = commandTokens[0];
            var start = 0L;
            var count = 0L;

            switch (commandToDo)
            {
                case "reverse":
                    start = long.Parse(commandTokens[2]);
                    count = long.Parse(commandTokens[4]);

                    if (start >= 0 && start < input.Length && count >= 0 && start + count <= input.Length)
                    {
                        ReverseCommand(start, count, input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }
                    break;
                case "sort":
                    start = long.Parse(commandTokens[2]);
                    count = long.Parse(commandTokens[4]);

                    if (start >= 0 && start < input.Length && count >= 0 && start + count <= input.Length)
                    {
                        SortCommand(start, count, input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }
                    break;
                case "rollLeft":
                    count = long.Parse(commandTokens[1]);

                    if (count >= 0)
                    {
                        RollLeft(count, input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    break;
                case "rollRight":
                    count = long.Parse(commandTokens[1]);

                    if (count >= 0)
                    {
                        RollRight(count, input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    break;
            }
        }

        private static void RollRight(long count, string[] input)
        {
            for (long i = 0; i < count % input.Length; i++)
            {
                for (int j = input.Length - 1; j > 0; j--)
                {
                    var temp = input[j];
                    input[j] = input[j - 1];
                    input[j - 1] = temp;
                }
            }
        }

        private static void RollLeft(long count, string[] input)
        {
            for (long i = 0; i < count % input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    var temp = input[j];
                    input[j] = input[j + 1];
                    input[j + 1] = temp;
                }
            }
        }

        private static void SortCommand(long start, long count, string[] input)
        {
            var temp = new string[count];
            var index = 0;

            for (long i = start; i < start + count; i++)
            {
                temp[index] = input[i];
                index++;
            }

            Array.Sort(temp);
            index = 0;

            for (long i = start; i < start + count; i++)
            {
                input[i] = temp[index];
                index++;
            }
        }

        private static void ReverseCommand(long start, long count, string[] input)
        {
            var temp = new string[count];
            var index = 0;
            for (long i = start; i < start + count; i++)
            {
                temp[index] = input[i];
                index++;
            }
            temp = temp.Reverse().ToArray();
            index = 0;
            for (long i = start; i < start + count; i++)
            {
                input[i] = temp[index];
                index++;
            }
        }
    }
}
