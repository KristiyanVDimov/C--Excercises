using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine();
            var pattern = @"\b" + keyword + @"\b";
            Regex regex = new Regex(pattern);

            var input = Console.ReadLine();

            var text = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (regex.IsMatch(text[i]))
                {
                    Console.WriteLine(text[i].Trim());
                }
            }
        }
    }
}
