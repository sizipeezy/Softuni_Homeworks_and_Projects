using System;

namespace ExamTry1
{
    class Program
    {
        static void Main(string[] args)
        {
            int employe1 = int.Parse(Console.ReadLine()); 
            int employe2 = int.Parse(Console.ReadLine()); 
            int employe3 = int.Parse(Console.ReadLine());

            int peopleCount = int.Parse(Console.ReadLine());

            int time = 0;
            int employePower = employe1 + employe2 + employe3;

            while (peopleCount > 0)
            {
                peopleCount -= employePower;
                time++;

              

                if(time % 4 == 0)
                {
                    time++;
                }

               

            }

            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
