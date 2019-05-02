using System;
using System.Collections.Generic;
using System.Text;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class CountNumberOfDuplicateTest
    {
        private CountNumberOfDuplicate _kata;

        [TestInitialize]
        public void init()
        {
            _kata = new CountNumberOfDuplicate();;
        }

        [TestMethod]
        public void EmptyStringTest()
        {
            Assert.AreEqual(0, _kata.DuplicateCount(""));
        }

        [TestMethod]
        public void NoDuplicateTest()
        {
            Assert.AreEqual(0, _kata.DuplicateCount("abcde"));
        }

        [TestMethod]
        public void CapitalTest()
        {
            Assert.AreEqual(2, _kata.DuplicateCount("aabBcde"), "should ignore case");
        }

        [TestMethod]
        public void SimpleTest()
        {
            Assert.AreEqual(2, _kata.DuplicateCount("aabbcde"));
            Assert.AreEqual(1, _kata.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, _kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }

    }
}
