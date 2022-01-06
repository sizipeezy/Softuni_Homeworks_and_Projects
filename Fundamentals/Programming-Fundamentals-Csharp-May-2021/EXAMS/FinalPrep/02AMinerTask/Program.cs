using System;
using System.Collections.Generic;

namespace _02AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var output = new Dictionary<string, int>();

            while (input != "stop")
            {
                string[] cmdArgs = input.Split(" ");
                string resource = cmdArgs[0];

                int quantity = int.Parse(Console.ReadLine());

                if(!output.ContainsKey(resource))
                {
                    output.Add(resource, quantity);
                }
                else
                {
                    output[resource] += quantity;
                }



                input = Console.ReadLine();
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
