using System;
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



            /*Создайте массив «List». Добавьте в него элементы:

            4, 7, 2, 8, 0, 3, 9
            Найдите среднее арифметическое значение. Выведите на экран лишь те числа, 
            что больше за среднее арифметическое.

            Выводите в формате: «El: element», где element – значение элемента.*/

            List<int> list = new List<int>();

            list.Add(4);
            list.Add(7);
            list.Add(2);
            list.Add(8);
            list.Add(0);
            list.Add(3);
            list.Add(9);

            /*double average = list.Average();

            foreach (int i in list)
            {
                if (i > average)
                {
                    Console.WriteLine("El: " + i);
                }
            }*/

            // Переменная для подсчета суммы
            /*int summa = 0;
            foreach (int el in list)
                summa += el;

            // Переменная для подсчёта среднего значения
            float average = summa / list.Count;

            foreach (int el in list)
                if (el > average)
                    Console.Write("El: " + el);*/

            /*Создайте функцию «deleteElements», что будет принимать в качестве 
             * параметра массив данных «numbers».

            Функция должна удалять элементы под порядковым номером 5 и 1 и далее 
            выводить весь новый массив на экран.

            Выполните вызов функции и передачу в неё следующего массива «numbers».

            Функция должна выводить элементы в формате: «El: element», где element – 
            значение элемента.

            Подсказка: для удаления используйте метод «RemoveAt».*/

            List<int> numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(7);
            numbers.Add(2);
            numbers.Add(8);
            numbers.Add(0);
            numbers.Add(3);
            numbers.Add(9);

            deleteElements(numbers);


        }

        /*public static void deleteElements(List<int> numbers)
        {
            numbers.RemoveAt(5);
            numbers.RemoveAt(1);


            foreach (int i in numbers)
            {
                Console.WriteLine("El: " + i);
            }*/

        public static void deleteElements(List<int> numbers)
        {
            // Нужно удалять по индексу, поэтому
            // удаляем 4 и 0 элемент по индексу
            // Важный момент:
            // После удаления индексы смещаются.
            // По этой причине лучше сперва удалить 
            // 5 элемент, а потом 1
            numbers.RemoveAt(4);
            numbers.RemoveAt(0);

            foreach (int el in numbers)
                Console.WriteLine("El: " + el);
        }

    }
    }
