using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task3.V3.Lib
{
    public class DataService : ISprint1Task3V3
    {
        public double ParallelepipedVolume(double x, double y, double z)
        {
            return x * y * z;
        }
    }
}
