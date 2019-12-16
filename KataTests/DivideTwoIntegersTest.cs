using Kata.LeetCode.Medium;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class DivideTwoIntegersTest
    {
        private DivideTwoIntegers _kata;

        [SetUp]
        public void Setup()
        {
            _kata = new DivideTwoIntegers();
        }

        [Theory]
        [TestCase(10,3,3)]
        [TestCase(2,2,1)]
        public void PositiveAnswer(int dividend, int divisor, int expected)
        {
            var actual = _kata.Divide(dividend, divisor);
            Assert.AreEqual(expected, actual);
        }

        [Theory]
        [TestCase(7,-3,-2)]
        public void NegativeAnswer(int dividend, int divisor, int expected)
        {
            var actual = _kata.Divide(dividend, divisor);
            Assert.AreEqual(expected, actual);
        }
        [Theory]
        [TestCase(0,1,0)]
        public void DividendIsZero(int dividend, int divisor, int expected)
        {
	        var actual = _kata.Divide(dividend, divisor);
	        Assert.AreEqual(expected, actual);
        }

        [Theory]
        [TestCase(-2147483648,-1,2147483647)]
        public void IntOverflow(int dividend, int divisor, int expected)
        {
            var actual = _kata.Divide(dividend, divisor);
            Assert.AreEqual(expected, actual);
        }
    }
}