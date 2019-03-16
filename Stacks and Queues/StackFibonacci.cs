using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_Fibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            var fibonacci = new Stack<long>();

            var n = int.Parse(Console.ReadLine());

            fibonacci.Push(0);
            fibonacci.Push(1);

            for (var i = 0; i < n - 1; i++)
            {
                var a = fibonacci.Pop();
                var b = fibonacci.Peek();

                fibonacci.Push(a);
                fibonacci.Push(a + b);
            }

            Console.WriteLine(fibonacci.Peek());
        }
    }
}
