namespace ItProger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Программирование на C#!");*/

            /*Создайте переменную «num» со значением 20.Добавьте к ней число 5.Добавление 
                выполните за счет сокращенной записи добавления числа к переменной.

           Выведите на экран информацию в следующем формате: «Переменная: var», где var – 
                это ваша переменная num.*/


            /*var num = 20;
            num += 5;
            Console.WriteLine("Переменная: " + num);*/


            //Возведите число «1.4234» в степень 3.Округлите число к большему и выведите его на экран.

            var num = 1.4234;
            Console.WriteLine(Math.Ceiling(Math.Pow(num, 3)));
        }
    }
}