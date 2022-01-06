using System;
using System.Collections.Generic;
using System.Linq;

namespace _01TrainList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                
                if(command == "Add")
                {
                    int passengers = int.Parse(cmdArgs[1]);

                    nums.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(cmdArgs[0]);
                    for (int i = 0; i < nums.Count; i++)
                    {
                        int curr = nums[i];
                        bool isEnough = curr + passengers <= capacity;
                        if(isEnough)
                        {
                            nums[i] += passengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
         }
    }
}
