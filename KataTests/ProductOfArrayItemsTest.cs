using System;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class ProductOfArrayItemsTest
    {
        [DataTestMethod]
        [DataRow(new int[] {1, 2, 3}, 6)]
        [DataRow(new int[] {5, 4, 1, 3, 9}, 540)]
        [DataRow(new int[] {-2, 6, 7, 8}, -672)]
        [DataRow(new int[] {10}, 10)]
        [DataRow(new int[] {0, 2, 9, 7}, 0)]
        public void ProductTest(int[] values, int expected)
        {
            Assert.AreEqual(expected, ProductOfArrayItems.Product(values));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullArray()
        {
            ProductOfArrayItems.Product(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestEmptyArray()
        {
            ProductOfArrayItems.Product(new int[0]);
        }
    }
}
