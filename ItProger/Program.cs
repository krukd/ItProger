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
            int previous = 1;
            int current = 1;

            Console.WriteLine("Enter number ");
            int number = int.Parse(Console.ReadLine());

            Console.Write(previous + " " + current);

            for (int i = 0; i < number - 2; i++)
            {
                Console.Write(" ");
                int next = GetNextFibonacci(previous, current);
                Console.Write(next);

                
                previous = current;
                current = next;
            }
        }

        public static int GetNextFibonacci(int previous, int current)
        {
            int fibonacci = previous + current;
            return fibonacci;
        }
    }
}

    
