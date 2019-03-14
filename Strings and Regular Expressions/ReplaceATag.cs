using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var output = new List<string>();
          
            while (text != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var newText = @"[URL href=$1]$2[/URL]";

                var replaced = Regex.Replace(text, pattern, newText);

                if (replaced.Length > text.Length)
                {
                    output.Add(replaced);
                }
                else
                {
                    output.Add(text);
                }
                text = Console.ReadLine();
            }

            output = output.Distinct().ToList();

            Console.WriteLine(string.Join("\r\n", output));
        }
    }
}
