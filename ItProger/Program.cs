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
            (string name, int age) anketa;

            var (name, age) = ("Евгения", 27);

            Console.WriteLine("My name is {0}", name);
            Console.WriteLine("My age is {0}", age);

            Console.WriteLine("Enter your name ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Enter your age ");
            anketa.age = int.Parse(Console.ReadLine());


            Console.WriteLine("Your name is {0}", anketa.name);
            Console.WriteLine("Your age is {0}", anketa.age);


        }
    }
}

    
