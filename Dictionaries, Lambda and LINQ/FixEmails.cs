using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = new List<string>();
			List<string> emails = new List<string>();
			var count = 1;
			Dictionary<string, string> fixedEmails = new Dictionary<string, string>();

			while (true)
			{
				var input = Console.ReadLine();

				if(input == "stop")
				{
					break;
				}
				if(count % 2 != 0)
				{
					names.Add(input);
				}
				else
				{
					emails.Add(input);
				}
				count++;
			}

			for(int i = 0; i < names.Count; i++)
			{
				fixedEmails.Add(names[i], emails[i]);
			}

			foreach (var email in fixedEmails)
			{
				if(email.Value.EndsWith("uk") || email.Value.EndsWith("us"))
				{
					continue;
				}
				else
				{
					Console.WriteLine($"{email.Key} -> {email.Value}");
				}
			}
		}
	}
}
