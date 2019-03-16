using System;
using System.Collections.Generic;

namespace Basic_Queue_Operations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var n = int.Parse(input[0]);
            var s = int.Parse(input[1]);
            var x = int.Parse(input[2]);
            var stackInput = Console.ReadLine().Split(" ");

            var queue = new Queue<int>();

            for (var i = 0; i < n; i++)
            {
                queue.Enqueue(int.Parse(stackInput[i]));
            }

            if (queue.Count != 0)
            {
                for (var i = 0; i < s; i++)
                {
                    queue.Dequeue();
                }

                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    if (queue.Count == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        var min = Int32.MaxValue;
                        foreach (var num in queue)
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
