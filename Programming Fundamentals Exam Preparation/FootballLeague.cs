using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var teams = new Dictionary<string, Team>();

            var regex = new Regex(Regex.Escape(key) + @"(?<teamName>[a-zA-Z]*)" + Regex.Escape(key));
            var scoreRegex = new Regex(@"(?<firstTeamScore>\d+):(?<secondTeamScore>\d+)$");

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }
                var teamNames = new List<string>();
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    var name = match.Groups["teamName"].Value;
                    teamNames.Add(name);
                }

                if (teamNames.Count != 2)
                {
                    continue;
                }

                var firstTeamName = new string(teamNames[0].ToUpper().Reverse().ToArray());
                var secondTeamName = new string(teamNames[1].ToUpper().Reverse().ToArray());
                var firstTeamScore = decimal.Parse(scoreRegex.Match(input).Groups["firstTeamScore"].Value);
                var secondTeamScore = decimal.Parse(scoreRegex.Match(input).Groups["secondTeamScore"].Value);

                Team firstTeam = new Team();
                Team secondTeam = new Team();

                if (firstTeamScore > secondTeamScore)
                {
                    firstTeam.Points = 3;
                    secondTeam.Points = 0;
                }
                else if (firstTeamScore == secondTeamScore)
                {
                    firstTeam.Points = 1;
                    secondTeam.Points = 1;
                }
                else
                {
                    firstTeam.Points = 0;
                    secondTeam.Points = 3;
                }

                firstTeam.Goals = firstTeamScore;
                secondTeam.Goals = secondTeamScore;

                if (!teams.ContainsKey(firstTeamName))
                {
                    teams.Add(firstTeamName, firstTeam);
                }
                else
                {
                    teams[firstTeamName].Points += firstTeam.Points;
                    teams[firstTeamName].Goals += firstTeam.Goals;
                }

                if (!teams.ContainsKey(secondTeamName))
                {
                    teams.Add(secondTeamName, secondTeam);
                }
                else
                {
                    teams[secondTeamName].Points += secondTeam.Points;
                    teams[secondTeamName].Goals += secondTeam.Goals;
                }
            }

            Console.WriteLine("League standings:");
            var position = 1;

            foreach (var team in teams.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{position}. {team.Key} {team.Value.Points}");
                position++;
            }

            Console.WriteLine("Top 3 scored goals:");
            var count = 0;

            foreach (var team in teams.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key))
            {
                if(count == 3)
                {
                    break;
                }

                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");

                count++;
            }
        }
    }

    class Team
    {
        public decimal Goals { get; set; }
        public decimal Points { get; set; }
    }
}
