using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)


        {

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            Array.Sort(arr);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();


            var arr1 = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }
    }
}

    
