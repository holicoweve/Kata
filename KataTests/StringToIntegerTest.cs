using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace KataTests
{
	[TestClass]
	public class StringToIntegerTest
	{
		private StringToInteger_atoi _kata;

		[TestInitialize]
		public void Init()
		{
			_kata = new StringToInteger_atoi();
		}

		[TestMethod]
		public void PositiveInteger()
		{
			var input = "42";

			var expected = 42;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NegativeInteger()
		{
			var input = "-42";

			var expected = -42;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void LeadingWhiteSpace()
		{
			var input = "      -42";

			var expected = -42;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TrailingWords()
		{
			var input = "4193 with words";

			var expected = 4193;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void LeadingWords()
		{
			var input = "words and 987";

			var expected = 0;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void LessThanIntMin()
		{
			var input = "-91283472332";

			var expected = -2147483648;
			var actual = _kata.Atoi(input);

			Assert.AreEqual(expected, actual);
		}
	}
}