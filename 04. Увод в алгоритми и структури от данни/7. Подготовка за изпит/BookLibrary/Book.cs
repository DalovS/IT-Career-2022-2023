using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    public class Book
    {private string title;
		private double rating;
		public Book(string title, double rating)
		{
			this.title = title;
			this.rating = rating;
		}

		public string Title
		{
			get
			{
				return title;
			}

			set
			{
				title = value;
			}
		}

		public double Rating
		{
			get
			{
				return rating;
			}

			set
			{
				rating = value;
			}
		}

		public override string ToString()
		{
			return string.Format("Book {0} is with {1} rating", title, rating);
		}
    }
}
