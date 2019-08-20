using Kata;
using Xunit;

namespace KataTests
{

	public class LongestSubstringWithoutRepeatTest
	{
		private LongestSubstringWithoutRepeat _kata;

		public LongestSubstringWithoutRepeatTest()
		{
			_kata = new LongestSubstringWithoutRepeat();
		}

		[Fact]
		public void SameChars()
		{
			var input = "bbbbb";
			var expected = 1;
			var actual = _kata.Length(input);


			Assert.Equal(expected, actual);
		}

		[Fact]
		public void AnswerInBeginning()
		{
			var input = "abcabcbb";
			var expected = 3;
			var actual = _kata.Length(input);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void AnswerInMiddle()
		{
			var input = "pwwkew";
			var expected = 3;
			var actual = _kata.Length(input);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void OneSpace()
		{
			var input = " ";
			var expected = 1;
			var actual = _kata.Length(input);


			Assert.Equal(expected, actual);
		}
		
		[Fact]
		public void OneChar()
		{
			var input = "a";
			var expected = 1;
			var actual = _kata.Length(input);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void FullLength()
		{
			var input = "abc";
			var expected = 3;
			var actual = _kata.Length(input);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void AnswerAtEnd()
		{
			var input = "abcabcdefghi";
			var expected = 9;
			var actual = _kata.Length(input);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void RepeatAtEnd()
		{
			var input = "abcda";
			var expected = 4;
			var actual = _kata.Length(input);

			Assert.Equal(expected, actual);
		}
	}
}
