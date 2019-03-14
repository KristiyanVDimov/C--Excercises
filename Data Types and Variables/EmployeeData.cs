using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			char gender = char.Parse(Console.ReadLine());
			long id = long.Parse(Console.ReadLine());
			int employeeNumber = int.Parse(Console.ReadLine());

			Console.WriteLine($"First name: {firstName}\r\nLast name: {lastName}\r\nAge: {age}" +
				$"\r\nGender: {gender}\r\nPersonal ID: {id}\r\nUnique Employee number: {employeeNumber}");
		}
	}
}
