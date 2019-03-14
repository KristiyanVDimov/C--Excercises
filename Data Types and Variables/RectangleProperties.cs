using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
	class Program
	{
		static void Main(string[] args)
		{
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

			double perimeter = (2 * width) + (2 * height);
			double area = width * height;
			double diagonal = Math.Sqrt((width * width) + (height * height));

			Console.WriteLine($"{perimeter}\r\n{area}\r\n{diagonal}");
		}
	}
}
