using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stringReverser = new Stack<char>();

            foreach (var ch in input)
            {
                stringReverser.Push(ch);
            }

            //while(stringReverser.Count > 0)
            //{
            //    Console.Write(stringReverser.Pop());
            //}

            foreach (var item in stringReverser)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}
