using Kata.LeetCode.Medium;
using NUnit.Framework;

namespace KataTests.LeetCode.Medium
{
	[TestFixture]
	public class SearchInRotatedSortedArrayTests
	{
		private SearchInRotatedSortedArray _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new SearchInRotatedSortedArray();
		}

		[Test]
		public void SimpleTest()
		{
			// Arrange
			int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
			int target = 0;
			int expected = 4;

			// Act
			var result = _kata.Search(
				nums,
				target);

			// Assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void EmptyNums()
		{
			// Arrange
			int[] nums = { };
			int target = 0;
			int expected = -1;

			// Act
			var result = _kata.Search(
				nums,
				target);

			// Assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void NoResult()
		{
			// Arrange
			int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
			int target = 3;
			int expected = -1;

			// Act
			var result = _kata.Search(
				nums,
				target);

			// Assert
			Assert.AreEqual(expected, result);
		}
	}
}