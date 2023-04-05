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
            /*Обычная бухгалтерия
            Создайте программу, которая будет рассчитывать сальдо торгового баланса. В 
            случае положительного сальдо (превышение экспорта над импортом) просчитывать 
            прибыль, а в случае отрицательного сальдо (превышение импорта над экспортом) 
            рассчитать потери.



            Например:

            // Переменные: потери - 750 и прибыль - 345
            // Программа выдаст результат:
            "Ваши убытки составили: 405"
            // В случае прибыли будет подсчитана прибыль*/

            Accounting();

        }

        public static void Accounting()
        {
            Console.Write("Каковы ваши убыки в этом месяце? ");
            int loss = int.Parse(Console.ReadLine());
            Console.Write("Какова ваша прибыль в этом месяце? ");
            int profit = int.Parse(Console.ReadLine());


            if(loss > profit)
            {
                loss -= profit;
                Console.Write("Ваши убытки составили: {0}", loss);
            }
            else
            {
                profit -= loss;
                Console.Write("Ваша прибыль составила: {0}", profit);
            }
        }
    }
}

    
