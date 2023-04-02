﻿using System;
using System.Globalization;
using System.Reflection;

namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Программирование на C#!");*/

            /*Создайте переменную «num» со значением 20.Добавьте к ней число 5.Добавление 
                выполните за счет сокращенной записи добавления числа к переменной.

           Выведите на экран информацию в следующем формате: «Переменная: var», где var – 
                это ваша переменная num.*/


            /*var num = 20;
            num += 5;
            Console.WriteLine("Переменная: " + num);*/


            //Возведите число «1.4234» в степень 3.Округлите число к большему и выведите его на экран.

            /*var num = 1.4234;
            Console.WriteLine(Math.Ceiling(Math.Pow(num, 3)));*/

            /*Создайте одномерный массив, что будет вмещать в себе следующий набор данных:

            'J', 'a', 'v', 'a', '!'

            Выведите на экран третий элемент массива в формате: «Элемент: el», где el – 
            значение элемента.*/

            /*char[] chars = { 'J', 'a', 'v', 'a', '!' };
            Console.WriteLine("Элемент: " + chars[2]);*/


            /*Создайте цикл for от 1 до 5 включительно. В каждой итерации выводите на экран фразу: 
            «Номер элемента: num», где num – это индекс каждой итерации.*/

            /*for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Номер элемента: " + i);
            }*/

            /*Создайте массив с элементами:

            3.3, 7.4, 0.3, 5.01, 45.2

            Выполните разворот массива, дабы элементы стали в зеркальном порядке:

            45.2, 5.01, 0.3, 7.4, 3.3

            Выведите на экран последний элемент отсортированного массива в формате: «Элемент: el», 
            где el – значение элемента.

            Важно: для сортировки используйте специальный C# метод. Для вывода крайнего элемента 
            при указании индекса используйте метод подсчета всех элементов.

            Подсказка: смотрите нужный метод в классе Array.*/

            /* double[] array = { 3.3, 7.4, 0.3, 5.01, 45.2 };
             Array.Reverse(array);
             //Console.WriteLine(String.Join(',', array));//выводит все элементы перевернутого массива через запятую
             Console.WriteLine("Элемент: " + array[array.Length - 1]);*/


            /*float[] nums = new float[] { 3.3f, 7.4f, 0.3f, 5.01f, 45.2f };
            // Выполняем сортировку
            Array.Reverse(nums);
            // Отображаем последний элемент
            Console.Write("Элемент: " + nums[nums.Length - 1]);*/

            /*Создайте массив с данными:

5, 0, 2, 7, 23, 9, 11
При помощи цикла for выведите каждый элемент по отдельности на экран.

Формат вывода: «Элемент с индексом index: el», где index – индекс текущего элемента, а el – 
            значение элемента.
*/

            /* int[] nums = new int[] { 5, 0, 2, 7, 23, 9, 11 };

             for (int i = 0; i < nums.Length; i++)
             {
                 Console.WriteLine("Элемент с индексом " + i + ": " + nums[i]);
             }*/

            /*У вас есть массив с данными:

            5, 0, 2, 7, 23, 9, 11
            При помощи цикла while выведите каждый элемент по отдельности на экран.

            Формат вывода: «Элемент с индексом index: el», где index – индекс текущего элемента,
            а el – значение элемента.*/

            /*int[] nums = new int[] { 5, 0, 2, 7, 23, 9, 11 };

            var i = 0;

            while (i < nums.Length)
            {
                Console.WriteLine("Элемент с индексом " + i + ": " + nums[i]);
                i++;
            }*/
            /*Ниже создан двумерный массив данных.При помощи циклов for выведите каждый 
             * элемент по отдельности на экран в формате: «Элемент: el», где el – значение элемента.

           Важно: никаких пропусков строк и прочих дополнительных выводов информации не создавайте.*/

            int[,] x = {
            { 0, 34, 2 },
            { 3, 4, 5 }
        };

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.WriteLine("Элемент: " + x[i, j]);

                }

            }
        }
    }
}