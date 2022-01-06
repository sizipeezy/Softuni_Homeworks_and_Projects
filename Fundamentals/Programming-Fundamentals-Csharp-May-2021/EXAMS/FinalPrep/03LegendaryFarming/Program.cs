using System;
using System.Collections.Generic;

namespace _03LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var output = new Dictionary<string, List<double>>();
            while (input != "buy")
            {
                string[] cmdArgs = input.Split(" ");
                string name = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                double quantity = double.Parse(cmdArgs[2]);
                if (!output.ContainsKey(name))
                {
                    output.Add(name, new List<double> { price, quantity });
                }
                else
                {
                    output[name][0] = price;
                    output[name][1] = output[name][1] += quantity;
                }



                input = Console.ReadLine();
            }

            foreach (var item in output)
            {
                double total = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {total:f2}");
            }
        }
    }
}
