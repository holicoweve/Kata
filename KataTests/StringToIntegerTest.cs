using Kata.LeetCode.Medium;
using NUnit.Framework;

namespace KataTests
{
	public class StringToIntegerTest
	{
		private StringToIntegerAtoi _kata;

		public StringToIntegerTest()
		{
			_kata = new StringToIntegerAtoi();
		}

		[Test]
		public void PositiveInteger()
		{
			var input = "42";

			var expected = 42;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void NegativeInteger()
		{
			var input = "-42";

			var expected = -42;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void LeadingWhiteSpace()
		{
			var input = "      -42";

			var expected = -42;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void TrailingWords()
		{
			var input = "4193 with words";

			var expected = 4193;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void LeadingWords()
		{
			var input = "words and 987";

			var expected = 0;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void LessThanIntMin()
		{
			var input = "-91283472332";

			var expected = -2147483648;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void LessThanIntMin2()
		{
			var input = "-2147483647";

			var expected = -2147483647;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void VeryLargeNumber()
		{
			var input = "20000000000000000000";

			var expected = 2147483647;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void VeryVeryLargeNumber()
		{
			var input = "1234567890123456789012345678901234567890";

			var expected = 2147483647;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}
	}
}