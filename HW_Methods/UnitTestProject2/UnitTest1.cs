using System;
using SayHello;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod5()
        {
            string str = "Ivan";
            string greeting = "Hello " + str + "!";
            string result = Greetings.SayHello(str);
            Assert.AreEqual(greeting, result);

        }
        [TestMethod]
        public void TestMethod6()
        {
            string str = "Petar";
            string greeting = "Hello " + str + "!";
            string result = Greetings.SayHello(str);
            Assert.AreEqual(greeting, result);

        }

        [TestMethod]
        public void TestMethod7()
        {
            string str = "Gosho";
            string greeting = "Hello " + str + "!";
            string result = Greetings.SayHello(str);
            Assert.AreEqual(greeting, result);

        }
    }
}
