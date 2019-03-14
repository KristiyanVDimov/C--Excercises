using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Skip_Rope
{
	class Program
	{
		static void Main(string[] args)
		{
			var encryptedMessage = Console.ReadLine();
			var digits = new List<int>();

			for (int i = 0; i < encryptedMessage.Length; i++)
			{
				if (char.IsNumber(encryptedMessage[i]))
				{
					string digit = encryptedMessage[i].ToString();
					digits.Add(int.Parse(digit));
					encryptedMessage = encryptedMessage.Remove(encryptedMessage.IndexOf(encryptedMessage[i]), 1);
					i--;
				}
			}

			var takeList = new List<int>();
			var skipList = new List<int>();

			for (int i = 0; i < digits.Count; i++)
			{
				if(i % 2 == 0)
				{
					takeList.Add(digits[i]);
				}
				else
				{
					skipList.Add(digits[i]);
				}
			}
			
			var result = string.Empty;
			var totalSkip = 0;
			var letters = encryptedMessage.ToCharArray();

			for (int i = 0; i < takeList.Count; i++)
			{
				var skip = skipList[i];
				var take = takeList[i];

				result += new string(letters.Skip(totalSkip).Take(take).ToArray());

				totalSkip += skip + take;
			}

			Console.WriteLine(result);
		}
	}
}
