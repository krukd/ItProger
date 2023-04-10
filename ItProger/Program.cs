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
            int startSalary = 100;

            while (true)
            {

                Console.WriteLine("I will give you {0} dollars, ok?", startSalary);

                string answer = Console.ReadLine();

                if (answer == "more")
                {
                    startSalary = startSalary + 100;
                    //Console.WriteLine();
                }else if (answer == "ok")
                {
                    Console.WriteLine("Your salary is {0}", startSalary);
                    break;
                }
            }

            
        }
    }
}

    
