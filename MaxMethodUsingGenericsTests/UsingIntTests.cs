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
    public class UsingIntTests
    {
        
        [TestMethod()]
        public void MaxValueIntTest()
        {
            UsingInt obj2 = new UsingInt();
            int value = obj2.MaxValueInt(40, 20, 10);
            Assert.AreEqual(40, value);
        }

        [TestMethod()]
        public void MaxValueIntTest2()
        {
            UsingInt obj3 = new UsingInt();
            int value = obj3.MaxValueInt(20, 40, 10);
            Assert.AreEqual(40, value);
        }

        [TestMethod()]
        public void MaxValueIntTest3()
        {
            UsingInt obj4 = new UsingInt();
            int value = obj4.MaxValueInt(10, 20, 40);
            Assert.AreEqual(40, value);
        }
    }
}