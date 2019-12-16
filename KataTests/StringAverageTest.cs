using Kata.CodeWars;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class StringAverageTest
	{
		private StringAverage _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new StringAverage();
		}

		[Theory]
		[TestCase("one", "one")]
		[TestCase("two", "two")]
		public void SingleInputTest(string input, string expected)
		{
			Assert.AreEqual(expected, _kata.AverageString(input));
		}

		[Theory]
		[TestCase("zero nine five two", "four")]
		[TestCase("four six two three", "three")]
		[TestCase("one two three four five", "three")]
		public void ComplexTest(string input, string expected)
		{
			Assert.AreEqual(expected, _kata.AverageString(input));
		}

		[Theory]
		[TestCase("five four", "four")]
		public void RoundDownTest(string input, string expected)
		{
			Assert.AreEqual(expected, _kata.AverageString(input));
		}

		[Theory]
		[TestCase("one one eight one", "two")]
		public void SomeRepeatedElementTest(string input, string expected)
		{
			Assert.AreEqual(expected, _kata.AverageString(input));
		}

		[Theory]
		[TestCase("zero zero zero zero zero", "zero")]
		public void AllZeroInputTest(string input, string expected)
		{
			Assert.AreEqual(expected, _kata.AverageString(input));
		}

		[Theory]
		[TestCase(" ", "n/a")]
		public void EmptyInputTest(string input, string expected)
		{
			Assert.AreEqual(expected, _kata.AverageString(input));
		}
	}

	[TestFixture]
	public class ExtensionsTest
	{
		[Theory]
		[TestCase(0, "zero")]
		[TestCase(1, "one")]
		[TestCase(2, "two")]
		[TestCase(9, "nine")]
		public void IntToStringTest(int input, string expected)
		{
			Assert.AreEqual(expected, input.IntToText());
		}

		[Theory]
		[TestCase("zero", 0)]
		[TestCase("one", 1)]
		[TestCase("two", 2)]
		[TestCase("nine", 9)]
		public void StringToIntTest(string input, int expected)
		{
			Assert.AreEqual(expected, input.TextToInt());
		}
	}
}