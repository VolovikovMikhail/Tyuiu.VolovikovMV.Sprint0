using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.VolovikovMV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Михаил";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Михаил", res);
        }
    }
}