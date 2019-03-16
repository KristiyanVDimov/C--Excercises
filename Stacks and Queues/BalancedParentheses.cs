using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Balanced_Parentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            //Regex rgx = new Regex(@"\{+\[+\(+\)+\]+\}+");

            //var input = Console.ReadLine();

            //if (rgx.IsMatch(input))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            var stack = new Stack<char>();
            var input = Console.ReadLine();

            var openParentheses = new char[] {'(', '[', '{'};

            var isValid = true;

            for (int i = 0; i < input.Length; i++)
            {
                var currentBracket = input[i];

                if (openParentheses.Contains(currentBracket))
                {
                    stack.Push(currentBracket);
                    continue;
                }

                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }


                if (stack.Peek() == '(' && currentBracket == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '[' && currentBracket == ']')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '{' && currentBracket == '}')
                {
                    stack.Pop();
                }
            }

            if (stack.Count == 0 && isValid == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
