using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			try
			{
				long n = long.Parse(number);
				string fitsIn = "";

				if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
				{
					fitsIn += "* sbyte\r\n";
				}
				if (n >= byte.MinValue && n <= byte.MaxValue)
				{
					fitsIn += "* byte\r\n";
				}
				if (n >= short.MinValue && n <= short.MaxValue)
				{
					fitsIn += "* short\r\n";
				}
				if (n >= ushort.MinValue && n <= ushort.MaxValue)
				{
					fitsIn += "* ushort\r\n";
				}
				if (n >= int.MinValue && n <= int.MaxValue)
				{
					fitsIn += "* int\r\n";
				}
				if (n >= uint.MinValue && n <= uint.MaxValue)
				{
					fitsIn += "* uint\r\n";
				}
				if (n >= long.MinValue && n <= long.MaxValue)
				{
					fitsIn += "* long\r\n";
				}
				Console.WriteLine($"{n} can fit in:\r\n{fitsIn}");
			}
			catch
			{
				Console.WriteLine($"{number} can't fit in any type");
			}
		}
	}
}
