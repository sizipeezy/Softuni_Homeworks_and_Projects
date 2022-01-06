using System;
using System.Text;

namespace _05DigitsLettersOrOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var digits = new StringBuilder();
            var letters = new StringBuilder();
            var other = new StringBuilder();

            foreach (var item in input)
            {
                if(char.IsDigit(item))
                {
                    digits.Append(item);
                }
                else if(char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else
                {
                    other.Append(item);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);


        }
    }
}
