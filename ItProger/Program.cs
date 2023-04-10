using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)


        {
            /*Create a method named "PrintMax" that takes two int parameters and prints 
             * the larger of the two. Call this method from the Main method with parameters 
             * 75 and 114.*/
            

            Console.WriteLine(WhichGreater(75, 114));

            Console.WriteLine("Enter number ");
            double number = double.Parse(Console.ReadLine());
            PrintCubeVolume(number);

        }

        public static int WhichGreater(int number1,  int number2)
        {

            if (number1 > number2)
            {
                return number1;
            }
            else return number2;      
        }


        public static double PrintCubeVolume(double sideLength)
        {

            double volume = Math.Pow(sideLength, 3);
            Console.WriteLine(Math.Pow(sideLength, 3));

            return volume;
        }
    }
}

    
