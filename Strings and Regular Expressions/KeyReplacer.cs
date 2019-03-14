using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyString = Console.ReadLine();
            var textString = Console.ReadLine();
            var startKey = string.Empty;
            var endKey = string.Empty;

            var startCount = 0;

            while (keyString[startCount] != '|' && keyString[startCount] != '<' && keyString[startCount] != '\\')
            {
                startKey += keyString[startCount];
                startCount++;
            }
            var index = 0;

            for (int i = 0; i < keyString.Length; i++)
            {
                if(keyString[i] == '|' || keyString[i] == '<' || keyString[i] == '\\')
                {
                    index = i + 1;
                }
            }

            endKey = keyString.Substring(index);
            var pattern = startKey + @"(.*?)" + endKey;
            Regex r = new Regex(pattern);

            var matches = r.Matches(textString);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Append(match.Groups[1].Value);
            }

            if(sb.ToString() != string.Empty)
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
