using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        private const int defaultSize = 5;
        public SaltwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
            this.Size = defaultSize;
        }

        public override void Eat()
        {
            base.Eat();
            this.Size += 2;
        }
    }
}
