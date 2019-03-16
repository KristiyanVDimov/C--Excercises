using System;
using System.Collections;
using System.Collections.Generic;

namespace Maximum_Element
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var query = Console.ReadLine().Split(" ");

                switch (int.Parse(query[0]))
                {
                    case 1:
                        stack.Push(int.Parse(query[1]));
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        var max = int.MinValue;
                        foreach (var num in stack)
                        {
                            if (num > max)
                            {
                                max = num;
                            }
                        }

                        Console.WriteLine(max);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
