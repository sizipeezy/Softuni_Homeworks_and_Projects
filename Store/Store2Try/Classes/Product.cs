using System;
using System.Collections.Generic;
using System.Text;

namespace Store2Try
{
    public abstract class Product : IProduct
    {
        protected Product(string name, string brand, double price)
        {
            Name = name;
            Brand = brand;
            Price = price;
        }

        public string Name { get; private set; }
        public string Brand { get; private set; }
        public double Price { get;  set; }

        public abstract double Discount();
      
    }
}
