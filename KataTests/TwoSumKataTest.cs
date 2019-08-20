using Kata;
using Xunit;

namespace KataTests
{
	public class TwoSumKataTest
	{
		private TwoSumKata _kata;

		public TwoSumKataTest()
		{
			_kata = new TwoSumKata();
		}

		[Fact]
		public void QuickAnswerTest()
		{
			Assert.Equal(new[] { 0, 1 },
				_kata.TwoSum(new[] { 2, 7, 11, 15 }, 9));
		}

		[Fact]
		public void SimpleTest()
		{
			Assert.Equal(new[] { 2, 3 },
				_kata.TwoSum(new[] { 15, 11, 7, 2 }, 9));
		}

		[Fact]
		public void RepeatedIntInArrayTest()
		{
			Assert.Equal(new[] { 0, 2 },
				_kata.TwoSum(new[] { 5, 11, 5, 2 }, 10));
		}
	}
}