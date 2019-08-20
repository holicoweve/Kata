using System;
using Kata;
using Xunit;

namespace KataTests
{
	public class ProductOfArrayItemsTest
    {
        private ProductOfArrayItems _kata;

        public ProductOfArrayItemsTest()
        {
            _kata = new ProductOfArrayItems();
        }

        [Fact]
        public void NegativeInputTest()
        {
            Assert.Equal(-672, _kata.Product(new int[] { -2, 6, 7, 8 }));
        }

        [Fact]
        public void ZeroInInputTest()
        {
            Assert.Equal(0, _kata.Product(new int[] { 0, 2, 9, 7 }));
        }

        [Fact]
        public void SingleInputTest()
        {
            Assert.Equal(10, _kata.Product(new int[] { 10 }));
        }

        [Fact]
        public void PositiveInputTest()
        {
            Assert.Equal(540, _kata.Product(new int[] { 5, 4, 1, 3, 9 }));
        }

        [Fact]
        public void TestNullArray()
        {
	        Assert.Throws<ArgumentNullException>(()=>_kata.Product(null));
        }

        [Fact]
        public void TestEmptyArray()
        {
	        Assert.Throws<InvalidOperationException>(()=>_kata.Product(new int[0]));
        }
    }
}
