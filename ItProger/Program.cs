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
            string command1 = "scan";
            string command2 = "hide";
            string command3 = "unhide";
            string command4 = "game over";
            int number = 1;

            bool gameMode = false;


            Console.WriteLine("Enter your command: ");

            while (true)
            {   
                string input = Console.ReadLine();

                if(input == command1 && gameMode == false)
                {

                    Console.WriteLine("scanning file {0}", number);
                    number++;
                }

                if (input == command2 && gameMode == false)
                {
                    gameMode = true;
                }

                if(input == command1 && gameMode == true) { 
                    Console.WriteLine("cant scan files for viruses "); 
                }

                if (input == command3)
                {
                    gameMode = false;
                }

                if (input == command4)
                {
                    Console.WriteLine("run ");
                    break;
                }
                



            }
            


        }
    }
}

    
