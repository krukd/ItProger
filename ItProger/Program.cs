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

            /*Сравнение строк
            Напишите программу, которая будет сравнивать количество символов в двух 
            произвольных строках, введенных пользователем.



            Пример:

            // Первая строка: Обычная строка
            // Вторая строка: Уже другая строка
            // результат: Обычная строка меньше чем Уже другая строка*/

            StringComparison();
        }

        public static void StringComparison()
        {

            Console.Write("Введите первую строку ");
            string firstString = Console.ReadLine();
            Console.Write("Введите вторую строку ");
            string secondString = Console.ReadLine();

            if(firstString.Length > secondString.Length) {

                Console.WriteLine(firstString + "больше, чем " + secondString);
            }
            else { Console.WriteLine(secondString + " больше, чем " + firstString); }

        }
    }
}

    
