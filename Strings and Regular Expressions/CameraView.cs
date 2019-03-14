using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|<[\w+]+";
            var views = new List<string>();

            var elements = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var skip = elements[0];
            var take = elements[1];

            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                var view = match.Value.Remove(0, 2);

                views.Add(new string(view.Skip(skip).Take(take).ToArray()));
            }

            Console.WriteLine(string.Join(", ", views));
        }
    }
}
