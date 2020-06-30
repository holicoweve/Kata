using Kata.LeetCode.Medium;
using NUnit.Framework;

namespace KataTests.LeetCode.Medium
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
		[TestCase("bbbbb", ExpectedResult = 1, TestName = "Same chars")]
		[TestCase("abcabcbb", ExpectedResult = 3, TestName = "Answer in beginning")]
		[TestCase("pwwkew", ExpectedResult = 3, TestName = "Answer in middle")]
		[TestCase(" ", ExpectedResult = 1, TestName = "One space")]
		[TestCase("a", ExpectedResult = 1, TestName = "One char")]
		[TestCase("abcabcdefghi", ExpectedResult = 9, TestName = "Answer at end")]
		[TestCase("abc", ExpectedResult = 3, TestName = "Full length")]
		[TestCase("abcda", ExpectedResult = 4, TestName = "Repeat at end")]
		public int TestCases(string input)
		{
			return _kata.Length(input);
		}
	}
}