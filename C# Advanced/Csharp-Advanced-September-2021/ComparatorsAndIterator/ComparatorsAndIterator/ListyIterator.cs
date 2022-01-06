using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index;
        public ListyIterator(params T[] collection)
        {
            index = 0;
            this.items = collection.ToList();
        }

        public List<T> items { get; set; }

     
        public bool Move()
        {
            int tempIndex = index;
            if (++tempIndex < items.Count)
            {
                index++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(items[index]);
            }
        }

        public void PrintAll()
        {
            foreach (var item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public bool HasNext()
        {
            int tempIndex = index;
            return ++tempIndex < items.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
