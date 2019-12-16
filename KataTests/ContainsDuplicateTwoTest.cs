using Kata.LeetCode.Easy;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class ContainsDuplicateTwoTest
	{
		private ContainsDuplicateTwo _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new ContainsDuplicateTwo();
		}

		[Theory]
		[TestCase(new[] { 1, 2, 3, 1 }, 3, true)]
		[TestCase(new[] { 1, 0, 1, 1 }, 1, true)]
		[TestCase(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
		public void SimpleTest(int[] inputs, int output, bool expected)
		{
			Assert.AreEqual(expected, _kata.ContainsNearbyDuplicate(inputs, output));

		}

		[Theory]
		[TestCase(new[] { 1, 2, 3, 1 }, 5, true)]
		public void LargeKTest(int[] inputs, int output, bool expected)
		{
			Assert.AreEqual(expected, _kata.ContainsNearbyDuplicate(inputs, output));
		}

		[Theory]
		[TestCase(new[] { 1, 2, 3, 4 }, 3, false)]
		public void NoDuplicateTest(int[] inputs, int output, bool expected)
		{
			Assert.AreEqual(expected, _kata.ContainsNearbyDuplicate(inputs, output));
		}
	}
}
