using System;
using NUnit.Framework;

namespace dotnet_demo.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            string test = "test";
            Assert.AreEqual(test, "test");
        }
    }
}
