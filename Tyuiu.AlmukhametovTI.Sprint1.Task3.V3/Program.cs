using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlmukhametovTI.Sprint1.Task3.V3.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                            *");
            Console.WriteLine("***************************************************************");

            double x = 9;
            double y = 7.5;
            double z = 5;
            Console.WriteLine("Длина параллелепипеда = " + x);
            Console.WriteLine("Ширина параллелепипеда = " + y);
            Console.WriteLine("Высота параллелепипеда = " + z);

            Console.WriteLine("***************************************************************");
            Console.WriteLine("* Результат:                                                  *");
            Console.WriteLine("***************************************************************");

            Console.WriteLine("Объём параллелепипеда = " + ds.ParallelepipedVolume(x, y, z));

            Console.ReadKey();
        }
    }
}
