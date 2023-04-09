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

            string name = "Dima";

            char [] array = name.ToArray();
            var reverseArray = array.Reverse();
            foreach ( var i in reverseArray )
            {
                Console.Write(i);
            }
        }

    }
}

    
