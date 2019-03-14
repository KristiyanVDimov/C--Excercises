using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Typing
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var mainDigit = 0;
			var offset = 0;
			var letterIndex = 0;
			var newLetter = ' ';
			var sentence = "";
			while (n > 0)
			{
				var number = int.Parse(Console.ReadLine()).ToString();
				n--;
				
				switch (number.Length)
				{
					case 1:
						mainDigit = int.Parse(number);
						offset = (mainDigit - 2) * 3;
						if (mainDigit == 8 || mainDigit == 9)
						{
							offset++;
						}
						letterIndex = offset + number.Length - 1;
						break;
					case 2:
						mainDigit = int.Parse(number) / 10;
						offset = (mainDigit - 2) * 3;
						if (mainDigit == 8 || mainDigit == 9)
						{
							offset++;
						}
						letterIndex = offset + number.Length - 1;
						break;
					case 3:
						mainDigit = int.Parse(number) / 100;
						offset = (mainDigit - 2) * 3;
						if (mainDigit == 8 || mainDigit == 9)
						{
							offset++;
						}
						letterIndex = offset + number.Length - 1;
						break;
					case 4:
						mainDigit = int.Parse(number) / 1000;
						offset = (mainDigit - 2) * 3;
						if (mainDigit == 8 || mainDigit == 9)
						{
							offset++;
						}
						letterIndex = offset + number.Length - 1;
						break;
				}
				if (number.Equals("0"))
				{
					letterIndex = -65;
				}
				newLetter = (char)(97 + letterIndex);
				
				//switch (letterIndex)
				//{
				//	case 0: letter = "a"; break;
				//	case 1: letter = "b"; break;
				//	case 2: letter = "c"; break;
				//	case 3: letter = "d"; break;
				//	case 4: letter = "e"; break;
				//	case 5: letter = "f"; break;
				//	case 6: letter = "g"; break;
				//	case 7: letter = "h"; break;
				//	case 8: letter = "i"; break;
				//	case 9: letter = "j"; break;
				//	case 11: letter = "k"; break;
				//	case 12: letter = "l"; break;
				//	case 13: letter = "m"; break;
				//	case 14: letter = "n"; break;
				//	case 15: letter = "o"; break;
				//	case 16: letter = "p"; break;
				//	case 17: letter = "q"; break;
				//	case 18: letter = "r"; break;
				//	case 19: letter = "s"; break;
				//	case 20: letter = "t"; break;
				//	case 21: letter = "u"; break;
				//	case 22: letter = "v"; break;
				//	case 23: letter = "w"; break;
				//	case 24: letter = "x"; break;
				//	case 25: letter = "y"; break;
				//	case 26: letter = "z"; break;
				//}
				sentence += newLetter;
			}
			Console.WriteLine(sentence);
		}
	}
}
