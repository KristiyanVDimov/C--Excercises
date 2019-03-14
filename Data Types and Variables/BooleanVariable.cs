using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
	class Program
	{
		static void Main(string[] args)
		{
			string variable = Console.ReadLine();
			Boolean isTrue = Convert.ToBoolean(variable);

			if (isTrue)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
