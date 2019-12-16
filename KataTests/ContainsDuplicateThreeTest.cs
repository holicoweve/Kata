using Kata.LeetCode.Medium;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class ContainsDuplicateThreeTest
	{
		private ContainsDuplicateThree _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new ContainsDuplicateThree();
		}

		[Test]
		public void ZeroTTest()
		{
			Assert.IsTrue(_kata.ContainsNearbyAlmostDuplicate(new int[] { 1, 2, 3, 1 }, 3, 0));
		}

		[Test]
		public void AlmostAllOneTest()
		{
			Assert.IsTrue(_kata.ContainsNearbyAlmostDuplicate(new int[] { 1, 0, 1, 1 }, 1, 2));
		}

		[Test]
		public void NoSolutionTest()
		{
			Assert.IsFalse(_kata.ContainsNearbyAlmostDuplicate(new int[] { 1, 5, 9, 1, 5, 9 }, 2, 3));
		}

		[Test]
		public void IntMinValueTest()
		{
			Assert.IsFalse(_kata.ContainsNearbyAlmostDuplicate(new int[] { -1, 2147483647 }, 1, 2147483647));
		}
	}
}
