using System;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class DeadAntsTest
    {
        [TestMethod]
        public void BasicTest()
        {
            Assert.AreEqual(2, DeadAnts.DeadAntsCount("ant anantt aantnt"));
            Assert.AreEqual(1, DeadAnts.DeadAntsCount("ant ant .... a nt"));
        }

        [TestMethod]
        public void NullInputTest()
        {
            Assert.AreEqual(0, DeadAnts.DeadAntsCount(null));
        }

        [TestMethod]
        public void AllAliveTest()
        {
            Assert.AreEqual(0, DeadAnts.DeadAntsCount("ant ant ant ant"));
        }
    }
}
