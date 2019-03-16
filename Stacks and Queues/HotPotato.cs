using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>(input.Split(" "));

            while(children.Count != 1)
            {
                for(var i = 1; i < n; i++)
                {
                    children.Enqueue(children.Dequeue());
                }

                Console.WriteLine($"Removed {children.Dequeue()}");
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
