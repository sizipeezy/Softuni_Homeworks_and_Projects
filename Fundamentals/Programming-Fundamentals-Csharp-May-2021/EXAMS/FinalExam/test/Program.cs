using System;
using System.Text.RegularExpressions;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[U][$](?<username>[A-Z][a-z]{2,})[U][$].*?[P][@][$](?<password>[A-Za-z]{5,}[A-Za-z0-9]*?\d)[P][@][$]$";

            int n = int.Parse(Console.ReadLine());
            int valides = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["username"].Value;
                    string password = match.Groups["password"].Value;

                    Console.WriteLine($"Registration was successful");
                    Console.WriteLine($"Username: {name}, Password: {password}");
                    valides++;
                }
                else
                {
                    Console.WriteLine($"Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {valides}");
        }
    }
}
