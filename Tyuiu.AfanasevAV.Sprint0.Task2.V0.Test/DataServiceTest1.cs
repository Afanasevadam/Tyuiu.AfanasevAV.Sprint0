using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AfanasevAV.Sprint0.Task2.V1.Lib;

namespace Tyuiu.AfanasevAV.Sprint0.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Адам";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Адам", res);
        }
    }
}