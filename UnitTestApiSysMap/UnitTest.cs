using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api_SysMap.Models;

namespace UnitTestApiSysMap
{
    [TestClass]
    public class UnitTest
    {
        Number number = new Number();
        Numbers numbers = new Numbers();

        [TestMethod]
        public void TestMethodNumber_Sum()
        {      
            Assert.AreEqual(3, number.sum(1, 2));
        }

        [TestMethod]
        public void TestMethodNumber_Divide()
        {
            Assert.AreEqual(0.5, number.divide(1, 2));
        }

        [TestMethod]
        public void TestMethodNumbers_Sum()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Assert.AreEqual(15, numbers.sum(array));
        }

        [TestMethod]
        public void TestMethodNumbers_Avarage()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Assert.AreEqual(3, numbers.avarage(array));
        }
    }
}
