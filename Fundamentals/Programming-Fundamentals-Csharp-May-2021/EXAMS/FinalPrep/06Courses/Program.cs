using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var output = new Dictionary<string, List<string>>();


            while (input != "end")
            {
                string[] cmdArgs = input.Split(" : ");
                string course = cmdArgs[0];
                string student = cmdArgs[1];

                if (!output.ContainsKey(course))
                {
                    output.Add(course, new List<string>());
                }

                output[course].Add(student);

                input = Console.ReadLine();

            }

            foreach (var item in output.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var it in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {it}");
                }
            }
        }
    }
}
