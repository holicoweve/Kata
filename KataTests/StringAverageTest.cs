using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class StringAverageTest
    {
        [DataTestMethod]
        [DataRow("one", "one")]
        [DataRow("two", "two")]
        public void SimpleTest(string input, string expected)
        {
            Assert.AreEqual(expected, StringAverage.AverageString(input));
        }

        [DataTestMethod]
        [DataRow("zero nine five two", "four")]
        [DataRow("four six two three", "three")]
        [DataRow("one two three four five", "three")]
        [DataRow("five four", "four")]
        [DataRow("zero zero zero zero zero", "zero")]
        [DataRow("one one eight one", "two")]
        [DataRow(" ", "n/a")]
        public void ComplexTest(string input, string expected)
        {
            Assert.AreEqual(expected, StringAverage.AverageString(input));
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
