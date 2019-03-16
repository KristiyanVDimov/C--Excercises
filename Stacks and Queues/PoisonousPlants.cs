using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Poisonous_Plants
{
    class PoisonousPlants
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split(" ").Select(long.Parse).ToList();
            var indexes = new List<int>();
            var days = 0;

            while (true)
            {
                for (var i = 0; i < plants.Count - 1; i++)
                {
                    if (plants[i] < plants[i + 1])
                    {
                        indexes.Add(i + 1);
                    }
                }

                if (indexes.Count == 0)
                {
                    break;
                }

                for (var i = 0; i < indexes.Count; i++)
                {
                    plants.RemoveAt(indexes[i] - i);
                }

                days++;
                indexes.Clear();
            }

            Console.WriteLine(days);
        }
    }
}
