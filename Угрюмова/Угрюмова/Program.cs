using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова
{
    internal class Tel
    {
        static double Proverka(DateTime dt, double timeMuch, double money)
        {
            double sum = 0;
            if (dt.DayOfWeek == DayOfWeek.Monday || dt.DayOfWeek == DayOfWeek.Tuesday || dt.DayOfWeek == DayOfWeek.Wednesday || dt.DayOfWeek == DayOfWeek.Thursday || dt.DayOfWeek == DayOfWeek.Friday )
            {
                sum = timeMuch * money;
            }
            if(dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
            {
                sum = timeMuch - timeMuch* money* 0.1;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            double money = 0;
            double timeMuch = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("введите дату разговора. Пример: dd.mm.yy");
                    DateTime dt = DateTime.Parse(Console.ReadLine());
                    while (true)
                    {
                        Console.WriteLine("ввдеите время разговора в минутах");
                        timeMuch = double.Parse(Console.ReadLine());
                        if (timeMuch > 0) break;
                    }
                    while (true)
                    { 
                        Console.WriteLine("введите стоимость разговора в минутах");
                        money = double.Parse(Console.ReadLine());
                        if (money > 0) break;
                    }

                    Console.WriteLine(" стоимость разговора равна " + Proverka(dt, timeMuch, money));
                    break; 
                }
                catch 
                {
                    Console.WriteLine("при написании данных была где-то допущена ошибка");
                }
            }
            Console.ReadKey();
        }
    }
}
