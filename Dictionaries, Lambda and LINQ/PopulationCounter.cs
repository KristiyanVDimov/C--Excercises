using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Counter
{
	class Population_Counter
	{
		static void Main()
		{
			var population = new Dictionary<string, Dictionary<string, long>>();
			var input = string.Empty;

			while ((input = Console.ReadLine()) != "report")
			{
				var statisticData = input.Split(new char[] { '|' }).ToArray();
				var city = statisticData[0];
				var country = statisticData[1];
				var cityPopulation = long.Parse(statisticData[2]);

				if (!population.ContainsKey(country))
				{
					population[country] = new Dictionary<string, long>();
				}
				population[country][city] = cityPopulation;
			}

			foreach (var data in population.OrderBy(t => -t.Value.Values.Sum()))
			{
				Console.WriteLine($"{data.Key} (total population: {data.Value.Values.Sum()})");

				foreach (var city in data.Value.OrderBy(t => -t.Value))
				{
					Console.WriteLine($"=>{city.Key}: {city.Value}");
				}
			}
		}
	}
}
