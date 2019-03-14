using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor_Group
{
	class Student
	{
		public string Name { get; set; }
		public List<string> Comments { get; set; }
		public List<DateTime> Attendencies { get; set; }

	}

	class MentorGroup
	{
		static void Main()
		{
			var students = new Dictionary<string, Student>();

			var line = Console.ReadLine();

			while (line != "end of dates")
			{
				var studentTokens = line.Split(' ').ToArray();
				var student = new Student()
				{
					Name = studentTokens[0],
					Attendencies = new List<DateTime>(),
					Comments = new List<string>()
				};

				if (studentTokens.Length > 1)
				{
					string studentName = studentTokens[0];
					if (!students.ContainsKey(studentName))
					{
						students.Add(studentName, student);
					}
					string dates = studentTokens[1];
					students[studentName].Attendencies.AddRange(ReadDates(dates));
				}
				else
				{
					students[student.Name] =  student;
				}

				line = Console.ReadLine();
			}

			line = Console.ReadLine();

			while (line != "end of comments")
			{
				var student = new Student()
				{
					Attendencies = new List<DateTime>(),
					Comments = new List<string>()
				};
				var studentData = line.Split('-');
				string name = studentData[0];
				student.Name = name;
				if (students.ContainsKey(name))
				{
					var comment = studentData[1];

					students[name].Comments.Add(comment);
				}

				line = Console.ReadLine();
			}

			foreach (var student in students.OrderBy(n => n.Key))
			{
				Console.WriteLine(student.Key);
				Console.WriteLine("Comments:");

				foreach (var comment in student.Value.Comments)
				{
					Console.WriteLine($"- {comment}");
				}

				Console.WriteLine("Dates attended:");

				foreach (var date in student.Value.Attendencies.OrderBy(s => s))
				{
					Console.WriteLine($"-- {date.Day:D2}/{date.Month:D2}/{date.Year}");
				}
			}
		}

		public static List<DateTime> ReadDates(string input)
		{
			List<DateTime> attendencies = new List<DateTime>();

			var dates = input.Split(',').ToArray();

			for (int i = 0; i < dates.Length; i++)
			{
				var dateInfo = dates[i].Split('/').Select(int.Parse).ToArray();

				int year = dateInfo[2];
				int month = dateInfo[1];
				int day = dateInfo[0];

				var date = new DateTime(year, month, day);

				attendencies.Add(date);
			}

			return attendencies;
		}
	}
}
