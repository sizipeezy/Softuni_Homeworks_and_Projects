using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                if(command == "Delete")
                {
                    int num = int.Parse(cmdArgs[1]);
                    nums.RemoveAll(x => x == num);
                }
                else if(command == "Insert")
                {
                    int element = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    nums.Insert(index, element);
                }


                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
