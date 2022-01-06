using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {

        private readonly IList<Item> internalItems;

        protected Bag(int capacity)
        {
            this.Capacity = capacity;
            this.internalItems = new List<Item>();
            this.Items = new ReadOnlyCollection<Item>(internalItems);
        }
        public int Capacity { get; set; }

        public int Load { get => Items.Sum(item => item.Weight); }


        public IReadOnlyCollection<Item> Items { get; }

        public void AddItem(Item item)
        {

            if (this.Load + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }

            this.internalItems.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.internalItems.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }

            Item findItem = this.Items.FirstOrDefault(x => x.GetType().Name == name);

            if (findItem == null)
            {
                throw new ArgumentException(ExceptionMessages.ItemNotFoundInBag, name);
            }

            this.internalItems.Remove(findItem);
            return findItem;
        }
    }
}
