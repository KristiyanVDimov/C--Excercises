using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var zones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                var fuel = (decimal)drivers[i][0];
                var zoneReached = 0;

                for (int j = 0; j < zones.Length; j++)
                {
                    if (IsCheckpoint(j, checkpoints))
                    {
                        fuel += zones[j];
                    }
                    else
                    {
                        fuel -= zones[j];
                    }
                    
                    if (fuel <= 0)
                    {
                        zoneReached = j;
                        break;
                    }
                }

                if (fuel <= 0)
                {
                    Console.WriteLine($"{drivers[i]} - reached {zoneReached}");
                }
                else
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {fuel:f2}");
                }
            }
            
        }

        static bool IsCheckpoint(int index, long[] checkpoints)
        {
            bool isCheckpoint = false;

            for (int i = 0; i < checkpoints.Length; i++)
            {
                if(index == checkpoints[i])
                {
                    isCheckpoint = true;
                }
            }

            return isCheckpoint;
        }
    }
}
