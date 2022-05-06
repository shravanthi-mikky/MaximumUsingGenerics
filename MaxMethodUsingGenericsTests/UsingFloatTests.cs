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
    public class UsingFloatTests
    {
        [TestMethod()]
        public void MaxValueFloatTest()
        {
            UsingFloat obj2 = new();
            double value = obj2.MaxValueFloat(4.9, 2.9, 1.9);
            Assert.AreEqual(4.9, value);
        }

        [TestMethod()]
        public void MaxValueFloatTest2()
        {
            UsingFloat obj3 = new();
            double value = obj3.MaxValueFloat(2.9, 4.9, 1.9);
            Assert.AreEqual(4.9, value);
        }

        [TestMethod()]
        public void MaxValueFloatTest3()
        {
            UsingFloat obj4 = new();
            double value = obj4.MaxValueFloat(1.9, 2.9, 4.9);
            Assert.AreEqual(4.9, value);
        }
    }
}