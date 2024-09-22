using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KotievaAm.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KotievaAm.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        
        {
            var name = "Амина";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Амина", res);
        }
    }
}
