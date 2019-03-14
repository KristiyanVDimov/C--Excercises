using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			book.Title = bookInfo[0];
			book.Author = bookInfo[1];
			book.Publisher = bookInfo[2];
			book.ReleaseDate = DateTime.Parse(bookInfo[3]);
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

		static void PrintLibrary(List<Book> books)
		{
			var libraryBooks = new Dictionary<string, double>();

			foreach (var book in books)
			{
				if (!libraryBooks.ContainsKey(book.Author))
				{
					libraryBooks.Add(book.Author, book.Price);
				}
				else
				{
					libraryBooks[book.Author] += book.Price;
				}
			}

			foreach (var book in libraryBooks.OrderBy(s => -s.Value).ThenBy(t => t.Key.Length))
			{
				Console.WriteLine($"{book.Key} -> {book.Value:f2}");
			}
		}

		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			Library library = new Library();
			library.Books = ReadBooks(n);

			PrintLibrary(library.Books);
		}
	}
}
