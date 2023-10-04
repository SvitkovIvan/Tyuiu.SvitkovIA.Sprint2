using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint2.Task2.V7.Lib;

namespace Tyuiu.SvitkovIA.Sprint2.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService dataService = new DataService();
            int x = 7, y = 7;
            bool res = dataService.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait,res);
        }
    }
}
