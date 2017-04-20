using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab16
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool Expected = false;
            Assert.AreEqual(Expected, PrimeMethod.isPrime(1));
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool Expected = true;
            Assert.AreEqual(Expected, PrimeMethod.isPrime(2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            bool Expected = true;
            Assert.AreEqual(Expected, PrimeMethod.isPrime(3));
        }
    }

}
