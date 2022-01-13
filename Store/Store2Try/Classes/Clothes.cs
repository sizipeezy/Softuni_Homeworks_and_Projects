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
            int diff = (int)date.DayOfWeek - (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek; //sunday=always0, monday=always1, etc
            if (diff < 0)
            {
                diff += 7;
            }

            if (diff > 1 && diff < 7)
            {
                discount = this.Price - (0.10 * Price);
            }
            return discount;
        }
    }
}

