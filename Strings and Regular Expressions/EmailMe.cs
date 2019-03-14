using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Email_me
{
	class Program
	{
		static void Main(string[] args)
		{
			var email = Console.ReadLine();
			var index = email.IndexOf("@");
			var strAfter = email.Substring(index + 1);
			var strBefore = email.Substring(0, index);

			var afterSum = 0;
			var beforeSum = 0;

			for (int i = 0; i < strAfter.Length; i++)
			{
				afterSum += (int)strAfter[i];
			}
			for (int i = 0; i < strBefore.Length; i++)
			{
				beforeSum += (int)strBefore[i];
			}

			if(beforeSum - afterSum >= 0)
			{
				Console.WriteLine("Call her!");
			}
			else
			{
				Console.WriteLine("She is not the one.");
			}
		}
	}
}
