using System;
using System.Collections;
using System.Collections.Generic;


namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //DepositCalculator();

            //Calcilator();

            EmptyString();




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

        public static void UrlAddress() {


            // Получаем веб сайт от пользователя
            Console.Write("Enter website: ");
            string website = Console.ReadLine();

            // Разделяем слово по символу точка
            string[] split = website.Split('.');
            // Получиться массив состоящий из двух элементов
            // Выводим в консоль последний элемент массива
            Console.Write("Domain name: " + split[split.Length - 1]);
        }

        /*Сумма: 1250
        Годы: 5
        Процент: 12
        1 год - 1400
        2 год - 1568
        3 год - 1756
        4 год - 1966
        После 4 лет сумма будет - 1966*/
        public static void DepositCalculator()
        {
            Console.WriteLine("Введите сумму, которую хотите положить на счет: ");

            double sum = double.Parse(Console.ReadLine());

            Console.WriteLine("На сколько лет хотите положить деньги? ");

            int years = int.Parse(Console.ReadLine());

            int persents = 12;

            
            for (int i = 1; i < years + 1; i++)
            {
                sum += sum /100 * 12;

                Console.WriteLine(i + " year - " + Math.Round(sum));
            }

            Console.WriteLine("После 5 лет ваш баланс будет составлять {0}", Math.Round(sum));
        }


        //Простой калькулятор
        public static void Calcilator()
        {
            Console.WriteLine("Enter first number: ");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            int num2 = int.Parse(Console.ReadLine());

            

            Console.WriteLine("Выберите команду из списка ниже ");
            Console.WriteLine("1. Добавить ");
            Console.WriteLine("2. Отнять ");
            Console.WriteLine("0. Ничего ");


            

            int sum = num1 + num2;

            int substraction = num1 - num2;


            int command = int.Parse(Console.ReadLine());
            /*int command2 = int.Parse(Console.ReadLine());
            int command3 = int.Parse(Console.ReadLine());*/
            

            if(command == 1)
            {
                Console.WriteLine("Результат сложения ваших чисел равен {0}", sum);
            }else if(command == 2)
            {
                Console.WriteLine("Результат вычитания ваших чисел равен {0}", substraction);
            }else { Console.WriteLine("Выберите номер операции, которую хотите произвести с вашими числами"); }

        }

        //Пустая строка
        public static void EmptyString() {
            // Изначально создаем строку с пустым значением
            string user_input = "";
            // Используем специальную функцию IsNullOrWhiteSpace,
            // которая проверяет является ли строка пустой или содержит лишь пробелы.
            // Цикл будет работать до тех пор, пока строка будет пустой
            // или будет состоять из пробелов
            while (String.IsNullOrWhiteSpace(user_input))
            {
                // Получаем строку от пользователя
                Console.Write("Enter something: ");
                user_input = Console.ReadLine();
            }

            // Выводим сообщение после цикла
            Console.WriteLine("Hooray! You done that!");
        }


    }
}

    
