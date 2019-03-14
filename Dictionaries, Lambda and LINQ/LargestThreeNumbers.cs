using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList()));
		}
	}
}
