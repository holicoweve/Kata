using Kata;
using Xunit;

namespace KataTests
{

	public class ContainsDuplicateTwoTest
	{
		private ContainsDuplicateTwo _kata;

		public ContainsDuplicateTwoTest()
		{
			_kata = new ContainsDuplicateTwo();
		}

		[Theory]
		[InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
		[InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
		[InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
		public void SimpleTest(int[] inputs, int output, bool expected)
		{
			Assert.Equal(expected, _kata.ContainsNearbyDuplicate(inputs, output));

		}

		[Theory]
		[InlineData(new[] { 1, 2, 3, 1 }, 5, true)]
		public void LargeKTest(int[] inputs, int output, bool expected)
		{
			Assert.Equal(expected, _kata.ContainsNearbyDuplicate(inputs, output));
		}

		[Theory]
		[InlineData(new[] { 1, 2, 3, 4 }, 3, false)]
		public void NoDuplicateTest(int[] inputs, int output, bool expected)
		{
			Assert.Equal(expected, _kata.ContainsNearbyDuplicate(inputs, output));
		}
	}
}
