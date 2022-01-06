using System;

namespace _10MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(num);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int num)
        {
            int sumOfEvens = 0;
            while (num != 0)
            {
                int nextNum = num % 10;

                if (nextNum % 2 == 0)
                {
                    sumOfEvens += nextNum;
                }
                num -= nextNum;
                num /= 10;
            }
            return sumOfEvens;


        }
        static int GetSumOfOddDigits(int num)
        {
            int sumOfOdds = 0;
            while (num != 0)
            {
                int nextNum = num % 10;

                if (nextNum % 2 == 1)
                {
                    sumOfOdds += nextNum;
                }
                num -= nextNum;
                num /= 10;

            }

            return sumOfOdds;
        }

        static int GetMultipleOfEvenAndOdds(int num)
        {

            int result = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
            return result;
        }
    }
}

