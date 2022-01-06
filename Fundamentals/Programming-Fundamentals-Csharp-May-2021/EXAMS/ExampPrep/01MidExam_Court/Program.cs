using System;

namespace _01MidExam_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());

            int people = int.Parse(Console.ReadLine());
            int total = employee1 + employee2 + employee3;

            int hour = 0;
            while (people != 0)
            {
                people -= total;
                hour++;
              
                if(hour % 4 == 0)
                {
                    hour++;
                
                }
                if(people <= 0)
                {
                    break;
                }

            }
            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
