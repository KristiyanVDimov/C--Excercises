using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]*)$");

            while (true)
            {
                var input = Console.ReadLine();

                if(input == "Over!")
                {
                    break;
                }

                var messageLength = int.Parse(Console.ReadLine());

                if (!regex.IsMatch(input))
                {
                    continue;
                }

                var match = regex.Match(input);

                var leftPart = match.Groups["leftPart"].Value;
                var message = match.Groups["message"].Value;
                var rightPart = match.Groups["rightPart"].Value;

                if(message.Length != messageLength)
                {
                    continue;
                }

                var verification = leftPart + rightPart;

                var verificationCode = new string(verification
                    .Where(x => char.IsDigit(x))
                    .Select(x => int.Parse(x.ToString()))
                    .Select(x => x >= 0 && x < message.Length ? message[x] : ' ').ToArray());

                Console.WriteLine($"{message} == {verificationCode}");
            }
        }
    }
}
