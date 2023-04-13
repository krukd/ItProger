using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)


        {

            /* (string Name, string[] Dishes) User;

             User.Dishes = new string[5];

             Console.WriteLine("Введите имя пользователя");
             User.Name = Console.ReadLine();

             int number = 1;

             for (int i = 0; i < User.Dishes.Length; i++)
             {
                 Console.WriteLine("Введите любимое блюдо номер {0}", number);
                 User.Dishes[i] = Console.ReadLine();
                 number++;

             }
             Console.ReadKey();*/


            /*var (name, age) = ("Евгения", 27);

            Console.WriteLine("Мое имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возрас с цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            ShowColor();*/

            /*string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }

            Console.WriteLine("Ваши любимые цвета: ");
            for (int i = 0;i < favcolors.Length; i++) {

                Console.WriteLine(favcolors[i]);
            
            }*/

            /* int[] array = GetArrayFromConsole();
             Console.WriteLine();

             foreach (int i in array) { 
                 Console.WriteLine(i);

             }*/

            GetArrayFromConsole();


        }
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;

        }


        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            //Array.Sort(result);

            int temp = 0;
            
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    { 
                        temp = result[i];
            result[i] = result[j];
            result[j] = temp;

        }
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);

            return result;
        }
    }
}

    
