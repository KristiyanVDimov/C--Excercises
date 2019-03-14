using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                var command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }

                DoCommand(numbers, command);
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void DoCommand(int[] numbers, string command)
        {
            var commandTokens = command.Split().ToArray();
            var commandToDo = commandTokens[0];

            switch (commandToDo)
            {
                case "exchange":
                    var index = int.Parse(commandTokens[1]);
                    if(index >= 0 && index < numbers.Length)
                    {
                        ExchangeArray(numbers, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;
                case "max":
                    var evenOrOdd = commandTokens[1];
                    var maxNumberIndex = 0;
                    switch (evenOrOdd)
                    {
                        case "even":
                            maxNumberIndex = GetEvenMaxIndex(numbers);
                            break;
                        case "odd":
                            maxNumberIndex = GetOddMaxIndex(numbers);
                            break;
                    }

                    if(maxNumberIndex >= 0)
                    {
                        Console.WriteLine(maxNumberIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
                case "min":
                    evenOrOdd = commandTokens[1];
                    var minNumberIndex = 0;

                    switch (evenOrOdd)
                    {
                        case "even":
                            minNumberIndex = GetEvenMinIndex(numbers);
                            break;
                        case "odd":
                            minNumberIndex = GetOddMinIndex(numbers);
                            break;
                    }

                    if(minNumberIndex >= 0)
                    {
                        Console.WriteLine(minNumberIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
                case "first":
                    var count = int.Parse(commandTokens[1]);
                    evenOrOdd = commandTokens[2];
                    var firstNums = new int[count];
                    if(count > 0 && count <= numbers.Length)
                    {
                        switch (evenOrOdd)
                        {
                            case "even":
                                firstNums = GetFirstEvenNumbers(numbers, count);
                                break;
                            case "odd":
                                firstNums = GetFirstOddNumbers(numbers, count);
                                break;
                        }

                        if(firstNums.Length != 0)
                        {
                            Console.WriteLine($"[{string.Join(", ", firstNums)}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                    break;
                case "last":
                    count = int.Parse(commandTokens[1]);
                    evenOrOdd = commandTokens[2];
                    var lastNums = new int[count];
                    if(count > 0 && count <= numbers.Length)
                    {
                        switch (evenOrOdd)
                        {
                            case "even":
                                lastNums = GetLastEvenNumbers(numbers, count);
                                break;
                            case "odd":
                                lastNums = GetLastOddNumbers(numbers, count);
                                break;
                        }
                        if(lastNums.Length != 0)
                        {
                            Console.WriteLine($"[{string.Join(", ", lastNums)}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                    break;
            }
        }

        private static int[] GetLastEvenNumbers(int[] numbers, int count)
        {
            var evenArr = numbers.Where(x => x % 2 == 0).ToArray();
            if(evenArr.Length > 0)
            {
                return evenArr.Skip(evenArr.Length - count).Take(count).ToArray();
            }
            else
            {
                return new int[0];
            }
        }

        private static int[] GetLastOddNumbers(int[] numbers, int count)
        {
            var oddArr = numbers.Where(x => x % 2 != 0).ToArray();
            if(oddArr.Length > 0)
            {
                return oddArr.Skip(oddArr.Length - count).Take(count).ToArray();
            }
            else
            {
                return new int[0];
            }
        }

        private static int[] GetFirstOddNumbers(int[] numbers, int count)
        {
            var oddArr = numbers.Where(x => x % 2 != 0).ToArray();
            if(oddArr.Length > 0)
            {
                return oddArr.Take(count).ToArray();
            }
            else
            {
                return new int[0];
            }
        }

        private static int[] GetFirstEvenNumbers(int[] numbers, int count)
        {
            var evenArr = numbers.Where(x => x % 2 == 0).ToArray();
            if(evenArr.Length > 0)
            {
                return evenArr.Take(count).ToArray();
            }
            else
            {
                return new int[0];
            }
        }

        private static int GetOddMinIndex(int[] numbers)
        {
            var oddArr = numbers.Where(x => x % 2 != 0).ToArray();
            if(oddArr.Length > 0)
            {
                var oddMin = oddArr.Min();
                var index = Array.LastIndexOf(numbers, oddMin);
                return Array.LastIndexOf(numbers, oddMin);
            }
            else
            {
                return -1;
            }
        }

        private static int GetEvenMinIndex(int[] numbers)
        {
            var evenArr = numbers.Where(x => x % 2 == 0).ToArray();
            if(evenArr.Length > 0)
            {
                var evenMin = evenArr.Min();
                var index = Array.LastIndexOf(numbers, evenMin);
                return Array.LastIndexOf(numbers, evenMin);
            }
            else
            {
                return -1;
            }
        }

        private static int GetOddMaxIndex(int[] numbers)
        {
            var oddArr = numbers.Where(x => x % 2 != 0).ToArray();
            if(oddArr.Length > 0)
            {
                var oddMax = oddArr.Max();
                return Array.LastIndexOf(numbers, oddMax);
            }
            else
            {
                return -1;
            }
        }

        private static int GetEvenMaxIndex(int[] numbers)
        {
            var evenArr = numbers.Where(x => x % 2 == 0).ToArray();
            if(evenArr.Length > 0)
            {
                var evenMax = evenArr.Max();
                return Array.LastIndexOf(numbers, evenMax);
            }
            else
            {
                return -1;
            }
        }

        private static void ExchangeArray(int[] numbers, int index)
        {
            var tempArr = new int[numbers.Length];
            var startIndex = 0;
            for (int i = index + 1; i < numbers.Length; i++)
            {
                tempArr[startIndex] = numbers[i];
                startIndex++;
            }
            for (int i = 0; i <= index; i++)
            {
                tempArr[startIndex] = numbers[i];
                startIndex++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = tempArr[i];
            }
        }
    }
}
