using Kata;
using Xunit;

namespace KataTests
{

	public class CountNumberOfDuplicateTest
	{
		private CountNumberOfDuplicate _kata;

		public CountNumberOfDuplicateTest()
		{
			_kata = new CountNumberOfDuplicate(); ;
		}

		[Fact]
		public void EmptyStringTest()
		{
			Assert.Equal(0, _kata.DuplicateCount(""));
		}

		[Fact]
		public void NoDuplicateTest()
		{
			Assert.Equal(0, _kata.DuplicateCount("abcde"));
		}

		[Fact]
		public void CapitalTest()
		{
			Assert.Equal(2, _kata.DuplicateCount("aabBcde"));
		}

		[Fact]
		public void SimpleTest()
		{
			Assert.Equal(2, _kata.DuplicateCount("aabbcde"));
			Assert.Equal(1, _kata.DuplicateCount("Indivisibility"));
			Assert.Equal(2, _kata.DuplicateCount("Indivisibilities"));
		}

	}
}
