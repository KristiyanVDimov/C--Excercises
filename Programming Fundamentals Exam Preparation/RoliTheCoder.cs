using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Roli_The_Coder
{
	class Program
	{
		static void Main(string[] args)
		{
			var regex = new Regex(@"(?<id>\d+)\s+#(?<eventName>\w+)\s*(?<participants>(?:@[a-zA-Z0-9'-]+\s*)*)");
			var events = new Dictionary<int, Event>();

			while (true)
			{
				var input = Console.ReadLine();
				if(input == "Time for Code")
				{
					break;
				}

				if (!regex.IsMatch(input))
				{
					continue;
				}
				var match = regex.Match(input);

				var id = int.Parse(match.Groups["id"].Value);
				var eventName = match.Groups["eventName"].Value;
				var participants = match.Groups["participants"].Value;

				var participantsList = new List<string>();

				if(participants.Length > 0)
				{
					participantsList = participants.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();	
				}

				if (!events.ContainsKey(id))
				{
					var ev = new Event()
					{
						Name = eventName,
						Participants = participantsList
					};

					events[id] = ev;
				}

				if(events[id].Name == eventName)
				{
					events[id].Participants.AddRange(participantsList);
				}
			}

			foreach (var ev in events)
			{
				ev.Value.Participants = ev.Value.Participants.Distinct().OrderBy(x => x).ToList();
			}

			foreach (var ev in events.OrderByDescending(x => x.Value.Participants.Count).ThenBy(x => x.Value.Name))
			{
				Console.WriteLine(ev.Value.Name + " - " + ev.Value.Participants.Count);

				foreach (var participant in ev.Value.Participants)
				{
					Console.WriteLine($"{participant}");
				}
			}
		}
	}

	class Event
	{
		public string Name { get; set; }
		public List<string> Participants { get; set; }
	}
}
