using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Product
    {
        
		private string name;
		private double price;
		public Product(string name, double price)
		{
			Name = name;
			Price = price;
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

		public double Price
		{
			get
			{
				return price;
			}

			set
			{
				price = value;
			}
		}

		public override string ToString()
		{
			return string.Format("Product {0} costs {1:f2} lv.", Name, Price);
		}
    }
}
