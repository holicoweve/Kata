using System;
using System.Collections.Generic;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class ThreeSumKataTest
    {
        [TestMethod]
        public void SimpleTest()
        {
            // TODO: need to figure out how to test equality of nested arrays
            
            ThreeSumKata kata = new ThreeSumKata();

            var expected = new List<IList<int>> { new List<int> { -1, 0, 1 }, new List<int>() { -1, -1, 2 } };
            var actual = kata.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            //CollectionAssert.AreEquivalent(expected, actual as List<IList<int>>);
        }
    }
}
