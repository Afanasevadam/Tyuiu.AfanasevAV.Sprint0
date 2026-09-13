using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AfanasevAV.Sprint0.Task3.V1.Lib;

namespace Tyuiu.AfanasevAV.Sprint0.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}