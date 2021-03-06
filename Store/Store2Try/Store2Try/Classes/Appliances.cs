using System;
using System.Collections.Generic;
using System.Text;

namespace Store2Try
{
    public class Appliances : Product
    {
        public Appliances(string name, 
            string brand,
            double price, 
            string model, 
            string productionDate,
            double weight) 
            : base(name, brand, price)
        {
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }

        public string Model { get; private set; }

        public string ProductionDate { get; private set; }

        public double Weight { get; private set; }

        public override double Discount()
        {
            double discount = 0;
            DateTime date = DateTime.Now;
            if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday
                || this.Weight > 999)
            {
                discount += this.Price - (0.10 * Price);
            }

            return discount;
        }
    }
}
