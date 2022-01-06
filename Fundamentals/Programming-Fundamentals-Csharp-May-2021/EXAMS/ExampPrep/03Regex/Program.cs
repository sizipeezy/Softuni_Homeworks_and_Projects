using System;
using System.Text.RegularExpressions;

namespace _03Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string dates = Console.ReadLine();
           string pattern = (@"\b(?<month>[A-Z][a-z]{2})([-.\/])(?<day>\d{2})\1(?<year>\d{4})_([a-z]+)_(?<someOtherGroup>[0-9]+)_([0-9]+)+\b");

            var matches = Regex.Matches(dates, pattern);

            foreach (Match item in matches)
            {
                var separator = item.Groups[1].Value;
                var secondMonth = item.Groups[2].Value; // = ([a-z]+)// result: jan
                var secondYear = item.Groups[3].Value; // = ([-.\/])// result: 2019
                var month = item.Groups[4].Value; // = item.Groups["month"].Value;// result: Apr
                var day = item.Groups[5].Value; // = item.Groups["day"].Value; // result: 16              
                var year = item.Groups[6].Value; // = item.Groups["year"].Value; // result: 2017
                var someOtherGroup = item.Groups[7].Value; // = item.Groups["someOtherGroup"].Value; // result: 07

                Console.WriteLine(separator);
                Console.WriteLine(secondMonth);
                Console.WriteLine(secondYear);
                Console.WriteLine(month);
                Console.WriteLine(day);
                Console.WriteLine(year);
                Console.WriteLine(someOtherGroup);

            }
        }
    }
}
