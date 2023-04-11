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
            Console.WriteLine("Enter your word: ");



            //char [] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            string word = Console.ReadLine();

            while (word != "exit")
            {
                char letter = word[0];
                char letterToLowerCase = char.ToLower(letter);

                if(letterToLowerCase >= 'a' && letterToLowerCase <= 'f' ) {
                    FromAToF(word);
                }else if(letterToLowerCase >= 'g' && letterToLowerCase <= 'l')
                {
                    FromGToL(word);
                }
                else if (letterToLowerCase >= 'm' && letterToLowerCase <= 'r')
                {
                    FromMToR(word);
                }
                else
                {
                    FromSToZ(word);
                }

                word = Console.ReadLine();
            }


        }

        public static void FromAToF(string word)
        {
            Console.WriteLine("FromAToF executes {0}", word);
        }

        public static void FromGToL(string word)
        {
            Console.WriteLine("FromGToL executes {0}", word);
        }

        public static void FromMToR(string word)
        {
            Console.WriteLine("FromMToR executes {0}", word);
        }

        public static void FromSToZ(string word)
        {
            Console.WriteLine("FromSToZ executes {0}", word);
        }


    }
}

    
