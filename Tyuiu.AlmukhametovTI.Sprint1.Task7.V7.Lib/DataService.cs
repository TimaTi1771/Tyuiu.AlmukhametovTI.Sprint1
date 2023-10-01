﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task7.V7.Lib
{
    public class DataService : ISprint1Task7V7
    {
        public double Calculate(double x, double y)
        {
            double term1 = Math.Cos(x) / (Math.PI - 2 * Math.Pow(y, x));
            double term2 = 16 * x * Math.Cos(x * y);
            return Math.Round(term1 + term2 - 2, 3);
        }
    }
}
