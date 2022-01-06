using System;

namespace _09KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int bestCount = 0;
            int bestBeginIndex = 0;
            int bestSum = 0;
            int bestCounter = 0;
            string bestSequence = "";

            string input = string.Empty;
            while (input != "Clone them!")
            {
                string sequence = input.Replace("!", "");
                string[] dnaParts = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries);

                int count = 0;
                int sum = 0;

                string bestSubSequence = "";

                foreach (var dnaPart in dnaParts)
                {
                    if(dnaPart.Length > count)
                    {
                        count = dnaPart.Length;
                        bestSubSequence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }
                int beginIndex = sequence.IndexOf(bestSubSequence);
                if (count > bestCount ||
                  (count == bestCount && beginIndex < bestBeginIndex) ||
                      (count == bestCount && beginIndex == bestBeginIndex && sum > bestSum) || (count == 1))
                {

                    bestCount = count;
                    bestSequence = sequence;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;

                }
            }
            char[] result = bestSequence.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", result)} ");

        }
        
    }
}
