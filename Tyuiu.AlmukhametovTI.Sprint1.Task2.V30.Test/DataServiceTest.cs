using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlmukhametovTI.Sprint1.Task2.V30.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double X = 1.5;
            var res = ds.ConvertKmToMetre(X);
            Assert.AreEqual(1500, res);
        }
    }
}
