using System;
using System.Collections.Generic;
using System.Text;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class TwoSumKataTest
    {
        private TwoSumKata _kata;

        [TestInitialize]
        [TestCleanup]
        public void init()
        {
            _kata = new TwoSumKata();
        }

        [TestMethod]
        public void QuickAnswerTest()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1 },
                _kata.TwoSum(new int[] { 2, 7, 11, 15 }, 9));
        }

        [TestMethod]
        public void SimpleTest()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3 },
                _kata.TwoSum(new int[] { 15, 11, 7, 2 }, 9));
        }

        [TestMethod]
        public void RepeatedIntInArrayTest()
        {
            CollectionAssert.AreEqual(new int[] { 0, 2 }, 
                _kata.TwoSum(new int[] { 5, 11, 5, 2 }, 10));
        }
    }
}