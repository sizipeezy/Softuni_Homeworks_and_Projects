using System;
using System.Linq;

namespace _02MidExam_Shoot
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
            int count = 0;

            while (input != "End")
            {
                int target = int.Parse(input);
                if(target < 0 || target >= nums.Length || nums[target] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int shot = nums[target];
                nums[target] = -1;
                count++;

                for (int i = 0; i < nums.Length; i++)
                {
                    if(nums[i] == -1)
                    {
                        continue;
                    }
                    if(nums[i] > shot)
                    {
                        nums[i] -= shot;
                    }
                    else
                    {
                        nums[i] += shot;
                    }
                }




            }
            Console.WriteLine($"Shot targets: {count} -> { string.Join(" ", nums) }");
        }
    }
}
