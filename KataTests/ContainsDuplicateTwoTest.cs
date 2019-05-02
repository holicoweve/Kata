using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class ContainsDuplicateTwoTest
    {
        private ContainsDuplicateTwo _kata;

        [TestInitialize]
        public void init()
        {
            _kata = new ContainsDuplicateTwo();
        }

        [TestMethod]
        public void SimpleTest()
        {
            Assert.AreEqual(true,_kata.ContainsNearbyDuplicate(new []{1,2,3,1},3));
            Assert.AreEqual(true,_kata.ContainsNearbyDuplicate(new []{1,0,1,1},1));
            Assert.AreEqual(false,_kata.ContainsNearbyDuplicate(new []{1,2,3,1,2,3},2));
        }

        [TestMethod]
        public void LargeKTest()
        {
            Assert.AreEqual(true,_kata.ContainsNearbyDuplicate(new []{1,2,3,1},5));
        }

        [TestMethod]
        public void NoDuplicateTest()
        {
            var kata = new ContainsDuplicateTwo();

            Assert.AreEqual(false,_kata.ContainsNearbyDuplicate(new []{1,2,3,4},3));
        }
    }
}
