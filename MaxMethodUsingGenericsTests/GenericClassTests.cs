using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxMethodUsingGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethodUsingGenerics.Tests
{
    [TestClass()]
    public class GenericClassTests
    {
        [TestMethod()]
        public void GenericClassTest()
        {
            int value = GenericClass<int>.MaxValueGeneric<int>(40, 10, 32);
            Assert.AreEqual(40, value);
        }
        [TestMethod()]
        public void GenericClassTest2()
        {
            double value = GenericClass<double>.MaxValueGeneric<double>(40.9, 10.4, 32.3);
            Assert.AreEqual(40.9, value);
        }
        [TestMethod()]
        public void GenericClassTest3()
        {
            string value = GenericClass<string>.MaxValueGeneric<string>("Animal", "Bananas", "Apple");
            Assert.AreEqual("Bananas", value);
        }
    }
}