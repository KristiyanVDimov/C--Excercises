using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Message
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Random rnd = new Random();

			PrintMessages(n, rnd);
		}

		private static void PrintMessages(int messageCount, Random rnd)
		{
			for (int i = 0; i < messageCount; i++)
			{
				Console.WriteLine($"{GeneratePhrase(rnd)} {GenerateEvent(rnd)} {GenerateAuthor(rnd)} - {GenerateCity(rnd)}");
			}
		}

		private static string GenerateCity(Random rnd)
		{
			string[] cities = new string[]
			{
				"Burgas",
				"Sofia",
				"Plovdiv",
				"Varna",
				"Ruse"
			};

			return cities[rnd.Next(0, cities.Length)];
		}

		private static string GenerateAuthor(Random rnd)
		{
			string[] authors = new string[]
			{
				"Diana",
				"Petya",
				"Stella",
				"Elena",
				"Katya",
				"Iva",
				"Annie",
				"Eva"
			};

			return authors[rnd.Next(0, authors.Length)];
		}

		private static string GenerateEvent(Random rnd)
		{
			string[] events = new string[]
			{
				"Now I feel good.",
				"I have succeeded with this product.",
				"Makes miracles. I am happy of the results!",
				"I cannot believe but now I feel awesome.",
				"Try it yourself, I am very satisfied.",
				"I feel great!"
			};

			return events[rnd.Next(0, events.Length)];
		}

		private static string GeneratePhrase(Random rnd)
		{
			string[] phrases = new string[]
			{
				"Excellent product.",
				"Such a great product.",
				"I always use that product.",
				"Best product of its category.",
				"Exceptional product.",
				"I can't live without this product."
			};

			return phrases[rnd.Next(0, phrases.Length)];
		}
	}
}
