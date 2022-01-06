using System;
using System.Collections.Generic;
using System.Linq;

namespace _09PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int sum = 0;
            while (sequence.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    sum += sequence[0];
                    sequence[0] = sequence[sequence.Count - 1];
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= sequence[0])
                        {
                            sequence[i] += sequence[0];
                        }
                        else
                        {
                            sequence[i] -= sequence[0];
                        }
                    }

                }
                else if (index >= sequence.Count)
                {
                    int remove = sequence[sequence.Count - 1];
                    sum += remove;
                    sequence[sequence.Count - 1] = sequence[0];
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= remove)
                        {
                            sequence[i] += remove;
                        }
                        else
                        {
                            sequence[i] -= remove;
                        }
                    }
                }
                else
                {
                    int remove = sequence[index];
                    sum += remove;
                    sequence.RemoveAt(index);

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= remove)
                        {
                            sequence[i] += remove;
                        }
                        else
                        {
                            sequence[i] -= remove;
                        }
                    }
                }

            }
            Console.WriteLine(sum);
        }
    }
    
}
