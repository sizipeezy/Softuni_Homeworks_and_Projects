using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Store2Try
{
    public class Clothes : Product
    {

        public Clothes(string name, string brand, double price, string size, string color) 
            : base(name, brand, price)
        {
            this.Size = size;
            this.Color = color;
        }

        public string Size { get; private set; }

        public string Color { get; private set; }

        public override double Discount()
        {

            double discount = 0;
            DateTime date = DateTime.Now;
          

            if(date.DayOfWeek == DayOfWeek.Monday)
            {
                discount += this.Price - (0.10 * Price); 
            }
            else if(date.DayOfWeek == DayOfWeek.Tuesday)
            {
                discount += this.Price - (0.10 * Price);
            }
            else if(date.DayOfWeek == DayOfWeek.Wednesday)
            {
                discount += this.Price - (0.10 * Price);
            }
            else if(date.DayOfWeek == DayOfWeek.Thursday)
            {
                discount += this.Price - (0.10 * Price);
            }
            else if(date.DayOfWeek == DayOfWeek.Friday)
            {
                discount += this.Price - (0.10 * Price);
            }
         
            return discount;
        }
    }
}

