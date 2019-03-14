using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heists
{
	class Heists
	{
		static void Main(string[] args)
		{
			int[] prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
			string heistInfo = Console.ReadLine();
			int earnings = 0;
			int totalExpenses = 0;

			while (!heistInfo.Equals("Jail Time"))
			{
				string[] arr = heistInfo.Split().ToArray();
				char[] heist = arr[0].ToCharArray();
				int expenses = int.Parse(arr[1]);
				int jewelsPrice = prices[0];
				int goldPrice = prices[1];

				for(int i = 0; i < heist.Length; i++)
				{
					if(heist[i] == '%')
					{
						earnings += jewelsPrice;
					}
					if(heist[i] == '$')
					{
						earnings += goldPrice;
					}
				}
				totalExpenses += expenses;
				heistInfo = Console.ReadLine();
			}
			
			if(earnings >= totalExpenses)
			{
				Console.WriteLine($"Heists will continue. Total earnings: {earnings - totalExpenses}.");
			}
			else
			{
				Console.WriteLine($"Have to find another job. Lost: {totalExpenses - earnings}.");
			}
		}
	}
}
