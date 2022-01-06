using System;
using System.Collections.Generic;

namespace Lists03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();

                products.Add(product);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i} = {products[i]}");
            }
        }
    }
}
