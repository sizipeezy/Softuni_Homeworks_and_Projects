using System;
using System.Linq;

namespace _02ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            int temp = 0;

            while (input != "end")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];


                if(command == "swap")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);


                    temp = nums[index1];
                    nums[index1] = nums[index2];
                    nums[index2] = temp;
                }
                else if(command == "multiply")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    nums[index1] *= nums[index2];
                }
                else if(command == "decrease")
                {
                    nums= Array.ConvertAll(nums, x => x - 1);
                }
                




                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
