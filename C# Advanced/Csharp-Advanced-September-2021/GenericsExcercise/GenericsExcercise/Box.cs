using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExcercise
{
    public class Box<T>
    {
        private readonly List<T> items;

        public Box()
        {
            this.items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.AppendLine($"System.Int32: {item}");
            }
            
            return sb.ToString().TrimEnd();
        }
    }
}
