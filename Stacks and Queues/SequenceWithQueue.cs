using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sequence_with_Queue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var results = new List<long>();
            var queue = new Queue<long>();

            results.Add(n);
            queue.Enqueue(n);

            for (var i = 0; i < 17; i++)
            {
                long currentNum = queue.Dequeue();

                long a = currentNum + 1;
                long b = currentNum * 2 + 1;
                long c = currentNum + 2;

                queue.Enqueue(a);
                queue.Enqueue(b);
                queue.Enqueue(c);

                results.Add(a);
                results.Add(b);
                results.Add(c);
            }

            Console.WriteLine(String.Join(" ", results.Take(50)));
        }
    }
}
