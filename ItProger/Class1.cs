using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItProger
{
    internal class Class1
    {


        public void EnterNameAge () {

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine ();
            Console.WriteLine ("Enter your age ");
            int age = int.Parse (Console.ReadLine());


            Console.WriteLine("Hi {0}, your age is {1}", name, age);
        }
    }
}
