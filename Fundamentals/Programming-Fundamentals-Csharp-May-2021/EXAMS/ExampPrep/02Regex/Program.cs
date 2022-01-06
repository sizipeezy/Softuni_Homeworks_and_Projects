using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneString = Console.ReadLine();
            Regex validPhonesPatter = new Regex(@"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b");

            MatchCollection phoneCollection = validPhonesPatter.Matches(phoneString);
            List<string> phoneList = new List<string>();

            foreach (var phone in phoneCollection)
            {
                phoneList.Add(phone.ToString());
            }

            Console.WriteLine(string.Join(", ", phoneList));
        }
    }
}
