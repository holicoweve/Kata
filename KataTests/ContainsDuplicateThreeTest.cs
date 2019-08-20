using Kata;
using Xunit;

namespace KataTests
{
	public class ContainsDuplicateThreeTest
	{
		private ContainsDuplicateThree _kata;

		public ContainsDuplicateThreeTest()
		{
			_kata = new ContainsDuplicateThree();
		}

		[Fact]
		public void ZeroTTest()
		{
			Assert.True(_kata.ContainsNearbyAlmostDuplicate(new int[] { 1, 2, 3, 1 }, 3, 0));
		}

		[Fact]
		public void AlmostAllOneTest()
		{
			Assert.True(_kata.ContainsNearbyAlmostDuplicate(new int[] { 1, 0, 1, 1 }, 1, 2));
		}

		[Fact]
		public void NoSolutionTest()
		{
			Assert.False(_kata.ContainsNearbyAlmostDuplicate(new int[] { 1, 5, 9, 1, 5, 9 }, 2, 3));
		}

		[Fact]
		public void IntMinValueTest()
		{
			Assert.False(_kata.ContainsNearbyAlmostDuplicate(new int[] { -1, 2147483647 }, 1, 2147483647));
		}
	}
}
