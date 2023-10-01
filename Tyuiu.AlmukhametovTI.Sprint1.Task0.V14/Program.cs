using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlmukhametovTI.Sprint1.Task0.V14.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                           *");
            Console.WriteLine("* Тема: Создание решения по таску0                                                    *");
            Console.WriteLine("* Задание: #2                                                                         *");
            Console.WriteLine("* Вариант #14                                                                         *");
            Console.WriteLine("* Выполнил: Альмухаметов Тимур Ильясович | ИИПб-23-3                                  *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет   *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                                   *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   2 * 3 * 3 + 7                                                    *");
            Console.WriteLine("***************************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();






































        }
    }
}
