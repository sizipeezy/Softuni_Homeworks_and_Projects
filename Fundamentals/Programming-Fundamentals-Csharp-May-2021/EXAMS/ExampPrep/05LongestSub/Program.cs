using System;
using System.Linq;

namespace _05LongestSub
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int[] lis;
            int[] len = new int[array.Length];
            int[] prev = new int[array.Length];
            int maxLength = 0;
            int lastIndex = -1;


            for (int i = 0; i < array.Length; i++)
            {

                len[i] = 1;
                prev[i] = -1;



                for (int j = 0; j < i; j++)
                {

                    if (array[j] < array[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }
            lis = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = array[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
    
}
