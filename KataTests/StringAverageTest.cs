using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class StringAverageTest
    {
        private StringAverage _kata;

        [TestInitialize]
        public void init()
        {
            _kata = new StringAverage();
        }

        [DataTestMethod]
        [DataRow("one", "one")]
        [DataRow("two", "two")]
        public void SingleInputTest(string input, string expected)
        {
            Assert.AreEqual(expected, _kata.AverageString(input));
        }

        [DataTestMethod]
        [DataRow("zero nine five two", "four")]
        [DataRow("four six two three", "three")]
        [DataRow("one two three four five", "three")]
        public void ComplexTest(string input, string expected)
        {
            Assert.AreEqual(expected, _kata.AverageString(input));
        }

        [DataTestMethod]
        [DataRow("five four", "four")]
        public void RoundDownTest(string input, string expected)
        {
            Assert.AreEqual(expected, _kata.AverageString(input));
        }

        [DataTestMethod]
        [DataRow("one one eight one", "two")]
        public void SomeRepeatedElementTest(string input, string expected)
        {
            Assert.AreEqual(expected, _kata.AverageString(input));
        }

        [DataTestMethod]
        [DataRow("zero zero zero zero zero", "zero")]
        public void AllZeroInputTest(string input, string expected)
        {
            Assert.AreEqual(expected, _kata.AverageString(input));
        }

        [DataTestMethod]
        [DataRow(" ", "n/a")]
        public void EmptyInputTest(string input, string expected)
        {
            Assert.AreEqual(expected, _kata.AverageString(input));
        }
    }

    [TestClass]
    public class ExtensionsTest
    {
        [DataTestMethod]
        [DataRow(0, "zero")]
        [DataRow(1, "one")]
        [DataRow(2, "two")]
        [DataRow(9, "nine")]
        public void IntToStringTest(int input, string expected)
        {
            Assert.AreEqual(expected, input.IntToText());
        }


        [DataTestMethod]
        [DataRow("zero", 0)]
        [DataRow("one", 1)]
        [DataRow("two", 2)]
        [DataRow("nine", 9)]
        public void StringToIntTest(string input, int expected)
        {
            Assert.AreEqual(expected, input.TextToInt());
        }
    }
}
