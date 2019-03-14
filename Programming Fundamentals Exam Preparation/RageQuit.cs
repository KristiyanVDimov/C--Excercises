using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<symbols>.+?)(?<count>\d+)");
            var matches = regex.Matches(Console.ReadLine().ToUpper());
            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                var symbols = match.Groups["symbols"].Value.ToUpper();
                var count = int.Parse(match.Groups["count"].Value);

                for (int i = 0; i < count; i++)
                {
                    sb.Append(symbols);
                }
            }

            var tempCharArr = sb.ToString().ToCharArray();

            tempCharArr = tempCharArr.Distinct().ToArray();

            Console.WriteLine($"Unique symbols used: {tempCharArr.Length}");
            Console.WriteLine(sb.ToString());
        }
    }
}
