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

            /*// Получаем число от пользователя
            int n1 = int.Parse(Console.ReadLine());
            // Вторая переменная содержит число от пользователя, умноженное на два
            int n2 = n1 * 2;
            // Выводим их вместе
            // превращаем в строки, чтобы не добавлялись
            Console.Write(n1.ToString() + n2.ToString());
            
           Создайте переменные для хранения следующий значений:
            -34, 4, 'Hello', 'R', 23.093433222, 30000, true, 0. 



            Продумайте типы данных для переменных, чтобы они максимально подходили под 
            каждое значение.


            // Маленькое число, поэтому byte
            byte num1 = 34;
            byte num2 = 4;
            // Строка
            string word = "Hello";
            // Символ
            char sym = 'R';
            // Много чисел после запятой, поэтому double
            double num33 = 23.093433222f;
            // Чуть больше число, поэтому short
            short number = 30000;
            // Булевое выражение
            bool val = true;
            // Байтовая переменная
            byte simple = 0;

            Попросите пользователя ввести:

            имя
            возраст
            есть ли у него машина (true или false)


            Выведите все значения, после их получения.

            Console.WriteLine("Enter your name: ");

            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");

            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you have a car?");

            string answer = Console.ReadLine();

            bool yesOrNo = false;

            if (answer == "yes")
            {
                yesOrNo = true;
                //Console.WriteLine("You do have a car!");

            } else
            {
                yesOrNo = false;
                //Console.WriteLine("You do not have a car!");
            }

            
            
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is {0}", age);

            if (yesOrNo)
            {
                Console.WriteLine("You do have a car!");
            }
            else
            {
                Console.WriteLine("You do not have a car!");
            }
            


            Получите от пользователя данные и запишите их в переменные с типами данных:

            short
            ulong
            char
            double. 
             
             */

            /*short a;
            ulong b;
            char s;
            double db;
*/
            /*// Для конвертации в short испльзуйте ToInt16 (для int - ToInt32)
            a = Convert.ToInt16(Console.ReadLine());
            // Для конвертации в ulong испльзуйте ToUInt64
            b = Convert.ToUInt64(Console.ReadLine());
            // Для конвертации в char испльзуйте ToChar
            s = Convert.ToChar(Console.ReadLine());
            // Для конвертации в double испльзуйте ToDouble
            db = Convert.ToDouble(Console.ReadLine());*/



            /*Создайте переменную со значением 5.



           *//* Выполните над ней операции:

            умножьте её на 7;
            выполните декременацию(уменьшение на один).*//*

            int a1 = 5;
            // Сокращенная форма умножения
            a1 *= 7;
            // Декременация
            a1--;

            Console.Write("Number is: " + a1);
*/


            EnterNameAge();




        }

        public static void EnterNameAge()
        {

            // Создаем переменные с пустыми значениями
            string name;
            int age;

            Console.WriteLine("Введите ваше имя: ");
            // Получаем целую строку от пользователя
            name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст: ");
            // Получаем строку и конвертируем её в число
            age = int.Parse(Console.ReadLine());

            // Выводим данные на экран
            Console.WriteLine("Привет, " + name + "! Тебе уже " + age);
        }

    }
}

    
