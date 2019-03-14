using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            DoCommand(numbers);

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void DoCommand(int[] numbers)
        {
            var count = 0;
            while (count != 3)
            {
                try
                {
                    var input = Console.ReadLine();
                    var commandTokens = input.Split(' ').ToArray();
                    var command = commandTokens[0];
                    var first = 0;
                    var second = 0;

                    switch (command)
                    {
                        case "Replace":
                            first = int.Parse(commandTokens[1]);
                            second = int.Parse(commandTokens[2]);

                            numbers[first] = second;
                            break;
                        case "Print":
                            first = int.Parse(commandTokens[1]);
                            second = int.Parse(commandTokens[2]);
                            var newNumbers = new List<int>();

                            for (int i = first; i <= second; i++)
                            {
                                newNumbers.Add(numbers[i]);
                            }
                            Console.WriteLine(string.Join(", ", newNumbers));
                            break;
                        case "Show":
                            first = int.Parse(commandTokens[1]);
                            Console.WriteLine(numbers[first]);
                            break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    count++;
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    count++;
                    continue;
                }
            }
        }
    }
}
