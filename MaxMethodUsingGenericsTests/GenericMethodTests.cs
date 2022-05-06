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
    public class GenericMethodTests
    {
        [TestMethod()]
        public void MaxValueGenericsTest()
        {
            int value = GenericMethod.MaxValueGenerics<int>(40,10,32);
            Assert.AreEqual(40, value);
        }
        [TestMethod()]
        public void MaxValueGenericsTest1()
        {
            double value = GenericMethod.MaxValueGenerics<double>(4.9, 1.8, 3.2);
            Assert.AreEqual(4.9, value);
        }
        [TestMethod()]
        public void MaxValueGenericsTest3()
        {
            string value = GenericMethod.MaxValueGenerics<string>("Animal", "Bananas", "Apple");
            Assert.AreEqual("Bananas", value);
        }

    }
}