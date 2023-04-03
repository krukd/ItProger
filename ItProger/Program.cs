﻿using System;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

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

            /* int[,] x = {
             { 0, 34, 2 },
             { 3, 4, 5 }
         };

             for (int i = 0; i < x.GetLength(0); i++)
             {
                 for (int j = 0; j < x.GetLength(1); j++)
                 {
                     Console.WriteLine("Элемент: " + x[i, j]);

                 }

             }*/


            /*Ниже создан одномерный массив данных. При помощи цикла while найдите минимальный 
             * элемент массива и выведите его на экран в формате: «Минимальный элемент: el», где 
             * el – минимальный элемент.*/

            /*int[] numbers = { 1, 7, 3, -4, 5, 2, 6, 4 };
            int min = numbers[0];
            int i = 1;

            while (i < numbers.Length) {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                i++;
            }
            Console.WriteLine("Минимальный элемент: " + min);*/

            /*Ниже создан одномерный массив данных. При помощи цикла for найдите сумму всех 
             * положительных чисел массива. Выведите сумму на экран в формате: «Сумма: sum», где 
             * sum – сумма элементов.

            * Положительные числа – числа, что больше за 0.*/

            /*int[] numbers = { -1, 7, -3, -4, 5, -2, 6, 4 };

            int sum = 0;

            for(int i  = 0; i < numbers.Length; i++)
            {

                if (numbers[i] > 0) { 
                    
                    sum += numbers[i]; 
                
                
                }
                
            }

            Console.WriteLine("Сумма: " + sum);*/

            /*Создайте переменную и присвойте ей любое числовое значение.

            Пропишите условие через оператор if. Условие должно срабатывать каждый раз, когда 
            переменная 
            не равна значению 5.

            Реализуйте программу, дабы по итогу на экран выводилось сообщение «Верно».*/

            /* int number = 20;
             if (number != 5)
             {
                 Console.Write("Верно");
             }*/

            /*За счет класс DateTime получите текущую дату. Выведите на экран текущую 
             * дату в формате: «MM.DD.YYYY».*/

            /*// Получаем текущую дату
            DateTime aDate = DateTime.Now;
            // Отображаем её в нужном формате
            Console.WriteLine(aDate.ToString("MM.dd.yyyy"));*/


            /*Ниже создан одномерный массив данных. При помощи цикла for выведите 
             * каждый второй элемент массива на экран в формате: «Элемент: el», где 
             * el – значение элемента.

            По итогу должен быть следующий вывод на экран:

            Элемент: 3.4
            Элемент: 1.65
            Элемент: 4.2
            Элемент: 5.2

            Важно: в работе используйте оператор continue.*/
            /*float[] list = { 0.01f, 3.4f, 6.01f, 1.65f, 4.23f, 4.2f, 6f, 5.2f };

            for (int i = 0; i < list.Length; i++)
            {
                if (i == 0 || i % 2 == 0)
                     continue;
                

                Console.WriteLine("Элемент: " + list[i]);
            }*/

            /*Создайте цикл do while внутри которого выведите числа от 1 до 10 с 
             * пропуском чисел, что делятся на 4 без остатка. Вывод в формате: «El: i», 
             * где «i» – это значение элемента.

            Пример вывода информации:

            El: 1
            El: 2
            El: 3
            El: 5
            El: 6
            El: 7
            El: 9
            El: 10*/

            /*// Начинаем с чила 0
            int i = 0;

            do
            {
                // В цикле сразу увеличиваем на +1
                i++;

                // Проверяем делится ли на 4
                if (i % 4 == 0)
                    // Если да, то пропускаем
                    continue;

                // Выводим число на экран
                Console.Write("El: " + i + " ");
                // Условие нужно указать на 1 меньше
                // из-за особенности цикла do while
            } while (i < 10);*/

            /*Создайте функцию «printInfo», что будет принимать один параметр «number». 
             * Из полученного числа (параметра) нужно вычитать число 3 и выводить результат
             * на экран в формате: «Результат: res», где «res» – значение результата.

            Вызовите функцию два раза внутри программы. При первом вызове передайте 
            значение: 23, а при втором вызове: -7.*/
            /*printInfo(23);
            printInfo(-7);
           
        }
        public static void printInfo(int number)
        {
            int res = number - 3;
            Console.WriteLine("Результат: " + res);
        }*/

            /*Создайте функцию «getElementsOfArray», что будет принимать в качестве 
             * параметра массив данных.

            Выполните вызов функции и передачу в неё следующего массива:

            5, 7, 8, 10

            Функция должна вывести на экран массив в формате: «5 / 10». То есть 
            выводиться первый и последний элемент массива.*/

            /*int[] array = { 5, 7, 8, 10 };
            getElementsOfArray(array);

        }

        public static void getElementsOfArray(int[] array) {
            Console.WriteLine(array[0] + " " + "/" + " " + array[array.Length-1]);
        }*/

            /*Создайте функцию «divideAndRound», что будет принимать в качестве 
             * параметров три числа.

            В функции проводите деление чисел.

            Полученное число должно быть округлено к большему и возвращено из функции.

            Выполните вызов функции, передачу в неё чисел «500.05, 2.25, 3.01» и вывод 
            результата на экран в формате: «Результат: res», где res – это результат 
            деления.

            Подсказка: класс Math работает с типом данных double, поэтому переменные 
            лучше создавать с этим типом.*/

            /* Console.WriteLine("Результат: " + divideAndRound(500.05, 2.25, 3.01));
         }

         public static double divideAndRound(double a, double b, double c)
         {
             double resOfDivide = a / b / c;
             double res = Math.Ceiling(resOfDivide);
             return res;

         }*/

            /*Создайте массив «List». Добавьте в него элементы:

            5, 6, 20, 1
            При помощи цикла «for» выведите все элементы на экран в формате: 
            «El: element», где element – значение элемента.*/
            /*List<int> arrayList = new List<int>();

            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(20);
            arrayList.Add(1);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("El: " + arrayList[i]);
            }

            int[] array = new int[4];
            array[0] = 5;
            array[1] = 6;
            array[2] = 20;
            array[3] = 1;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("El: " + arrayList[i]);
            }*/

            /*Ниже есть массив «List». Выполните его сортировку по возрастанию элементов.

            Выведите все элементы на экран через цикл «foreach» в формате: «El: el», где el – 
            значение элемента.*/

            List<int> nums = new List<int>();
            nums.Add(5);
            nums.Add(6);
            nums.Add(20);
            nums.Add(1);

            nums.Sort();

            foreach (var item in nums)
            {
                Console.WriteLine("El: " + item);
            }
        }
    }
}