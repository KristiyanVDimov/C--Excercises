using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Count_Work_Days
{
	class Program
	{
		static void Main(string[] args)
		{
			var start = Console.ReadLine();
			var end = Console.ReadLine();

			DateTime startDate = DateTime.ParseExact(start, "dd-MM-yyyy", null);
			DateTime endDate = DateTime.ParseExact(end, "dd-MM-yyyy", null);

			int workingDayCounter = 0;

			for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
			{
				if(i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !IsHoliday(i))
				{
					workingDayCounter++;
				}
			}

			Console.WriteLine(workingDayCounter);
		}

		static bool IsHoliday(DateTime date)
		{
			bool isHoliday = false;

			DateTime[] holidays = new DateTime[]
			{
				new DateTime(2016, 01, 01),
				new DateTime(2016, 03, 03),
				new DateTime(2016, 05, 01),
				new DateTime(2016, 05, 06),
				new DateTime(2016, 05, 24),
				new DateTime(2016, 09, 06),
				new DateTime(2016, 09, 22),
				new DateTime(2016, 11, 01),
				new DateTime(2016, 12, 24),
				new DateTime(2016, 12, 25),
				new DateTime(2016, 12, 26)
			};

			for(int i = 0; i < holidays.Length; i++)
			{
				if(date.Day == holidays[i].Day && date.Month == holidays[i].Month)
				{
					isHoliday = true;
				}
			}

			return isHoliday;
		}
	}
}
