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
            /*Создайте двумерный массив и выведите его на экран при помощи циклов while.



            Двумерный массив данных:

                        int[,] x = { { 0, 34, 2 }, { 9, 12, 18 }, { 3, 4, 5 } };
            */


            int length = 3;

            int[,] x = { { 0, 34, 2 }, { 9, 12, 18 }, { 3, 4, 5 } };

            int i = 0;

            while (i < length)
            {
                int j = 0;

                while (j < length)
                {
                    Console.Write(x[i, j] + " ");
                    j++;
                }

                i++;
            }



        }   

    }
}

    
