using System;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class ProductOfArrayItemsTest
    {
        private ProductOfArrayItems _kata;

        [TestInitialize]
        public void init()
        {
            _kata = new ProductOfArrayItems();
        }

        [TestMethod]
        public void NegativeInputTest()
        {
            Assert.AreEqual(-672, _kata.Product(new int[] { -2, 6, 7, 8 }));
        }

        [TestMethod]
        public void ZeroInInputTest()
        {
            Assert.AreEqual(0, _kata.Product(new int[] { 0, 2, 9, 7 }));
        }

        [TestMethod]
        public void SingleInputTest()
        {
            Assert.AreEqual(10, _kata.Product(new int[] { 10 }));
        }

        [TestMethod]
        public void PositiveInputTest()
        {
            Assert.AreEqual(540, _kata.Product(new int[] { 5, 4, 1, 3, 9 }));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullArray()
        {
            _kata.Product(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestEmptyArray()
        {
            _kata.Product(new int[0]);
        }
    }
}
