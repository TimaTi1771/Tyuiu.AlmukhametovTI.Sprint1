using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlmukhametovTI.Sprint1.Task5.V2.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 14;
            double res = ds.FahrenheitToСelsius(temp);
            int result = Convert.ToInt32(res);

            int wait = -10;
            Assert.AreEqual(result, wait);
        }
    }
}
