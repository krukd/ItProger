using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)

            
        {

            Console.WriteLine(BreakCamelCase("camelCasing"));
        }

        public static string BreakCamelCase(string str)
        {
            // complete the function
            string c = "";

            for (int i = 0; i < str.Length; i++)
            {
                string a = char.ToString(str[i]);     
                if (a.Equals(a.ToUpper()))
                {
                    c+= " ";
                }
                    c+= a;
            }

            return c;
        }
    }
}

    
