using Kata;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class TwoSumKataTest
	{
		private TwoSumKata _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new TwoSumKata();
		}

		[Test]
		public void QuickAnswerTest()
		{
			Assert.AreEqual(new[] { 0, 1 },
				_kata.TwoSum(new[] { 2, 7, 11, 15 }, 9));
		}

		[Test]
		public void SimpleTest()
		{
			Assert.AreEqual(new[] { 2, 3 },
				_kata.TwoSum(new[] { 15, 11, 7, 2 }, 9));
		}

		[Test]
		public void RepeatedIntInArrayTest()
		{
			Assert.AreEqual(new[] { 0, 2 },
				_kata.TwoSum(new[] { 5, 11, 5, 2 }, 10));
		}
	}
}