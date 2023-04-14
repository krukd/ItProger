using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItProger
{


    /*Создайте класс Study. Внутри класса создайте поле «course» со значением: 
     * «C# Programming».

    Создайте объект класса «Study» и выведите на экран значение поля «course» в формате: 
    «Value: name», где name – значение переменной.*/
    internal class Study
    {
        private string course;

        /*Допишите в класс «Study» конструктор, что будет принимать один параметр и 
         * будет устанавливать значение этого параметра в поле «course».

        Создайте объект класса «Study». В качестве значения для поля «course» установите 
        текст: «Изучение C# - это просто!». Обратитесь к методу «printCourse» для вывода 
        значения поля «course».*/
        public Study(string course) { 
            this.course = course;
        }



        public Study()
        {
            
        }

        public string printCourse()
        {
            return this.course;
        }

        public int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            //Array.Sort(result);

            int temp = 0;

            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;

                    }
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);

            return result;
        }
    }


    /*Создайте метод «printCourse», что будет возвращать значение поля «course».

    Создайте объект класса «Study» и обратитесь к методу «printCourse» для вывода 
    значения поля «course» в формате: «Value: name», где name - значение переменной.*/
}
