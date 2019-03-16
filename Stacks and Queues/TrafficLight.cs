using System;
using System.Collections.Generic;

namespace Traffic_Light
{
    class TrafficLight
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var input = "";
            var count = 0;

            while (input != "end")
            {
                input = Console.ReadLine();
                if(input != "green")
                {
                    queue.Enqueue(input);
                }

                if(input == "green")
                {
                    for (var i = 0; i < n; i++)
                    {
                        if(queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
