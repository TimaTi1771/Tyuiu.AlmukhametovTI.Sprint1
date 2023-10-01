using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlmukhametovTI.Sprint1.Task1.V10.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
