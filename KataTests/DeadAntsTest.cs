using System;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class DeadAntsTest
    {
        private DeadAnts _deadAnts;

        [TestInitialize]
        public void init()
        {
            _deadAnts = new DeadAnts();;
        }
        [TestMethod]
        public void BasicTest()
        {
            Assert.AreEqual(2, _deadAnts.DeadAntsCount("ant anantt aantnt"));
            
        }

        [TestMethod]
        public void OtherCharacterTest()
        {
            Assert.AreEqual(1, _deadAnts.DeadAntsCount("ant ant .... a nt"));
        }
        
        [TestMethod]
        public void NullInputTest()
        {
            Assert.AreEqual(0, _deadAnts.DeadAntsCount(null));
        }

        [TestMethod]
        public void AllAliveTest()
        {
            Assert.AreEqual(0, _deadAnts.DeadAntsCount("ant ant ant ant"));
        }
    }
}
