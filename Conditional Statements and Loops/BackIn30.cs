using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_in_30_minutes
{
	class Program
	{
		static void Main(string[] args)
		{
			var hours = int.Parse(Console.ReadLine());
			var minutes = int.Parse(Console.ReadLine());
			minutes += 30;
			
			if(minutes >= 60)
			{
				hours++;
				minutes -= 60;
			}
			if(hours >= 24)
			{
				hours = hours - 24;
			}
			Console.WriteLine($"{hours}:{minutes:D2}");
			
		}
	}
}
