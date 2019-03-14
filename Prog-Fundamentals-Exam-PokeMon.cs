using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokePower = int.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());
            var targetsPoked = 0;

            var halfOfPokePower = pokePower * 0.5;

            while (true)
            {
                if(pokePower == halfOfPokePower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
                if(pokePower < distance)
                {
                    break;
                }

                pokePower -= distance;
                targetsPoked++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}
