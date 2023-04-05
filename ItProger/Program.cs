using System;
using System.Collections;
using System.Collections.Generic;


namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Небольшой калькулятор
            Создайте программу, которая будет принимать 3 значения от пользователя и 
            далее производить математическое действие (+, -, *, /). 



            Например:
            
             "Первое число: 2"
            "Операция: -"
            "Второе число: 3"
            2 - 3 = -1
            При делении на ноль должна выдаваться ошибка.*/
            Calculator2();

        }

        public static void Calculator2()
        {

            int result = 0;
            Console.Write("Enter first number ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Какую оперцию хотите произвести? ");
            char symbol = char.Parse(Console.ReadLine());

            /*Console.Write("Enter third number ");
            int number3 = int.Parse(Console.ReadLine());*/

            Console.WriteLine("Первое число: " + number1);
            Console.WriteLine("Операция: " + symbol);
            Console.WriteLine("Второе число: " + number2);

            switch (symbol)
            {
                case '-': 
                    Console.Write("Результат равен ");
                    Console.Write( result = number1 - number2);
                    break;
                case '+':
                    Console.Write("Результат равен ");
                    Console.Write(result = number1 + number2);
                    break;
                case '*':
                    Console.Write("Результат равен ");
                    Console.Write(result = number1 * number2);
                    break;
                case '/':

                    try
                    {
                        Console.Write("Результат равен ");
                        Console.WriteLine(result = number1 / number2);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Division by zero");
                    }
                    break;
            }


        }


    }
}

    
