using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var values = input.Split(" ");

            var stack = new Stack<string>(values.Reverse());

            while(stack.Count > 1)
            {
                int firstOperand = Int32.Parse(stack.Pop());
                string operand = stack.Pop();
                int secondOperand = Int32.Parse(stack.Pop());

                switch (operand)
                {
                    case "+":
                        stack.Push((firstOperand + secondOperand).ToString());
                        break;
                    case "-":
                        stack.Push((firstOperand - secondOperand).ToString());
                        break;
                    default:
                        stack.Push("0");
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
