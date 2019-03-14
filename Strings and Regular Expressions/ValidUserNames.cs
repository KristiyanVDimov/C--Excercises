using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Regex r = new Regex(@"\b[a-zA-Z]\w{2,24}\b");

            var allUsernames = input.Trim().Split(new char[] { ' ', ',', '/', '(', ')', '\\'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var validUsernames = new List<string>();

            for (int i = 0; i < allUsernames.Length; i++)
            {
                if (r.IsMatch(allUsernames[i]))
                {
                    validUsernames.Add(allUsernames[i]);
                }
            }

            var biggestSum = 0;
            var firstUser = string.Empty;
            var secondUser = string.Empty;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                int sum = validUsernames[i].Length + validUsernames[i + 1].Length;
                
                if(biggestSum < sum)
                {
                    biggestSum = sum;
                    firstUser = validUsernames[i];
                    secondUser = validUsernames[i + 1];
                }
            }

            Console.WriteLine($"{firstUser}\r\n{secondUser}");
        }
    }
}
