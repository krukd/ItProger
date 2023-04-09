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
            //Задайте одномерный массив и напишите алгоритм, который находит в нем
            //количество положительных чисел.
            var arr = new int[] { 5, 6, -9, 1, 2, 3, -4 };

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);


            int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            /*int temp = 0;
            foreach (var item in array) if (item > 0)
                    temp++;
            Console.WriteLine(temp);*/

            int temp = 0;

            for (int i = 0; i <= array.GetUpperBound(0); i++) {
            

                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        temp++;
                    }
                }
            }

            Console.WriteLine(temp);

        }
    }
}

    
