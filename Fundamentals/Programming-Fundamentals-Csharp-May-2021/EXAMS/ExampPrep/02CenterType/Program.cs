using System;

namespace _02CenterType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintPrevious(number);
        }

        private static void PrintPrevious(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0} ", GetTribonacci(i));
            }
        }

        private static int GetTribonacci(int num)
        {
            if (num <= 2)
            {
                return 1;
            }

            if (num == 3)
            {
                return 2;
            }
            else
            {
                return GetTribonacci(num - 3) +
                GetTribonacci(num - 2) +
                    GetTribonacci(num - 1);
            }
        }
    }
    
}
