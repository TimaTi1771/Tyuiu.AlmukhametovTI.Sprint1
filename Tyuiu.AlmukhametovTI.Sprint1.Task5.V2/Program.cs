using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlmukhametovTI.Sprint1.Task5.V2.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 / Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #1                                                          *");
            Console.WriteLine("* Задание #5                                                         *");
            Console.WriteLine("* Вариант #2                                                         *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                           *");
            Console.WriteLine("* Дано значение температуры в градусах фаренгейта. Опрделить         *");
            Console.WriteLine("* значение этой же температуры в градусах Цельсия                     ");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ    (32) * 5 / 9                                    *");
            Console.WriteLine("**********************************************************************");

            double temp;

            Console.WriteLine("Введите значение в градусах Фаренгейта:");
             temp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine(ds.FahrenheitToСelsius(temp));

            Console.ReadKey();
            
           


        }
    }
}
