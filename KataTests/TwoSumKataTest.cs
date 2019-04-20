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
        [TestMethod]
        public void SimpleTest()
        {
            TwoSumKata kata = new TwoSumKata();

            CollectionAssert.AreEqual(new int[] {0, 1}, kata.TwoSum(new int[] {2, 7, 11, 15}, 9));
            CollectionAssert.AreEqual(new int[] {2, 3}, kata.TwoSum(new int[] {15, 11, 7, 2}, 9));
        }

        [TestMethod]
        public void RepeatTest()
        {
            TwoSumKata kata = new TwoSumKata();

            CollectionAssert.AreEqual(new int[] {0, 2}, kata.TwoSum(new int[] {5, 11, 5, 2}, 10));
        }
    }
}