using Kata.LeetCode.Medium;
using NUnit.Framework;

namespace KataTests.LeetCode.Medium
{
	[TestFixture]
	public class BestSightseeingPairTest
	{
		private BestSightseeingPair _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new BestSightseeingPair();
		}

		[Test]
		[TestCase(new[] { 8, 1, 5, 2, 6 }, ExpectedResult = 11)]
		public int TestCases(int[] input)
		{
			return _kata.MaxScoreSightseeingPair(input);
		}
	}
}