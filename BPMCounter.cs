using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
	class Program
	{
		static void Main(string[] args)
		{
			var BPM = int.Parse(Console.ReadLine());
			var numberOfBeats = int.Parse(Console.ReadLine());
			var bars = numberOfBeats / 4.0;
			var seconds = (60.0 / BPM) * numberOfBeats;
			Console.WriteLine($"{Math.Round(bars, 1)} bars - {Math.Truncate(seconds / 60)}m {Math.Truncate(seconds % 60)}s");
		}
	}
}
