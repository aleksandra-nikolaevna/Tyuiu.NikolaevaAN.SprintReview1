using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.SprintReview1.V26.Lib;

namespace Tyuiu.NikolaevaAN.SprintReview1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 0.754;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
