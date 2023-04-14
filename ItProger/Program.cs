using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)


        {
            /*var (name, age) = ("Евгения", 27);

            Console.WriteLine("Мое имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            

            

            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor("Офелия", 17);
            }

            Console.WriteLine("Ваши любимые цвета: ");
            for (int i = 0; i < favcolors.Length; i++)
            {

                Console.WriteLine(favcolors[i]);

            }
            */

            /*var array = GetArrayFromConsole(10);

            ShowArray(array, true);*/

            /*var name = "Dmitry";
            Console.WriteLine(name);

            GetName( ref name);

            Console.WriteLine(name);*/

            /*var age = 35;
            Console.WriteLine(age);

            ChangeAge(age);

            Console.WriteLine(age);*/

            var array = new int[] { 1, 5, 3 };


            int temp = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

            }
               /* var array1 = array;
            var array2 = array;

            SortArray(in array, out array1, out array2);*/
            /*BigDataOperation(array);
            Console.WriteLine(array[0]);
*/

        }
        /*static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
            
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

        }*/

        /*static void ShowColors(params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }*/

        /*static int[] GetArrayFromConsole(int num = 5)
        {
            int[] result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }*/

        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);

            foreach (var desc in sorteddesc)
            {
                Console.Write(desc + " ");
            }

            Console.WriteLine();

            foreach (var asc in sortedasc)
            {
                Console.Write(asc + " ");
            }
        }

        static int[] SortArrayAsc(int[] result)
        {
            int temp = 0;

            for (int i = 0; i < result.Length; ++i)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }


        static int[] SortArrayDesc(int[] result)
        {
            int temp = 0;

            for (int i = 0; i < result.Length; ++i)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }



        /*static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;

            if (IsSort)
            {
                temp = SortArray(array);
            }

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }*/

        static void ChangeAge(int age)
        {
            Console.WriteLine("Введите ваш возраст");
            age = int.Parse(Console.ReadLine());
        }

        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }
    }
}

   
