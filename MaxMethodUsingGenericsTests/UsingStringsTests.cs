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
    public class UsingStringsTests
    {
        
        [TestMethod()]
        public void MaxValueStringTest()
        {
            UsingStrings obj2 = new UsingStrings();
            string value = obj2.MaxValueStrings("Apple", "Peach", "Banana");
            Assert.AreEqual("Banana", value);
        }
        
        [TestMethod()]
        public void MaxValueStringTest2()
        {
            UsingStrings obj3 = new UsingStrings();
            string value = obj3.MaxValueStrings("Banana", "Apple", "Peach");
            Assert.AreEqual("Banana", value);
        }
       
        [TestMethod()]
        public void MaxValueStringTest3()
        {
            UsingStrings obj4 = new UsingStrings();
            string value = obj4.MaxValueStrings("Peach", "Banana", "Apple");
            Assert.AreEqual("Banana", value);
        }
       
    }
}