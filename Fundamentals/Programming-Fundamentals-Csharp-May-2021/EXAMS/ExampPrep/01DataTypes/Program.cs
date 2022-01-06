using System;

namespace _01DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
          
            string num = Console.ReadLine();
            if (input == "int")
            {
                printTheInteger(num);
            }
            else if (input == "real")
            {
                printTheReal(num);
            }
            else if (input == "string")
            {
                printTheString(num);
            }
        }

        private static void printTheString(string num)
        {
            Console.WriteLine($"${num}$");
        }

        private static void printTheReal(string num)
        {
            double result = double.Parse(num) * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        private static void printTheInteger(string num)
        {
            int result = 2 * int.Parse(num);
            Console.WriteLine(result);
        }
    }
}
