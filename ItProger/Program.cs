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

            /*Определение дня недели
            Введите число от 1 до 7, которое будет соответствовать дню недели.



            Например: при вводе числа 1 на экране будет выводиться «Monday» и т. д.



            Сделайте подобную проверку при помощи операторов switch case.*/

            DayOfWeek();
        }

        public static void DayOfWeek()
        {

            Console.Write("Enter number from 1 to 7 ");

            int number = int.Parse(Console.ReadLine());


            switch (number)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;

            }
        }
    }
}

    
