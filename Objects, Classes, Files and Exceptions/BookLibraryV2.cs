using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Book_Library
{
	class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string Publisher { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string ISBN { get; set; }
		public double Price { get; set; }

		public static Book ReadBook()
		{
			var bookInfo = Console.ReadLine().Split(' ').ToArray();
			Book book = new Book();
			var date = bookInfo[3].Split('.').Select(int.Parse).ToArray();

			book.Title = bookInfo[0];
			book.Author = bookInfo[1];
			book.Publisher = bookInfo[2];
			book.ReleaseDate = new DateTime(date[2], date[1], date[0]);
			book.ISBN = bookInfo[4];
			book.Price = double.Parse(bookInfo[5]);

			return book;
		}
	}

	class Library : Book
	{
		public string Name { get; set; }
		public List<Book> Books { get; set; }

		static List<Book> ReadBooks(int count)
		{
			var books = new List<Book>();
			Book book = new Book();

			for (int i = 0; i < count; i++)
			{
				book = ReadBook();
				books.Add(book);
			}

			return books;
		}

		static void PrintLibrary(List<Book> books, DateTime date)
		{
			var libraryBooks = new Dictionary<string, DateTime>();

			foreach (var book in books)
			{
				libraryBooks[book.Title] = book.ReleaseDate;
			}

			foreach (var book in libraryBooks.OrderBy(d => d.Value).ThenBy(s => s.Key.Length))
			{
				if(book.Value > date)
				{
					Console.WriteLine($"{book.Key} -> {book.Value.Day}.{book.Value.Month:D2}.{book.Value.Year}");
				}
			}
		}

		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			Library library = new Library()
			{
				Books = ReadBooks(n)
			};
			var dateInput = Console.ReadLine().Split('.').Select(int.Parse).ToArray();

			var date = new DateTime(dateInput[2], dateInput[1], dateInput[0]);

			PrintLibrary(library.Books, date);
		}
	}
}
