using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();


            for (int i = 0; i < nums.Count; i++)
            {
                int element = nums[i];
                int index = Calculate(element);

                char currentChar = GetCharMessage(index, input);

                int realIndex = CalcRealIndex(index, input);
                string newMessage = input.Remove(realIndex, 1);
                input = newMessage;
            }

            Console.WriteLine();
        }

        private static int CalcRealIndex(int index, string input)
        {
            int countIndex = 0;

            for (int i = 0; i < index; i++)
            {
                countIndex++;

                if (countIndex == input.Length)
                {
                    countIndex = 0;
                }
            }
            return countIndex;
        }

        private static char GetCharMessage(int index, string input)
        {
            int count = 0;
            for (int i = 0; i < index; i++)
            {
                count++;

                if (count == input.Length)
                {
                    count = 0;
                }

            }

            char currentChar = input[count];
            return currentChar;
        }

        static int Calculate(int element)
        {


            int index = 0;
            while (element > 0)
            {
                int currentNumber = element % 10;
                index += currentNumber;
                element /= 10;
            }
            return index;
        }
    }
}

