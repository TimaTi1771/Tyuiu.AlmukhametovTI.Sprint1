using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlmukhametovTI.Sprint1.Task7.V7.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 / Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #1                                                          *");
            Console.WriteLine("* Задание #7                                                         *");
            Console.WriteLine("* Вариант #7                                                         *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                           *");
            Console.WriteLine("* Написать программу, которая запрашивает данные у пользователя      *");
            Console.WriteLine("* исходные данные, вычисляет результат по формуле и печатает его на  *");
            Console.WriteLine("* экране.                                                            *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ    z = cos x / (п - 2y^x) + 16x cos(x y)-2         *");
            Console.WriteLine("**********************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                         *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
               
        }
    }
}
