using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
            
        }
    }
}
