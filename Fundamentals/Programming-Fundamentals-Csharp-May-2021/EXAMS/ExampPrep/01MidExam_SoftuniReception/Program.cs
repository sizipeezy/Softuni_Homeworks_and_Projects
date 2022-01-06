using System;

namespace _01MidExam_SoftuniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());
            int hour = 0;

            int sumEmploye = employee1 + employee2 + employee3;
            while (students != 0)
            {
                hour++;
                students -= sumEmploye;
                if(hour % 4 == 0)
                {
                    hour++;
                }

                if(students < 0)
                {
                    break;
                }


            }

            Console.WriteLine($"Time needed: {hour}h. ");
        }
    }
}
