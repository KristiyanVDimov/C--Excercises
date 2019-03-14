using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades
{
	class Student
	{
		public string Name { get; set; }
		public List<double> Grades { get; set; }
		public double AverageGrade { get { return Grades.Average(); } }

		static Student ReadStudent()
		{
			var studentInfo = Console.ReadLine().Split(' ').ToArray();

			Student student = new Student();

			student.Name = studentInfo[0];
			student.Grades = new List<double>();

			for (int i = 1; i < studentInfo.Length; i++)
			{
				student.Grades.Add(double.Parse(studentInfo[i]));
			}

			return student;
		}

		static List<Student> ReadStudents(int number)
		{
			List<Student> students = new List<Student>();
			Student student = new Student();

			for (int i = 0; i < number; i++)
			{
				student = ReadStudent();
				students.Add(student);
			}

			return students;
		}

		static void PrintStudents(List<Student> students)
		{
			students = students.OrderBy(t => t.Name).ThenBy(s => -s.AverageGrade).ToList();

			for (int i = 0; i < students.Count; i++)
			{
				if(students[i].AverageGrade >= 5.00)
				{
					Console.WriteLine($"{students[i].Name} -> {students[i].AverageGrade:F2}");
				}
			}
		}

		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			List<Student> students = new List<Student>();

			students = ReadStudents(n);

			PrintStudents(students);
		}
	}
}
