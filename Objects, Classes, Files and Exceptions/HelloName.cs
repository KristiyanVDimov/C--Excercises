using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__Name_
{
	class Program
	{
		static void PrintHelloName(string name)
		{
			Console.WriteLine($"Hello, {name}!");
		}
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			PrintHelloName(name);
		}
	}
}
