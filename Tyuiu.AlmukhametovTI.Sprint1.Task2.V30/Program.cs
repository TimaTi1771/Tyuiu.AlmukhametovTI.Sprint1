using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlmukhametovTI.Sprint1.Task2.V30.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                           *");
            Console.WriteLine("* Тема: Создание решения по таску2                                                    *");
            Console.WriteLine("* Задание: #2                                                                         *");
            Console.WriteLine("* Вариант #30                                                                         *");
            Console.WriteLine("* Выполнил: Альмухаметов Тимур Ильясович | ИИПб-23-3                                  *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет   *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                                   *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   0.001*1000                                                       *");
            Console.WriteLine("***************************************************************************************");

            double x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());    

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Результат:                                                                          *");
            Console.WriteLine("***************************************************************************************");

            Console.WriteLine("* Расстояние в метрах = " + ds.ConvertKmToMetre(x));                                     
            Console.ReadLine();

        }
    }
}
