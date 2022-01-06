using System;

namespace array11
{
    class Program
    {
        static void Main(string[] args)
        {
            int size1, size2, mergeSize;
            int index1;
            int index2;
            int mergeIndex;
            int i;


            /* Input array size */
            Console.Write("Enter size of array 1: ");
            size1 = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[size1];


            /* Input elements in array */
            Console.WriteLine("Enter {0} elements in the array 1", size1);
            for (i = 0; i < size1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            /* Input array size */
            Console.Write("Enter size of array 2: ");
            size2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[size2];

            /* Input elements in array */
            Console.WriteLine("Enter {0} elements in the array 2", size2);
            for (i = 0; i < size2; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            mergeSize = size1 + size2;
            int[] mergeArray = new int[mergeSize];
            index1 = 0;
            index2 = 0;
            for (mergeIndex = 0; mergeIndex < mergeSize; mergeIndex++)
            {
                /* 
                 * If all elements of one array 
                 * is merged to final array
                 */
                if (index1 >= size1 || index2 >= size2)
                {
                    break;
                }


                if (arr1[index1] < arr2[index2])
                {
                    mergeArray[mergeIndex] = arr1[index1];
                    index1++;
                }
                else
                {
                    mergeArray[mergeIndex] = arr2[index2];
                    index2++;
                }
            }

            /*Merge remaining array elements*/
            while (index1 < size1)
            {
                mergeArray[mergeIndex] = arr1[index1];
                mergeIndex++;
                index1++;
            }
            while (index2 < size2)
            {
                mergeArray[mergeIndex] = arr2[index2];
                mergeIndex++;
                index2++;
            }


            /* 
             * Print merged array
             */
            Console.Write("\nArray merged in ascending order : ");
            for (i = 0; i < mergeSize; i++)
            {
                Console.Write("{0}\t", mergeArray[i]);
            }
            Console.ReadLine();
        }
    }
}
