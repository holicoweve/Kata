using Kata.LeetCode.Medium;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class LetterCombinationsTest
	{
		private LetterCombinationsKata _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new LetterCombinationsKata();
		}

		[Test]
		public void InvalidInput()
		{
			var input = "a";
			var expected = new string[] { };
			var actual = _kata.LetterCombinations(input);

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[Test]
		public void EmptyInput()
		{
			var input = string.Empty;
			var expected = new string[] { };
			var actual = _kata.LetterCombinations(input);

			CollectionAssert.AreEquivalent(expected, actual);
		}

		[Test]
		public void TwoDigits()
		{
			var input = "23";
			var expected = new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
			var actual = _kata.LetterCombinations(input);

			CollectionAssert.AreEquivalent(expected, actual);
		}
	}
}