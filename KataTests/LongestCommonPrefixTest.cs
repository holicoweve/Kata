using Kata;
using Xunit;

namespace KataTests
{
	public class LongestCommonPrefixTest
	{
		private LongestCommonPrefix _kata;

		public LongestCommonPrefixTest()
		{
			_kata = new LongestCommonPrefix();
		}

		[Fact]
		public void OneItem()
		{
			var input = new[] { "flower" };
			var expected = "flower";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void OneCharLength()
		{
			var input = new[] { "a", "b" };
			var expected = "";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void RepeatingItems()
		{
			var input = new[] { "flowerflower", "flower" };
			var expected = "flower";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void SimpleTest()
		{
			var input = new[] { "flower", "flow", "flight" };
			var expected = "fl";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void NoSolution()
		{
			var input = new[] { "dog", "racecar", "car" };
			var expected = "";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void CommonPrefixTest_SameStrings()
		{
			var input1 = "flower";
			var input2 = "flower";
			var expected = "flower";
			var actual = _kata.CommonPrefix(input1, input2);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void CommonPrefixTest_EmptyStrings()
		{
			var input1 = "";
			var input2 = "";
			var expected = "";
			var actual = _kata.CommonPrefix(input1, input2);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void CommonPrefixTest_PartialMatch()
		{
			var input1 = "tabletop";
			var input2 = "tablecloth";
			var expected = "table";
			var actual = _kata.CommonPrefix(input1, input2);
			Assert.Equal(expected, actual);
		}
	}
}
