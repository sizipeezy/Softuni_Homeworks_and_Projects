using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private readonly List<T> box;

        public Box()
        {
            this.box = new List<T>();
        }

        public int Count => this.box.Count;
        public void Add(T element)
        {
            this.box.Add(element);
        }

        public T Remove()
        {
            T result = box.LastOrDefault();
            box.Remove(result);

            return result;
        }


    }
}
