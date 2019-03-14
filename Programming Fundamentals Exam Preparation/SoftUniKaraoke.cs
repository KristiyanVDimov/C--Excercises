using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var availableSongs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var awards = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            
            while(input != "dawn")
            {
                var singerTokens = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                var participant = singerTokens[0];
                var song = singerTokens[1];
                var award = singerTokens[2];

                if (availableSongs.Contains(song) && participants.Contains(participant))
                {
                    if (!awards.ContainsKey(participant))
                    {
                        awards[participant] = new List<string>();
                    }
                    if (!awards[participant].Contains(award))
                    {
                        awards[participant].Add(award);
                    }
                }

                input = Console.ReadLine();
            }

            if(awards.Count > 0)
            {
                foreach (var singer in awards.OrderBy(x => -x.Value.Count).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");

                    foreach (var award in singer.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
