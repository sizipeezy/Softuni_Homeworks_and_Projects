using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private IReadOnlyList<int> data;

        public Lake(params int[] _data)
        {
            this.data = new List<int>(_data);
        }


        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < data.Count; i++)
            {
                if(i % 2 == 0)
                {
                    yield return data[i];
                }

            }

            for (int i = data.Count - 1; i >= 0; i--)
            {
                if(i % 2 != 0)
                {
                    yield return data[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  
    }
}
