using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class ContainsDuplicateThreeTest
    {
        private ContainsDuplicateThree _kata;

        [TestInitialize]
        public void init()
        {
            _kata = new ContainsDuplicateThree();
        }

        [TestMethod]
        public void ZeroTTest()
        {
            Assert.AreEqual(true, _kata.ContainsNearbyAlmostDuplicate(new int[] { 1, 2, 3, 1 }, 3, 0));
        }

        [TestMethod]
        public void AlmostAllOneTest()
        {
            Assert.AreEqual(true, _kata.ContainsNearbyAlmostDuplicate(new int[] { 1, 0, 1, 1 }, 1, 2));
        }

        [TestMethod]
        public void NoSolutionTest()
        {
            Assert.AreEqual(false, _kata.ContainsNearbyAlmostDuplicate(new int[] { 1, 5, 9, 1, 5, 9 }, 2, 3));
        }

        [TestMethod]
        public void IntMinValueTest()
        {
            Assert.AreEqual(false, _kata.ContainsNearbyAlmostDuplicate(new int[] { -1, 2147483647 }, 1, 2147483647));
        }
    }
}
