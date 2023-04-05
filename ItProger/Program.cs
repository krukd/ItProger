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

            /*Создание и вывод массива
            Напишите программу для определения массива A из 10 целых элементов. 
            Попросите пользователя заполнить массив цифрами. 



            В конце программы выведите массив на экран в одну строку.*/

            Array();
        }

        public static void Array()
        {
            int[] array = new int[10];


            Console.WriteLine("To fill the array with numbers enter any number and press Enter and repeat 10 times ");
            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Полученный массив выглядит следующим образом ");

            foreach (var item in array)
            {
                
                Console.Write(item + " ");


            }
        }

    }
}

    
