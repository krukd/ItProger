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

            Console.WriteLine("Введите свое имя ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);
            Console.WriteLine("Ваше имя по буквам: ");
            char [] array = name.ToArray();

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            /*foreach (char c in array)
            {
                Console.Write(c + " ");
                
            }*/
            Console.Write(" Последняя буква вашего имени: " + array[array.Length - 1]);
        }

    }
}

    
