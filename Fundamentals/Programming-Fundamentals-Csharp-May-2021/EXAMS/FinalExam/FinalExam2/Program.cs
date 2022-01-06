using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FinalExam2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string userPattern = @"U\$(?<username>[A-Z][a-z]{2,})U\$";
            string passPatern = @"P@\$((?<password>[a-z]{5,}\d{3,}))P@\$";

            Regex validRegex = new Regex(userPattern);
            Regex validPass = new Regex(passPatern);

            int valides = 0;
            int n = int.Parse(Console.ReadLine());

            List<string> valid = new List<string>();
           
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var matches = validRegex.Match(input);
                var passMatches = validPass.Match(input);
               
                if (matches.Success && passMatches.Success)
                {
                    Console.WriteLine($"Registration was successful");
                    string username = matches.Groups["username"].Value;
                    string password = passMatches.Groups["password"].Value;

                    valid.Add(username);
                    valid.Add(password);

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
