using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
	class Program
	{
		static void Main(string[] args)
		{
			int pictures = int.Parse(Console.ReadLine());
			int filterTime = int.Parse(Console.ReadLine());
			int filterFactor = int.Parse(Console.ReadLine());
			int uploadTime = int.Parse(Console.ReadLine());

			double filterPercendage = filterFactor / 100.0;

		    int goodPictures = (int)Math.Ceiling(pictures * filterPercendage);
			//long totalTime = (long)(pictures * filterTime) + (goodPictures * uploadTime);
			long totalFilterTime = pictures * (long)filterTime;
			long totalUploadTime = goodPictures * (long)uploadTime;
			

			TimeSpan fromSeconds = TimeSpan.FromSeconds(totalFilterTime + totalUploadTime);
			Console.WriteLine($"{fromSeconds.Days}:{fromSeconds.Hours:D2}:{fromSeconds.Minutes:D2}:{fromSeconds.Seconds:D2}");
			//Console.WriteLine(TimeSpan.FromSeconds(totalTime).ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
		}
	}
}
