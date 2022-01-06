using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];
                char firstLetter = curr[0];
                char lastLetter = curr[curr.Length - 1];

                double number = double.Parse(curr.Substring(1, curr.Length - 2));

                int firstElementIndex = alpha.IndexOf(char.ToUpper(firstLetter));
                int secondElementIndex = alpha.IndexOf(char.ToUpper(lastLetter));


                if ((int)firstLetter >= 65 && (int)firstLetter <= 90)
                {
                    number = number / (firstElementIndex + 1);
                }
                else
                {
                    number = number * (firstElementIndex + 1);
                }

                if ((int)lastLetter >= 65 && (int)lastLetter <= 90)
                {
                    number = number - (secondElementIndex + 1);

                }
                else
                {
                    number = number + (secondElementIndex + 1);
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }

}
