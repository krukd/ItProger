using System;
using System.Collections;
using System.Collections.Generic;

namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте программу, которая будет принимать число (n), введенное 
             * пользователем, и выдавать результат в виде (n + n * 2).



            Пример:

            // Вводим 23
            // Получаем: 2346*/

            // Получаем число от пользователя
            int n1 = int.Parse(Console.ReadLine());
            // Вторая переменная содержит число от пользователя, умноженное на два
            int n2 = n1 * 2;
            // Выводим их вместе
            // превращаем в строки, чтобы не добавлялись
            Console.Write(n1.ToString() + n2.ToString());



        }

    }
}

    
