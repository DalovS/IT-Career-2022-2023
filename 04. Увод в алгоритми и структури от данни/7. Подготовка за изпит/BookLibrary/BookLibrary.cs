using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    public class BookLibrary
    {
        
		private string name;
		private List<Book> books;
		public BookLibrary(string name)
		{
			this.name = name;
			this.books = new List<Book>();
		}

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public List<Book> Books
		{
			get
			{
				return books;
			}

			set
			{
				books = value;
			}
		}

		public void AddBook(string title, double rating)
		{
			Book book = new Book(title, rating);
			books.Add(book);
		}

		public double AverageRating()
		{
			if (books.Count == 0)
			{
				return 0;
			}

			double sum = 0;
			foreach (Book book in books)
			{
				sum += book.Rating;
			}

			return sum / books.Count;
		}

		public List<string> GetBooksByRating(double rating)
		{
			List<string> result = new List<string>();
			foreach (Book book in books)
			{
				if (book.Rating > rating)
				{
					result.Add(book.Title);
				}
			}

			return result;
		}

		public List<Book> SortByTitle()
		{
			List<Book> sorted = books.OrderBy(b => b.Title).ToList();
			return sorted;
		}

		public List<Book> SortByRating()
		{
			List<Book> sorted = books.OrderByDescending(b => b.Rating).ToList();
			return sorted;
		}

		public string[] ProvideInformationAboutAllBooks()
		{
			string[] booksInfo = new string[books.Count];
			for (int i = 0; i < books.Count; i++)
			{
				booksInfo[i] = books[i].ToString();
			}

			return booksInfo;
		}

		public bool CheckBookIsInBookLibrary(string title)
		{
			foreach (Book book in books)
			{
				if (book.Title == title)
				{
					return true;
				}
			}

			return false;
		}}
}
