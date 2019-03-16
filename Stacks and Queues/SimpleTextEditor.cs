using System;
using System.Collections;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var text = String.Empty;
            var stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(" ");

                switch (int.Parse(command[0]))
                {
                    case 1:
                        stack.Push(text);
                        text += command[1];
                        break;
                    case 2:
                        stack.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(command[1]));
                        break;
                    case 3:
                        Console.WriteLine(text[int.Parse(command[1]) - 1]);
                        break;
                    case 4:
                        text = stack.Pop();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
