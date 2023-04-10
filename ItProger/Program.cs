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

            /*int startSalary = 100;
                        bool moreSalary = true;

                        while (moreSalary)
                        {
                            Console.WriteLine($"I will give you {startSalary} dollars, ok?");

                            string answer = Console.ReadLine();
                            if (answer == "more")
                            {
                                startSalary = startSalary + 100;
                            }
                            if (answer == "ok")
                            {
                                moreSalary = false;
                            }
                        }

                        Console.WriteLine($"Your salary is {startSalary} dollars.");*/
            int startSalary = 100;
            bool flag = true;

            while (flag)
            {

                Console.WriteLine("I will give you {0} dollars, ok?", startSalary);

                string answer = Console.ReadLine();

                if (answer == "more")
                {
                    startSalary = startSalary + 100;
                    //Console.WriteLine();
                }if (answer == "ok")
                {
                    Console.WriteLine("Your salary is {0}", startSalary);
                    flag = false;
                }

            }

            
        }
    }
}

    
