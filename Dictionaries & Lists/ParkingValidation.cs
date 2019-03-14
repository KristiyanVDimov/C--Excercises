using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Validation
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var parkingLot = new Dictionary<string, string>();

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ').ToList();

				DoCommand(input, parkingLot);
			}

			foreach (var user in parkingLot)
			{
				Console.WriteLine($"{user.Key} => {user.Value}");
			}
		}

		static void DoCommand(List<string> input, Dictionary<string, string> parkingLot)
		{
			switch (input[0])
			{
				case "register":
					bool isValid = CheckLicencePlate(input[2]);
					if (parkingLot.ContainsKey(input[1]))
					{
						Console.WriteLine($"ERROR: already registered with plate number {parkingLot[input[1]]}");
						break;
					}
					else if (!isValid)
					{
						Console.WriteLine($"ERROR: invalid license plate {input[2]}");
						break;
					}
					else if (parkingLot.ContainsValue(input[2]))
					{
						Console.WriteLine($"ERROR: license plate {input[2]} is busy");
						break;
					}
					else
					{
						parkingLot.Add(input[1], input[2]);
						Console.WriteLine($"{input[1]} registered {input[2]} successfully");
					}
					break;
				case "unregister":
					if (parkingLot.ContainsKey(input[1]))
					{
						parkingLot.Remove(input[1]);
						Console.WriteLine($"user {input[1]} unregistered successfully");
					}
					else
					{
						Console.WriteLine($"ERROR: user {input[1]} not found");
					}
					break;
			}
		}

		static bool CheckLicencePlate(string plateNumber)
		{
			for(int i = 0; i <= 1; i++)
			{
				if (!char.IsUpper(plateNumber[i]))
				{
					return false;
				}
			}
			for (int i = 2; i <= 5; i++)
			{
				if (!char.IsDigit(plateNumber[i]))
				{
					return false;
				}
			}
			for(int i = 6; i <= 7; i++)
			{
				if (!char.IsUpper(plateNumber[i]))
				{
					return false;
				}
			}

			return true;
		}
	}
}
