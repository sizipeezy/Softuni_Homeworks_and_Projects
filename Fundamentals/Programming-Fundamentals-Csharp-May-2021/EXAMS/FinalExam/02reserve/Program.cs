using System;

namespace _02reserve
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Text.RegularExpressions;

namespace FinalExam2
    {
        class Program
        {
            static void Main(string[] args)
            {
                string userPattern = @"U\$([A-Z][a-z]+)U\$";
                string passPatern = @"P@\$([a-z]{5,})(\d{3,})P@\$";

                Regex validRegex = new Regex(userPattern);
                Regex passRegex = new Regex(passPatern);


                int n = int.Parse(Console.ReadLine());

                List<string> validUsernames = new List<string>();
                List<string> validPasswords = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    string input = Console.ReadLine();

                    MatchCollection userMatches = usRegex.Matches(input);
                    foreach (Match item in userMatches)
                    {
                        validUsernames.Add(item.Value);
                    }

                    MatchCollection passMatches = passRegex.Matches(input);

                    foreach (Match pass in passMatches)
                    {
                        validPasswords.Add(pass.Value);
                    }


                }

                (U\$)(?< username >[A - Z][a - z]{ 3,})\1 | (P@\$)(?< password >[A - Za - z]{ 5,}
                [0 - 9]+)\3$; - taen gotv regex
            }
        }
    }

}
    }
}
