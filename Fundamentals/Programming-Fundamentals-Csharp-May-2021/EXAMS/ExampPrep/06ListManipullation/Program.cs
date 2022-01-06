using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ListManipullation
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
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                if(command == "Add")
                {
                    int num = int.Parse(cmdArgs[1]);
                    nums.Add(num);
                }
                else if(command == "Remove")
                {
                    int num = int.Parse(cmdArgs[1]);
                    nums.Remove(num);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(cmdArgs[1]);
                    nums.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    nums.Insert(index, number);
                }



                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
