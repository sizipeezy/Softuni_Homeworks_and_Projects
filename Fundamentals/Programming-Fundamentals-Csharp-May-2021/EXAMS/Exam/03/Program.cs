using System;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int entryPoint = int.Parse(Console.ReadLine());

            string type = Console.ReadLine();
            int leftSum = 0;
            int rightSUm = 0;
            for (int i = 0; i < priceRatings.Length; i++)
            {
                int index = priceRatings[entryPoint];
               
                if(priceRatings[i] < entryPoint)
                {
                    leftSum += priceRatings[i];
                    
                }
                else
                {
                    rightSUm += priceRatings[i];
                }
            }

            if(type == "cheap")
            {
                if(leftSum == rightSUm)
                {
                    Console.WriteLine($"Left - {leftSum}");
                }
                
                if(rightSUm < leftSum)
                {
                    Console.WriteLine($"Left - {leftSum}");
                }
                else
                {
                    Console.WriteLine($"Right - {rightSUm}");
                }
            }
            
        }
    }
}
