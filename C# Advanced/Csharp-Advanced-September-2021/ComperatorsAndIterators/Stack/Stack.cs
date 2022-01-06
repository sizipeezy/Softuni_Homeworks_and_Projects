using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Stack<T>: IEnumerable<T>
    {
        private IList<T> data;
     
        public Stack(params T[] _data)
        {
            this.data = new List<T>(_data);
        }   

        public T Pop()
        {
          
            if(data.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            T element = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return element;
        }

        public void Push(params T[] elements)
        {
            foreach (T element in elements)
            {
                data.Insert(data.Count, element);
            }
            
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = data.Count - 1; i >= 0; i--)
            {
                yield return data[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
