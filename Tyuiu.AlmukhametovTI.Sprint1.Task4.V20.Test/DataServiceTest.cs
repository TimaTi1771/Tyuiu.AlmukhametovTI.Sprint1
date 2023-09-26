using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlmukhametovTI.Sprint1.Task4.V20.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 4;
            var res = ds.Calculate(x, y);
            
          
            
            
            


        }
    }
}
