using System;
using System.Collections.Generic;
using System.Linq;

namespace _08Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var output = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] cmdArgs = input.Split(" -> ");
                string company = cmdArgs[0];
                string employee = cmdArgs[1];

                if(!output.ContainsKey(company))
                {
                    output.Add(company, new List<string>());

                }


                if(!output[company].Contains(employee))
                {
                    output[company].Add(employee);
                }


                input = Console.ReadLine();
            }

            foreach (var item in output.OrderBy(item => item.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
