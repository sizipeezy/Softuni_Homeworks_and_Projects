using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwap
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }
        public T Value { get; set; }

        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }




        //public void Swap(int first, int second)
        //{
        //    T item = data[first];
        //    data[first] = data[second];
        //    data[second] = item;
        //}

        // public override string ToString()
        // {
        //     var sb = new StringBuilder();
        //
        //     foreach (var item in data)
        //     {
        //         sb.AppendLine($"{typeof(T)}: {item}");
        //     }
        //
        //     return sb.ToString().TrimEnd();
        // }
    }
}
