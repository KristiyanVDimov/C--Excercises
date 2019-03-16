using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fuelPumps = new Queue<int[]>();

            for (var i = 0; i < n; i++)
            {
                var station = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                fuelPumps.Enqueue(station);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var fuelPump in fuelPumps)
                {
                    int fuel = fuelPump[0];
                    int distance = fuelPump[1];

                    totalFuel += fuel - distance;

                    if (totalFuel < 0)
                    {
                        index++;
                        fuelPumps.Enqueue(fuelPumps.Dequeue());
                        break;
                    }

                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
