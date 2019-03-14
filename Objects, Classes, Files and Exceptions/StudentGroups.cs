using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Student_Groups
{
	class Student
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime RegistrationDate { get; set; }
	}

	class Town
	{
		public string Name { get; set; }
		public int SeatsCount { get; set; }
		public List<Student> Students { get; set; }
	}

	class Group
	{
		public Town Town { get; set; }
		public List<Student> Students { get; set; }
	}

	class StudentGroups
	{
		static void Main()
		{
			List<Town> towns = ReadTownsAndStudents();
			List<Group> groups = DistributeStudentsIntoGroups(towns);

			PrintTheGroups(groups, towns);
		}

		static List<Town> ReadTownsAndStudents()
		{
			var towns = new List<Town>();

			var input = Console.ReadLine();
			while(input != "End")
			{
					var town = new Town();
				if (input.Contains("=>"))
				{
					var townTokens = input.Split(new[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
					var seatsCountTokens = townTokens[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
					var townName = townTokens[0];
					var seatsCount = int.Parse(seatsCountTokens[0]);

					town.Name = townName;
					town.SeatsCount = seatsCount;

					town.Students = new List<Student>();

					towns.Add(town);
				}
				else
				{
					var student = new Student();
					var studentTokens = input.Split(new char[] { '|' , ' '}, StringSplitOptions.RemoveEmptyEntries);
					var studentName = studentTokens[0] + " " + studentTokens[1];
					var studentEmail = studentTokens[2];
					var studentRegistrationDate = DateTime.ParseExact(studentTokens[3], "d-MMM-yyyy", CultureInfo.InvariantCulture);

					student.Name = studentName;
					student.Email = studentEmail;
					student.RegistrationDate = studentRegistrationDate;

					towns[towns.Count - 1].Students.Add(student);
				}
				input = Console.ReadLine();
			}

			return towns;
		}

		static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
		{
			var groups = new List<Group>();

			foreach (var town in towns.OrderBy(x => x.Name))
			{
				IEnumerable<Student> students = town.Students.OrderBy(x => x.RegistrationDate)
					.ThenBy(n => n.Name).ThenBy(s => s.Email);

				while (students.Any())
				{
					var group = new Group();
					group.Town = town;
					group.Students = students.Take(group.Town.SeatsCount).ToList();
					students = students.Skip(group.Town.SeatsCount);
					groups.Add(group);
				}
				
			}

			return groups;
		}

		static void PrintTheGroups(List<Group> groups, List<Town> towns)
		{
			towns = towns.Distinct().ToList();

			Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

			foreach (var group in groups.OrderBy(x => x.Town.Name))
			{
				Console.WriteLine($"{group.Town.Name}=> {string.Join(", ", group.Students.Select(x => x.Email).ToList())}");
			}
		}
	}
}
