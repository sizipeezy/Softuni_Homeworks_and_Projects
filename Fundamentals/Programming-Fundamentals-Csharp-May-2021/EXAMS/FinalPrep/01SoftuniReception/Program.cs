using System;

namespace _01SoftuniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee01 = int.Parse(Console.ReadLine());
            int employee02 = int.Parse(Console.ReadLine());
            int employee03 = int.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());
            int hour = 0;

            int power = employee01 + employee02 + employee03;
            while (studentsCount > 0)
            {
                hour++;
                studentsCount -= power;



                if (hour % 4 == 0)
                {
                    hour++;
                }

            }

            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
    
}
