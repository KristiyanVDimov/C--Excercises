using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var files = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();
                var inputTokens = input.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var root = inputTokens[0];
                var fileTokens = inputTokens[inputTokens.Length - 1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var fileName = fileTokens[0].Trim();
                var fileSize = long.Parse(fileTokens[1]);

                if (!files.ContainsKey(root))
                {
                    files[root] = new Dictionary<string, long>();

                    files[root].Add(fileName, fileSize);
                }
                else
                {
                    if (files[root].ContainsKey(fileName))
                    {
                        files[root][fileName] = fileSize;
                    }
                    else
                    {
                        files[root].Add(fileName, fileSize);
                    }
                }
            }

            var query = Console.ReadLine();
            var queryTokens = query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var searchedRoot = queryTokens[2];
            var searchedExtension = queryTokens[0];

            if (files.Keys.Contains(searchedRoot) && files[searchedRoot].Keys.Any(x => x.EndsWith(searchedExtension)))
            {
                foreach (var file in files)
                {   
                    foreach (var item in file.Value.OrderBy(x => -x.Value).ThenBy(x => x.Key))
                    {
                        if (file.Key == searchedRoot && item.Key.EndsWith(searchedExtension))
                        {
                            Console.WriteLine($"{item.Key} - {item.Value} KB");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
