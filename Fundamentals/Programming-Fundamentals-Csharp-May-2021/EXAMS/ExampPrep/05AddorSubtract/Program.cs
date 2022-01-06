using System;

namespace _05AddorSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Sum(n1, n2, n3);
        }

        private static void Sum(int n1, int n2, int n3)
        {
            int result = n1 + n2;
            Subtract(result, n3);
        }

        private static void Subtract(int result, int n3)
        {
            int final = result - n3;
            Console.WriteLine(final);
        }
    }
}
