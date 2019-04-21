using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class ContainsDuplicateTwoTest
    {
        [TestMethod]
        public void SimpleTest()
        {
            var kata = new ContainsDuplicateTwo();
            Assert.AreEqual(true,kata.ContainsNearbyDuplicate(new []{1,2,3,1},3));
            Assert.AreEqual(true,kata.ContainsNearbyDuplicate(new []{1,0,1,1},1));
            Assert.AreEqual(false,kata.ContainsNearbyDuplicate(new []{1,2,3,1,2,3},2));
        }
    }
}
