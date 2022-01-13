using System;
using System.Collections.Generic;
using System.Text;

namespace Store2Try
{
    public class Food : Product, IFood
    {
        public Food(string name, string brand, double price, string expirationDate) 
            : base(name, brand, price)
        {
            this.ExpirationDate = expirationDate;
        }

        public string ExpirationDate { get; set; }

        public override double Discount()
        {

            DateTime dateNow = DateTime.Now;
            DateTime d1 = DateTime.ParseExact(ExpirationDate, "dd-MM-yyyy", null);


            TimeSpan t = d1 - dateNow;
            double daysLeft = t.TotalDays;

            double discount = 0;

            if (daysLeft > 5 && daysLeft < 10)
            {
                discount = this.Price -= (0.010 * Price);
            }
            else if (daysLeft < 5)
            {
                discount = this.Price -= (0.5 * Price);
            }
            return discount;
        }
    }
}
