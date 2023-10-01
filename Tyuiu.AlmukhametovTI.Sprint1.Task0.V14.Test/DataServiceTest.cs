using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlmukhametovTI.Sprint1.Task0.V14.Lib;


namespace Tyuiu.AlmukhametovTI.Sprint1.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int a = 2;
            int b = 3;
            int c = 7;
             var res = ds.Calculate();

            Assert.AreEqual (25, res);
        }
    }
}
