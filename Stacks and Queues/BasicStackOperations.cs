using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

namespace Basic_Stack_Operations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var n = int.Parse(input[0]);
            var s = int.Parse(input[1]);
            var x = int.Parse(input[2]);
            var stackInput = Console.ReadLine().Split(" ");

            var stack = new Stack<int>();

            for (var i = 0; i < n; i++)
            {
                stack.Push(int.Parse(stackInput[i]));
            }

            if (stack.Count != 0)
            {
                for (var i = 0; i < s; i++)
                {
                    stack.Pop();
                }

                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        var min = Int32.MaxValue;
                        foreach (var num in stack)
                        {
                            if (num < min)
                            {
                                min = num;
                            }
                        }

                        Console.WriteLine(min);
                    }
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
