using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counts;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] myArray = { 1, 9, 5, 5, 7, 9, 5, 1, 5, 9, 7, 7, 5, 9, 1 };
            int result = CountsInArray.Count(1, myArray);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] myArray = { 1, 9, 5, 5, 7, 9, 5, 1, 5, 9, 7, 7, 5, 9, 1 };
            int result = CountsInArray.Count(9, myArray);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] myArray = { 1, 9, 5, 5, 7, 9, 5, 1, 5, 9, 7, 7, 5, 9, 1 };
            int result = CountsInArray.Count(5, myArray);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] myArray = { 1, 9, 5, 5, 7, 9, 5, 1, 5, 9, 7, 7, 5, 9, 1 };
            int result = CountsInArray.Count(7, myArray);
            Assert.AreEqual(3, result);
        }
    }
}
