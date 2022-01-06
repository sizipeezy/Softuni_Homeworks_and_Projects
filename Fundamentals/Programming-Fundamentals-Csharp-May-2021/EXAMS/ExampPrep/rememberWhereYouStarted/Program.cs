using System;

namespace rememberWhereYouStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            string name = "Sezen Ibrahim";
            string task = "Preparing for Fundamentals Exam";
            string location = "Dublin, Ireland";
            string formattedText = String.Format(
            "Today is {0:dd.MM.yyyy} and {1} is working on {2} in {3}.",
            date, name, task, location);
            Console.WriteLine(formattedText);
        }
    }
}
