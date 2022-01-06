using System;

namespace _04PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isTrue =
            doesCharacters(input) &&
            doesHaveDigits(input) &&
            doesConsistsOnlyLetersandDigits(input);
            if (isTrue)
            {
                Console.WriteLine($"Password is valid");

            }
            else
            {
                if (!doesCharacters(input))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!doesConsistsOnlyLetersandDigits(input))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!doesHaveDigits(input))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        private static bool doesConsistsOnlyLetersandDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool doesHaveDigits(string input)
        {
            int count = 0;
            foreach (char dig in input)
            {
                if (char.IsDigit(dig))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }

            return false;
        }

        private static bool doesCharacters(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                bool isTrue = true;
                return isTrue;
            }

            return false;

        }
    }
}

