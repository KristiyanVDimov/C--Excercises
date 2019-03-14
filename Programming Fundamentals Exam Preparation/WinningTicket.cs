using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var regex = new Regex(@"\@{6,10}|\#{6,10}|\${6,10}|\^{6,10}");

            for (int i = 0; i < tickets.Length; i++)
            {
                if(tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string substr1 = tickets[i].Substring(0, 10);
                    string substr2 = tickets[i].Substring(10, 10);

                    if (regex.IsMatch(substr1) && regex.IsMatch(substr2))
                    {
                        var firstMatch = regex.Match(substr1).Value;
                        var secondMatch = regex.Match(substr2).Value;

                        if (AreEqual(firstMatch, secondMatch))
                        {
                            var lengthSum = firstMatch.Length + secondMatch.Length;
                            var matchLength = Math.Min(firstMatch.Length, secondMatch.Length);
                            var matchSymbol = firstMatch[0].ToString();

                            if (lengthSum >= 12 && lengthSum < 20)
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}{matchSymbol}");
                            }
                            if (lengthSum == 20)
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}{matchSymbol} Jackpot!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }

                }
            }
        }

        static bool AreEqual(string firstMatch, string secondMatch)
        {
            bool areEqual = false;
            var end = Math.Min(firstMatch.Length, secondMatch.Length);

            for (int i = 0; i < end; i++)
            {
                if (firstMatch[i] == secondMatch[i])
                {
                    areEqual = true;
                }
                else
                {
                    areEqual = false;
                    break;
                }
            }

            return areEqual;

        }
    }
}
