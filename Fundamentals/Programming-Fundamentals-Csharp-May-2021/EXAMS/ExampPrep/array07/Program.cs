using System;
using System.Linq;

namespace array07
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, size, num, pos;


            /* Input array size */
            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int[] arr2;


            /* Input elements in array */
            Console.WriteLine("Enter {0} elements in the array", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            /* Input new element and position to insert */
            Console.Write("Enter element to insert : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the element position  1 to {0}:", size);
            pos = Convert.ToInt32(Console.ReadLine());

            /* If position of element is not valid */
            if (pos > size + 1 || pos <= 0)
            {
                Console.Write("Invalid position! Please enter position between 1 to {0}", size);
            }
            else
            {
                arr2 = new int[size + 1];
                /* Make room for new array element by shifting to right */
                for (i = size; i >= pos; i--)
                {
                    arr2[i] = arr[i - 1];
                }

                /* Insert new element at given position and increment size */
                arr2[pos - 1] = num;
                size++;

                /*Fill the elements before 'pos' index. */
                for (i = 0; i < pos - 1; i++)
                {
                    arr2[i] = arr[i];
                }

                /* Print array after insert operation */
                Console.Write("Array elements after insertion : ");
                for (i = 0; i < size; i++)
                {
                    Console.Write("{0}\t", arr2[i]);
                }
            }

        }
    }
}

