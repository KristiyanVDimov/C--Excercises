using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359 (2 [0-9]{3} [0-9]{4}))|(\+359-(2-[0-9]{3}-[0-9]{4}))";

            var phoneNumbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(phoneNumbers, pattern);

            var phoneMatches = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", phoneMatches));
        }
    }
}
