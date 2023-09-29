using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlmukhametovTI.Sprint1.Task6.V16.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string text = "1 ! 2 3 ?";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(text);
            
        }
    }
}
