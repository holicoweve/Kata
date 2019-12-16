using Kata.LeetCode.Easy;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class LongestCommonPrefixTest
	{
		private LongestCommonPrefix _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new LongestCommonPrefix();
		}

		[Test]
		public void OneItem()
		{
			var input = new[] { "flower" };
			var expected = "flower";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void OneCharLength()
		{
			var input = new[] { "a", "b" };
			var expected = "";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void RepeatingItems()
		{
			var input = new[] { "flowerflower", "flower" };
			var expected = "flower";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void SimpleTest()
		{
			var input = new[] { "flower", "flow", "flight" };
			var expected = "fl";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void NoSolution()
		{
			var input = new[] { "dog", "racecar", "car" };
			var expected = "";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void CommonPrefixTest_SameStrings()
		{
			var input1 = "flower";
			var input2 = "flower";
			var expected = "flower";
			var actual = _kata.CommonPrefix(input1, input2);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void CommonPrefixTest_EmptyStrings()
		{
			var input1 = "";
			var input2 = "";
			var expected = "";
			var actual = _kata.CommonPrefix(input1, input2);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void CommonPrefixTest_PartialMatch()
		{
			var input1 = "tabletop";
			var input2 = "tablecloth";
			var expected = "table";
			var actual = _kata.CommonPrefix(input1, input2);
			Assert.AreEqual(expected, actual);
		}
	}
}
