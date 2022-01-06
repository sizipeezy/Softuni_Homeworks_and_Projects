using System;
using System.Text.RegularExpressions;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int valides = 0;

            
            Regex validRegex = new Regex(@"(U\$)(?<username>[A-Z][a-z]{2,})\1(P@\$)(?<password>[A-Za-z]{5,}[0-9]+)\3$");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var matches = validRegex.Match(input);

                if(matches.Success)
                {
                    string username = matches.Groups["username"].Value;
                    string password = matches.Groups["password"].Value;

                    Console.WriteLine($"Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");


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
