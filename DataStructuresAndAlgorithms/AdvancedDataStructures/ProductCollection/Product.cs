namespace ProductCollection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Product: IComparable<Product>
    {
        public string Name;
        public double Price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public int CompareTo(Product other)
        {
            if (this.Price < other.Price)
            {
                return -1;
            }
            else if (this.Price > other.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
