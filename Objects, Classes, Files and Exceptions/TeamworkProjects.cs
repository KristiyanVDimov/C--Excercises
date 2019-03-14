using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork_Projects
{
	class Team
	{
		public string Creator { get; set; }
		public string Name { get; set; }
		public List<string> Members { get; set; }

	}

	class Teamwork_Projects
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			var teams = CreateTeams(n);
			AddMembers(teams);

			var teamsToDisband = new List<Team>();
			var goodToGoTeams = new List<Team>();

			foreach (var team in teams)
			{
				if(team.Value.Members.Count == 0)
				{
					teamsToDisband.Add(team.Value);
				}
				else
				{
					goodToGoTeams.Add(team.Value);
				}
			}


			foreach (var team in goodToGoTeams.OrderByDescending(m => m.Members.Count).ThenBy(x => x.Name))
			{
				Console.WriteLine(team.Name);
				Console.WriteLine($"- {team.Creator}");
				foreach (var member in team.Members.OrderBy(x => x))
				{
					Console.WriteLine($"-- {member}");
				}
			}

			Console.WriteLine("Teams to disband:");

			foreach (var team in teamsToDisband.OrderBy(x => x.Name))
			{
				Console.WriteLine(team.Name);
			}
		}

		static Dictionary<string, Team> CreateTeams(int count)
		{
			Dictionary<string, Team> teams = new Dictionary<string, Team>();

			for (int i = 0; i < count; i++)
			{
				Team team = new Team();
				var input = Console.ReadLine().Split('-').ToArray();
				var creator = input[0];
				var teamName = input[1];

				team.Creator = creator;
				team.Name = teamName;

				if (teams.Keys.Contains(teamName))
				{
					Console.WriteLine($"Team {teamName} was already created!");
				}
				else if(IsAlreadyCreator(teams, creator))
				{
					Console.WriteLine($"{creator} cannot create another team!");
				}
				else
				{
					teams.Add(teamName, team);
					Console.WriteLine($"Team {teamName} has been created by {creator}!");
				}
			}

			return teams;
		}

		static void AddMembers(Dictionary<string, Team> teams)
		{
			foreach (var team in teams)
			{
				team.Value.Members = new List<string>();
			}

			var input = Console.ReadLine();

			while (input != "end of assignment")
			{
				var membersTokens = input.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

				var memberName = membersTokens[0];
				var teamName = membersTokens[1];

				if(IsCreated(teams, teamName) && MemberIsNotInTeam(teams, memberName))
				{
					teams[teamName].Members.Add(memberName);
				}
				else
				{
					if(!IsCreated(teams, teamName))
					{
						Console.WriteLine($"Team {teamName} does not exist!");
					}
					else if(!MemberIsNotInTeam(teams, memberName))
					{
						Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
					}
				}

				input = Console.ReadLine();
			}
		}

		static bool IsCreated(Dictionary<string, Team> teams, string name)
		{
			bool isCreated = false;

			foreach (var team in teams)
			{
				if(team.Key == name)
				{
					isCreated = true;
				}
			}

			return isCreated;
		}

		static bool MemberIsNotInTeam(Dictionary<string, Team> teams, string member)
		{
			bool isNotInTeam = true;

			foreach (var team in teams)
			{
				if(team.Value.Creator == member || team.Value.Members.Contains(member))
				{
					isNotInTeam = false;
				}
			}

			return isNotInTeam;
		}

		static bool IsAlreadyCreator(Dictionary<string, Team> teams, string creator)
		{
			bool isCreator = false;

			foreach (var item in teams)
			{
				if (item.Value.Creator == creator)
				{
					isCreator = true;		
				}
			}

			return isCreator;
		}
	}
}
