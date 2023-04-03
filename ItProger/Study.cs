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



        public string printCourse()
        {
            return this.course;
        }
    }


    /*Создайте метод «printCourse», что будет возвращать значение поля «course».

    Создайте объект класса «Study» и обратитесь к методу «printCourse» для вывода 
    значения поля «course» в формате: «Value: name», где name - значение переменной.*/
}
