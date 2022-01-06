using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory
{
    public class Backpack : Bag
    {
        private const int defaultCapacity = 100;
        public Backpack() : base(defaultCapacity)
        {
        }
    }
}
