using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var bojomonRegex = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");
            var didimonRegex = new Regex(@"[^a-zA-Z\-]+");

            var input = Console.ReadLine();

            while (bojomonRegex.IsMatch(input) || didimonRegex.IsMatch(input))
            {
                var didimonMatch = didimonRegex.Match(input);

                if (!didimonMatch.Success)
                {
                    break;
                }

                Console.WriteLine(didimonMatch.Value);
                input = input.Substring(input.IndexOf(didimonMatch.Value) + didimonMatch.Length);

                if (input == string.Empty)
                {
                    break;
                }

                var bojomonMatch = bojomonRegex.Match(input);

                if (!bojomonMatch.Success)
                {
                    break;
                }

                Console.WriteLine(bojomonMatch.Value);
                input = input.Substring(input.IndexOf(bojomonMatch.Value) + bojomonMatch.Length);

                if (input == string.Empty)
                {
                    break;
                }
            }

        }
    }
}
