using System;

namespace _08MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            Console.WriteLine(power(N, P));

            static int power(int N, int P)
            {
                if (P == 0)
                    return 1;
                else
                    return N * power(N, P - 1);
            }
        }
    }
}
