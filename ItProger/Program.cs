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
            /*Проверка переменных
            Проверить две переменные на их четность. Если обе четные, то выдается 
            значение true, иначе false.



            Важно: проверку необходимо выполнить при помощи сокращенной формы if else.
            */

            int a = 10; int b = 19;
            
            Console.WriteLine(IsEvenOrOdd(a, b));

        }


        public static bool IsEvenOrOdd(int a, int b)
        {
            if(a % 2 == 0 && b % 2 == 0) return true;
            return false;
        }

        
    }
}

    
