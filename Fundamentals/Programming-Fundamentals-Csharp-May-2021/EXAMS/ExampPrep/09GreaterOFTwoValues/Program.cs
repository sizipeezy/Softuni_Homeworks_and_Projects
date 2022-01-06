using System;

namespace _09GreaterOFTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == "int")
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                Print(n1, n2);
            }
            else if (input == "char")
            {
                char n1 = char.Parse(Console.ReadLine());

                char n2 = char.Parse(Console.ReadLine());

                PrintChar(n1, n2);

            }
            else if (input == "string")
            {
                string n1 = Console.ReadLine();
                string n2 = Console.ReadLine();

                PrintString(n1, n2);
            }


        }

        static void Print(int num1, int num2)
        {



            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }


        }
        static void PrintChar(char a, char b)
        {


            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
                Console.WriteLine(b);

        }
        static void PrintString(string a, string b)
        {


            int comparison = a.CompareTo(b);
            if (comparison > 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);

            }
        }
    }
    
}
