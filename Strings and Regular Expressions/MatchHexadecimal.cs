using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";

            var hexNumbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(hexNumbers, pattern);

            var matchedHexNumbers = matches.Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(" ", matchedHexNumbers));
        }
    }
}
