using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
	class Program
	{
		static void Main(string[] args)
		{
			var days = int.Parse(Console.ReadLine());
			var runnersCount = long.Parse(Console.ReadLine());
			var averageLaps = int.Parse(Console.ReadLine());
			var lapLength = long.Parse(Console.ReadLine());
			var trackCapacity = int.Parse(Console.ReadLine());
			var moneyPerKm = decimal.Parse(Console.ReadLine());
			var runners = 0L;
			
			if(runnersCount > (trackCapacity * days))
			{
				runners = trackCapacity * days;
			}
			else
			{
				runners = runnersCount;
			}

			var metersRan = runners * averageLaps * lapLength;
			var kilometers = metersRan / 1000;

			var moneyRaised = (decimal)kilometers * moneyPerKm;

			Console.WriteLine($"Money raised: {moneyRaised:f2}");
		}
	}
}
