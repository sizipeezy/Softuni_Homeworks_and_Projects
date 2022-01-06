using System;

namespace _06CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int weidth = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            printResult(weidth, length);

        }

        private static int printResult(int weidth, int length)
        {
            int result = weidth * length;
            Console.WriteLine(result);
            return result;
        }
    }
    
}
