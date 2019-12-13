using Kata;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class LongestSubstringWithoutRepeatTest
	{
		private LongestSubstringWithoutRepeat _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new LongestSubstringWithoutRepeat();
		}

		[Test]
		public void SameChars()
		{
			var input = "bbbbb";
			var expected = 1;
			var actual = _kata.Length(input);


			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void AnswerInBeginning()
		{
			var input = "abcabcbb";
			var expected = 3;
			var actual = _kata.Length(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void AnswerInMiddle()
		{
			var input = "pwwkew";
			var expected = 3;
			var actual = _kata.Length(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void OneSpace()
		{
			var input = " ";
			var expected = 1;
			var actual = _kata.Length(input);


			Assert.AreEqual(expected, actual);
		}
		
		[Test]
		public void OneChar()
		{
			var input = "a";
			var expected = 1;
			var actual = _kata.Length(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void FullLength()
		{
			var input = "abc";
			var expected = 3;
			var actual = _kata.Length(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void AnswerAtEnd()
		{
			var input = "abcabcdefghi";
			var expected = 9;
			var actual = _kata.Length(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void RepeatAtEnd()
		{
			var input = "abcda";
			var expected = 4;
			var actual = _kata.Length(input);

			Assert.AreEqual(expected, actual);
		}
	}
}
