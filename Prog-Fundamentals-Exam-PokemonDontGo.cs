using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var sum = 0L;

            while (pokemons.Any())
            {
                var index = int.Parse(Console.ReadLine());
                var removedElement = 0L;

                if (index < 0)
                {
                    removedElement = pokemons[0];
                    sum += removedElement;
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    IncreaseOrDecreaseDistance(pokemons, removedElement);
                    continue;
                }
                else if (index > pokemons.Count - 1)
                {
                    removedElement = pokemons[pokemons.Count - 1];
                    sum += removedElement;
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    IncreaseOrDecreaseDistance(pokemons, removedElement);
                    continue;
                }

                removedElement = pokemons[index];
                pokemons.RemoveAt(index);
                IncreaseOrDecreaseDistance(pokemons, removedElement);
                sum += removedElement;
            }

            Console.WriteLine(sum);
        }

        private static void IncreaseOrDecreaseDistance(List<long> pokemons, long removedElement)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= removedElement)
                {
                    pokemons[i] += removedElement;
                }
                else
                {
                    pokemons[i] -= removedElement;
                }
            }
        }
    }
}
