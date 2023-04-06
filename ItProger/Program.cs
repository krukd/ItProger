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

            int[] a = { 24, -63, 67, -12, 88, 94, -28, 82, 0, 53 };
            int oneMinValue = a[0];
            int twoMinValue = a[1];

            if (twoMinValue < oneMinValue)
            {
                int tmp = twoMinValue;
                twoMinValue = oneMinValue;
                oneMinValue = tmp;
            }

            for (int i = 2; i < a.Length; i++)
            {
                if (twoMinValue > a[i])
                {
                    twoMinValue = a[i];
                }
                if (twoMinValue < oneMinValue)
                {
                    int tmp = twoMinValue;
                    twoMinValue = oneMinValue;
                    oneMinValue = tmp;
                }

            }

            Console.WriteLine("min1 = {0}; min2 = {1}", oneMinValue, twoMinValue);
        }   

    }
}

    
