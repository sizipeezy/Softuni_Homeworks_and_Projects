using System;
using System.Collections.Generic;
using System.Linq;

namespace _07StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var output = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                if(!output.ContainsKey(name))
                {
                    output.Add(name, new List<double>());
                }
                output[name].Add(grade);
            }

            foreach (var item in output.OrderByDescending(x => x.Value.Average()))
            {
                if (item.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.OrderByDescending(x => x).Average():f2}");
                }
            }
        }
    }
}
