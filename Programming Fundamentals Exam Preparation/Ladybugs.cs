using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var indexes = Console.ReadLine().Split().Select(int.Parse).Where(x => x >= 0 && x < size).ToArray();

            var ladybugs = new int[size];

            foreach (var index in indexes)
            {
                ladybugs[index] = 1;
            }

            var flyCommand = Console.ReadLine();

            while(flyCommand != "end")
            {
                var flyCommandTokens = flyCommand.Split();
                var index = int.Parse(flyCommandTokens[0]);
                var direction = flyCommandTokens[1];
                var flyLength = int.Parse(flyCommandTokens[2]);

                if (!(index >= 0 && index < ladybugs.Length))
                {
                    flyCommand = Console.ReadLine();
                    continue;
                }

                if(ladybugs[index] == 0)
                {
                    flyCommand = Console.ReadLine();
                    continue;
                }

                DoFlyCommand(ladybugs, direction, index, flyLength);

                flyCommand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }

        private static void DoFlyCommand(int[] ladybugs, string direction, int index, int flyLength)
        {
            if(direction == "left")
            {
                flyLength = -flyLength;
            }

            ladybugs[index] = 0;

             index = index + flyLength;

            var hasFoundPlaceOrLeftArr = false;

            while (!hasFoundPlaceOrLeftArr)
            {
                if (index < 0 || index >= ladybugs.Length)
                {
                    hasFoundPlaceOrLeftArr = true;
                    continue;
                }

                var ladybugAlreadyOnNextIndex = ladybugs[index] == 1;

                if (ladybugAlreadyOnNextIndex)
                {
                    index += flyLength;
                    continue;
                }

                ladybugs[index] = 1;
                hasFoundPlaceOrLeftArr = true;
            }
        }
    }
}
