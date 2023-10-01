using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlmukhametovTI.Sprint1.Task1.V10.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                           *");
            Console.WriteLine("* Тема: Создание решения по таску1                                                    *");
            Console.WriteLine("* Задание: #1                                                                         *");
            Console.WriteLine("* Вариант #10                                                                         *");
            Console.WriteLine("* Выполнил: Альмухаметов Тимур Ильясович | ИИПб-23-3                                  *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет   *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                                   *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   (x + y) / (1 + x);                                               *");
            Console.WriteLine("***************************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ                                                                          *");
            Console.WriteLine("***************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
