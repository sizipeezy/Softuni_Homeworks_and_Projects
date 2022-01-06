using System;

namespace _03Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(a, b);
                    break;

                case "divide":
                    Divide(a, b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "multiply":
                    Mulitply(a, b);
                    break;
                default:
                    break;
            }
        }

        private static void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }

        private static void Mulitply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }

        private static void Divide(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }

        private static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
    }
}
