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
        [TestMethod]
        public void SimpleTest()
        {
            Assert.AreEqual(0, CountNumberOfDuplicate.DuplicateCount(""));
            Assert.AreEqual(0, CountNumberOfDuplicate.DuplicateCount("abcde"));
            Assert.AreEqual(2, CountNumberOfDuplicate.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, CountNumberOfDuplicate.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, CountNumberOfDuplicate.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, CountNumberOfDuplicate.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }

    }
}
