using System;

namespace _01ArrayMoreEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            string[] arr = new string[n];
            int[] value = new int[n];
            for (int i = 0; i < n; i++)
            {

                int sumVowles = 0;
                int sumDelete = 0;
                arr[i] = Console.ReadLine();
                foreach (char item in arr[i])
                {
                    if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u'
                       || item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
                    {
                        sumVowles += ((int)item * arr[i].Length);
                    }
                    else
                    {
                        sumDelete += ((int)item / arr[i].Length);
                    }

                }

                int stringSum = sumDelete + sumVowles;

                value[i] = stringSum;
            }
            Array.Sort(value);

            foreach (int val in value)
            {
                Console.WriteLine(val);
            }
        }
    }
}
