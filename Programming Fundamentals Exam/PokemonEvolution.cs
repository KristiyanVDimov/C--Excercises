using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = new Dictionary<string, List<KeyValuePair<int, string>>>();
            var regex = new Regex(@"^([^\-\>\s]+)[\s+|\-+|\>+]+([^\-\>\s]+)[\s+|\-+|\>+]+([\d+]+)");
            
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    var name = match.Groups[1].Value;
                    var evolution = match.Groups[2].Value;
                    var index = int.Parse(match.Groups[3].Value);

                    if (!pokemons.ContainsKey(name))
                    {
                        pokemons[name] = new List<KeyValuePair<int, string>>();
                    }
                    KeyValuePair<int, string> kvp = new KeyValuePair<int, string>(index, evolution);

                    pokemons[name].Add(kvp);
                }
                else
                {
                    var name = input;

                    if (pokemons.ContainsKey(name))
                    {
                        foreach (var pokemon in pokemons)
                        {
                            if (pokemon.Key == name)
                            {
                                Console.WriteLine($"# {pokemon.Key}");

                                foreach (var evo in pokemon.Value)
                                {
                                    Console.WriteLine($"{evo.Value} <-> {evo.Key}");
                                }
                            }
                        }
                    }
                }
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var evo in pokemon.Value.OrderByDescending(x => x.Key))
                {
                    Console.WriteLine($"{evo.Value} <-> {evo.Key}");
                }
            }
        }

        class Pokemon
        {
            public int Index { get; set; }
        }
    }
}
